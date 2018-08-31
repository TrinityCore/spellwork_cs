using SpellWork.Database;
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
using WDCReaderLib;
using System.Threading.Tasks;

namespace SpellWork.DBC
{
    public static class DBC
    {
        public const string Version = "SpellWork 8.0.1 (27481)";
        public const uint MaxLevel = 120;

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
        public static Storage<SpellNameEntry>                   SpellName { get; set; }
        public static Storage<SpellXDescriptionVariablesEntry>  SpellXDescriptionVariables { get; set; }
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
                        dbc.SetValue(dbc.GetValue(null),
                            Activator.CreateInstance(dbc.PropertyType, $@"{ Settings.Default.DbcPath }\{ Settings.Default.Locale }\{ name }.db2"));
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

            foreach (var spellName in SpellName)
                SpellInfoStore[spellName.Key] = new SpellInfo(spellName.Value);

            await Task.WhenAll(Task.Run(() =>
            {
                foreach (var spellMisc in SpellMisc)
                {
                    if (SpellInfoStore.ContainsKey(spellMisc.Value.SpellID))
                        SpellInfoStore[spellMisc.Value.SpellID].Misc = spellMisc.Value;
                    else
                        continue;

                    if (SpellDuration.ContainsKey(SpellInfoStore[spellMisc.Value.SpellID].Misc.DurationIndex))
                        SpellInfoStore[spellMisc.Value.SpellID].DurationEntry = SpellDuration[SpellInfoStore[spellMisc.Value.SpellID].Misc.DurationIndex];

                    if (SpellRange.ContainsKey(SpellInfoStore[spellMisc.Value.SpellID].Misc.RangeIndex))
                        SpellInfoStore[spellMisc.Value.SpellID].Range = SpellRange[SpellInfoStore[spellMisc.Value.SpellID].Misc.RangeIndex];
                }
            }), Task.Run(() =>
            {
                foreach (var spell in Spell)
                {
                    if (SpellInfoStore.ContainsKey(spell.Value.ID))
                        SpellInfoStore[spell.Value.ID].Spell = spell.Value;
                    else
                        continue;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellEffect)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"Spell effect {effect.Value.ID} is referencing unknown spell {effect.Value.SpellID}, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Effects.Add(effect.Value);
                    SpellInfoStore[effect.Value.SpellID].SpellEffectInfoStore[effect.Value.EffectIndex] = new SpellEffectInfo(effect.Value); // Helper

                    var triggerId = (int)effect.Value.EffectTriggerSpell;
                    if (triggerId != 0)
                    {
                        if (SpellTriggerStore.ContainsKey(triggerId))
                            SpellTriggerStore[triggerId].Add(effect.Value.SpellID);
                        else
                            SpellTriggerStore.Add(triggerId, new SortedSet<int> { effect.Value.SpellID });
                    }
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellTargetRestrictions)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellTargetRestrictions: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].TargetRestrictions.Add(effect.Value);
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellXSpellVisual.Where(effect =>
                    effect.Value.DifficultyID == 0 && effect.Value.ViewerPlayerConditionID == 0))
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellXSpellVisual: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].SpellXSpellVisual = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellScaling)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellScaling: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Scaling = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellAuraOptions)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraOptions: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].AuraOptions = effect.Value;
                    if (effect.Value.SpellProcsPerMinuteID != 0)
                        SpellInfoStore[effect.Value.SpellID].ProcsPerMinute = SpellProcsPerMinute[effect.Value.SpellProcsPerMinuteID];
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellAuraRestrictions)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraRestrictions: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].AuraRestrictions = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellCategories)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCategories: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Categories = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellCastingRequirements)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCastingRequirements: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        return;
                    }

                    SpellInfoStore[effect.Value.SpellID].CastingRequirements = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellClassOptions)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellClassOptions: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].ClassOptions = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellCooldowns)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCooldowns: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Cooldowns = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellInterrupts)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellInterrupts: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Interrupts = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellEquippedItems)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellEquippedItems: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].EquippedItems = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellLevels)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine($"SpellLevels: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Levels = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellReagents)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagents: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Reagents = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var reagentsCurrency in SpellReagentsCurrency)
                {
                    if (!SpellInfoStore.ContainsKey(reagentsCurrency.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagentsCurrency: Unknown spell {reagentsCurrency.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[reagentsCurrency.Value.SpellID].ReagentsCurrency.Add(reagentsCurrency.Value);
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellShapeshift)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellShapeshift: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Shapeshift = effect.Value;
                }
            }), Task.Run(() =>
            {
                foreach (var effect in SpellTotems)
                {
                    if (!SpellInfoStore.ContainsKey(effect.Value.SpellID))
                    {
                        Console.WriteLine($"SpellTotems: Unknown spell {effect.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.Value.SpellID].Totems = effect.Value;
                }
            }));

            GameTable<GtSpellScalingEntry>.Open($@"{Settings.Default.GtPath}\SpellScaling.txt");
        }

        public static uint SelectedLevel = MaxLevel;
        public static uint SelectedItemLevel = 285;
    }
}
