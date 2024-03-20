using DBFileReaderLib;
using SpellWork.DBC.Structures;
using SpellWork.GameTables;
using SpellWork.GameTables.Structures;
using SpellWork.Properties;
using SpellWork.Spell;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SpellWork.DBC
{
    public static class DBC
    {
        public const string Version = "SpellWork 7.3.5 (26972)";
        public const uint MaxLevel = 110;

        // ReSharper disable MemberCanBePrivate.Global
        // ReSharper disable CollectionNeverUpdated.Global
        public static Storage<AreaGroupMemberEntry>             AreaGroupMember { get; set; }
        public static Storage<AreaTableEntry>                   AreaTable { get; set; }
        public static Storage<OverrideSpellDataEntry>           OverrideSpellData { get; set; }
        public static Storage<ScreenEffectEntry>                ScreenEffect { get; set; }
        public static Storage<SpellEntry>                       Spell { get; set; }
        public static Storage<SpellAuraOptionsEntry>            SpellAuraOptions { get; set; }
        public static Storage<SpellAuraRestrictionsEntry>       SpellAuraRestrictions { get; set; }
        public static Storage<SpellCastingRequirementsEntry>    SpellCastingRequirements { get; set; }
        public static Storage<SpellCastTimesEntry>              SpellCastTimes { get; set; }
        public static Storage<SpellCategoriesEntry>             SpellCategories { get; set; }
        public static Storage<SpellClassOptionsEntry>           SpellClassOptions { get; set; }
        public static Storage<SpellCooldownsEntry>              SpellCooldowns { get; set; }
        public static Storage<SpellDescriptionVariablesEntry>   SpellDescriptionVariables { get; set; }
        public static Storage<SpellDurationEntry>               SpellDuration { get; set; }
        public static Storage<SpellEffectEntry>                 SpellEffect { get; set; }
        //public static Storage<SpellEffectScalingEntry>          SpellEffectScaling { get; set; }
        public static Storage<SpellMiscEntry>                   SpellMisc { get; set; }
        public static Storage<SpellEquippedItemsEntry>          SpellEquippedItems { get; set; }
        public static Storage<SpellInterruptsEntry>             SpellInterrupts { get; set; }
        public static Storage<SpellLevelsEntry>                 SpellLevels { get; set; }
        public static Storage<SpellPowerEntry>                  SpellPower { get; set; }
        public static Storage<SpellRadiusEntry>                 SpellRadius { get; set; }
        public static Storage<SpellRangeEntry>                  SpellRange { get; set; }
        public static Storage<SpellScalingEntry>                SpellScaling { get; set; }
        public static Storage<SpellShapeshiftEntry>             SpellShapeshift { get; set; }
        public static Storage<SpellTargetRestrictionsEntry>     SpellTargetRestrictions { get; set; }
        public static Storage<SpellTotemsEntry>                 SpellTotems { get; set; }
        public static Storage<SpellXSpellVisualEntry>           SpellXSpellVisual { get; set; }
        public static Storage<RandPropPointsEntry>              RandPropPoints { get; set; }
        public static Storage<SpellProcsPerMinuteEntry>         SpellProcsPerMinute { get; set; }

        public static Storage<SkillLineAbilityEntry>            SkillLineAbility { get; set; }
        public static Storage<SkillLineEntry>                   SkillLine { get; set; }

        public static Storage<ItemEntry>                        Item { get; set; }
        public static Storage<ItemEffectEntry>                  ItemEffect { get; set; }
        public static Storage<ItemSparseEntry>                  ItemSparse { get; set; }

        public static Storage<SpellReagentsEntry>               SpellReagents { get; set; }
        public static Storage<SpellReagentsCurrencyEntry>       SpellReagentsCurrency { get; set; }
        public static Storage<SpellMissileEntry>                SpellMissile { get; set; }
        // ReSharper restore MemberCanBePrivate.Global
        // ReSharper restore CollectionNeverUpdated.Global

        // public static Storage<SpellMissileMotionEntry>         SpellMissileMotion { get; public set; }
        // public static Storage<SpellVisualEntry>                SpellVisual { get; public set; }

        public static readonly IDictionary<int, SpellInfo> SpellInfoStore = new ConcurrentDictionary<int, SpellInfo>();
        public static readonly IDictionary<int, ISet<int>> SpellTriggerStore = new Dictionary<int, ISet<int>>();

        public static async void Load()
        {
            Parallel.ForEach(
                typeof (DBC).GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), dbc =>
                {
                    if (!dbc.PropertyType.IsGenericType ||
                        dbc.PropertyType.GetGenericTypeDefinition() != typeof (Storage<>))
                        return;

                    var name = dbc.Name;

                    try
                    {
                        var db2Reader = new DBReader($@"{Settings.Default.DbcPath}\{Settings.Default.Locale}\{name}.db2");
                        dynamic storage = Activator.CreateInstance(dbc.PropertyType, db2Reader);
                        dbc.SetValue(dbc.GetValue(null), storage);
                    }
                    catch (DirectoryNotFoundException)
                    {
                    }
                    catch (TargetInvocationException tie)
                    {
                        if (tie.InnerException is ArgumentException)
                            throw new ArgumentException($"Failed to load {name}.db2: {tie.InnerException.Message}");
                        throw;
                    }
                });

            foreach (var spell in Spell)
                SpellInfoStore[spell.Value.ID] = new SpellInfo(spell.Value);

            await Task.WhenAll(Task.Run(() =>
            {
                foreach (var spellMisc in SpellMisc.Values.Where(misc => SpellInfoStore.ContainsKey(misc.SpellID)))
                {
                    if (spellMisc.DifficultyID != 0)
                        continue;

                    var spell = SpellInfoStore[spellMisc.SpellID];
                    spell.Misc = spellMisc;

                    if (SpellDuration.ContainsKey(spellMisc.DurationIndex))
                        spell.DurationEntry = SpellDuration[spellMisc.DurationIndex];

                    if (SpellRange.ContainsKey(spellMisc.RangeIndex))
                        spell.Range = SpellRange[spellMisc.RangeIndex];
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellEffect.Values)
                {
                    if (!SpellInfoStore.ContainsKey(effect.SpellID))
                    {
                        Console.WriteLine(
                            $"Spell effect {effect.ID} is referencing unknown spell {effect.SpellID}, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.SpellID].Effects.Add(effect);
                    SpellInfoStore[effect.SpellID].SpellEffectInfoStore[(uint)effect.EffectIndex] = new SpellEffectInfo(effect); // Helper

                    var triggerId = (int)effect.EffectTriggerSpell;
                    if (triggerId != 0)
                    {
                        if (SpellTriggerStore.ContainsKey(triggerId))
                            SpellTriggerStore[triggerId].Add(effect.SpellID);
                        else
                            SpellTriggerStore.Add(triggerId, new SortedSet<int> { effect.SpellID });
                    }
                }
            }), Task.Run(() =>
            {
                foreach (var spellTargetRestrictions in SpellTargetRestrictions.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellTargetRestrictions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellTargetRestrictions: Unknown spell {spellTargetRestrictions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellTargetRestrictions.SpellID].TargetRestrictions.Add(spellTargetRestrictions);
                }
            }), Task.Run(() =>
            {
                foreach (var spellXSpellVisual in SpellXSpellVisual.Values.Where(effect => effect.CasterPlayerConditionID == 0))
                {
                    if (spellXSpellVisual.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellXSpellVisual.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellXSpellVisual: Unknown spell {spellXSpellVisual.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellXSpellVisual.SpellID].SpellXSpellVisual = spellXSpellVisual;
                }
            }), Task.Run(() =>
            {
                foreach (var spellScaling in SpellScaling.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellScaling.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellScaling: Unknown spell {spellScaling.SpellID} referenced, ignoring!");
                        continue;
                    }
                    SpellInfoStore[spellScaling.SpellID].Scaling = spellScaling;
                }
            }), Task.Run(() =>
            {
                foreach (var spellAuraOptions in SpellAuraOptions.Values)
                {
                    if (spellAuraOptions.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellAuraOptions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraOptions: Unknown spell {spellAuraOptions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellAuraOptions.SpellID].AuraOptions = spellAuraOptions;
                    if (spellAuraOptions.SpellProcsPerMinuteID != 0)
                        SpellInfoStore[spellAuraOptions.SpellID].ProcsPerMinute = SpellProcsPerMinute[spellAuraOptions.SpellProcsPerMinuteID];
                }
            }), Task.Run(() =>
            {
                foreach (var spellAuraRestrictions in SpellAuraRestrictions.Values)
                {
                    if (spellAuraRestrictions.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellAuraRestrictions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraRestrictions: Unknown spell {spellAuraRestrictions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellAuraRestrictions.SpellID].AuraRestrictions = spellAuraRestrictions;
                }
            }), Task.Run(() =>
            {
                foreach (var spellCategory in SpellCategories.Values)
                {
                    if (spellCategory.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellCategory.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCategories: Unknown spell {spellCategory.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellCategory.SpellID].Categories = spellCategory;
                }
            }), Task.Run(() =>
            {
                foreach (var spellCasting in SpellCastingRequirements.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellCasting.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCastingRequirements: Unknown spell {spellCasting.SpellID} referenced, ignoring!");
                        return;
                    }

                    SpellInfoStore[spellCasting.SpellID].CastingRequirements = spellCasting;
                }
            }), Task.Run(() =>
            {
                foreach (var spellClassOptions in SpellClassOptions.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellClassOptions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellClassOptions: Unknown spell {spellClassOptions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellClassOptions.SpellID].ClassOptions = spellClassOptions;
                }
            }), Task.Run(() =>
            {
                foreach (var spellCooldown in SpellCooldowns.Values)
                {
                    if (spellCooldown.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellCooldown.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCooldowns: Unknown spell {spellCooldown.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellCooldown.SpellID].Cooldowns = spellCooldown;
                }
            }), Task.Run(() =>
            {
                foreach (var spellInterrupts in SpellInterrupts.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellInterrupts.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellInterrupts: Unknown spell {spellInterrupts.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellInterrupts.SpellID].Interrupts = spellInterrupts;
                }
            }), Task.Run(() =>
            {
                foreach (var spellEquippedItem in SpellEquippedItems.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellEquippedItem.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellEquippedItems: Unknown spell {spellEquippedItem.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellEquippedItem.SpellID].EquippedItems = spellEquippedItem;
                }
            }), Task.Run(() =>
            {
                foreach (var spellLevel in SpellLevels.Values)
                {
                    if (spellLevel.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellLevel.SpellID))
                    {
                        Console.WriteLine($"SpellLevels: Unknown spell {spellLevel.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellLevel.SpellID].Levels = spellLevel;
                }
            }), Task.Run(() =>
            {
                foreach (var spellReagents in SpellReagents)
                {
                    if (!SpellInfoStore.ContainsKey(spellReagents.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagents: Unknown spell {spellReagents.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellReagents.Value.SpellID].Reagents = spellReagents.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var reagentsCurrency in SpellReagentsCurrency.Values)
                {
                    if (!SpellInfoStore.ContainsKey(reagentsCurrency.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagentsCurrency: Unknown spell {reagentsCurrency.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[reagentsCurrency.SpellID].ReagentsCurrency.Add(reagentsCurrency);
                }
            }), Task.Run(() =>
            {
                foreach (var spellShapeShift in SpellShapeshift.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellShapeShift.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellShapeshift: Unknown spell {spellShapeShift.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellShapeShift.SpellID].Shapeshift = spellShapeShift;
                }
            }), Task.Run(() =>
            {
                foreach (var spellTotem in SpellTotems.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellTotem.SpellID))
                    {
                        Console.WriteLine($"SpellTotems: Unknown spell {spellTotem.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellTotem.SpellID].Totems = spellTotem;
                }
            }));

            GameTable<GtSpellScalingEntry>.Open($@"{Settings.Default.GtPath}\SpellScaling.txt");
        }

        public static uint SelectedLevel = MaxLevel;
        public static uint SelectedItemLevel = 890;
    }
}
