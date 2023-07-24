using DBFileReaderLib;
using SpellWork.Database;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using SpellWork.GameTables;
using SpellWork.GameTables.Structures;
using SpellWork.Properties;
using SpellWork.Spell;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace SpellWork.DBC
{
    public static class DBC
    {
        public const string Version = "SpellWork 10.1.0 (49318)";
        public const uint MaxLevel = 70;
        public const uint MaxItemLevel = 1300;

        public static Storage<AreaGroupMemberEntry>             AreaGroupMember { get; set; }
        public static Storage<AreaTableEntry>                   AreaTable { get; set; }
        public static Storage<ContentTuningEntry>               ContentTuning { get; set; }
        public static Storage<ContentTuningXExpectedEntry>      ContentTuningXExpected { get; set; }
        public static Storage<DifficultyEntry>                  Difficulty { get; set; }
        public static Storage<ExpectedStatEntry>                ExpectedStat { get; set; }
        public static Storage<ExpectedStatModEntry>             ExpectedStatMod { get; set; }
        public static Storage<MapEntry>                         Map { get; set; }
        public static Storage<MapDifficultyEntry>               MapDifficulty { get; set; }
        public static Storage<OverrideSpellDataEntry>           OverrideSpellData { get; set; }
        public static Storage<ScreenEffectEntry>                ScreenEffect { get; set; }
        public static Storage<SpellCastTimesEntry>              SpellCastTimes { get; set; }
        public static Storage<SpellCategoryEntry>               SpellCategory { get; set; }
        public static Storage<SpellDurationEntry>               SpellDuration { get; set; }
        public static Storage<SpellRadiusEntry>                 SpellRadius { get; set; }
        public static Storage<SpellRangeEntry>                  SpellRange { get; set; }
        public static Storage<RandPropPointsEntry>              RandPropPoints { get; set; }

        public static Storage<SkillLineAbilityEntry>            SkillLineAbility { get; set; }
        public static Storage<SkillLineEntry>                   SkillLine { get; set; }

        public static readonly IDictionary<int, SpellInfo> SpellInfoStore = new ConcurrentDictionary<int, SpellInfo>();
        public static readonly IDictionary<int, ISet<int>> SpellTriggerStore = new Dictionary<int, ISet<int>>();

        public static long DataLoadedInMs { get; set; }

        public static async Task Load()
        {
            var watch = new Stopwatch();
            watch.Start();

            HotfixReader hotfixReader = null;
            try
            {
                hotfixReader = new HotfixReader(Settings.Default.HotfixCachePath);
            }
            catch (Exception)
            {
                Console.WriteLine(
                    $"Hotfix cache {Settings.Default.HotfixCachePath} cannot be loaded, ignoring!");
            }

            Parallel.ForEach(
                typeof(DBC).GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), dbc =>
               {
                   if (!dbc.PropertyType.IsGenericType ||
                       dbc.PropertyType.GetGenericTypeDefinition() != typeof(Storage<>))
                       return;

                   var name = dbc.Name;

                   try
                   {
                       var db2Reader = new DBReader($@"{Settings.Default.DbcPath}\{Settings.Default.Locale}\{name}.db2");

                       dynamic storage = Activator.CreateInstance(dbc.PropertyType, db2Reader);

                       if (hotfixReader != null)
                           hotfixReader.ApplyHotfixes(storage, db2Reader);

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

            await Task.WhenAll(Task.Run(() =>
            {
                var spells = CreateInstance<Storage<SpellEntry>>("Spell", hotfixReader);
                var spellNames = CreateInstance<Storage<SpellNameEntry>>("SpellName", hotfixReader);
                foreach (var spell in spellNames)
                    SpellInfoStore[(int) spell.Value.ID] = new SpellInfo(spell.Value.Name, spells.GetValue((int) spell.Value.ID));
            }));

            await Task.WhenAll(Task.Run(() =>
            {
                var spellMiscs = CreateInstance<Storage<SpellMiscEntry>>("SpellMisc", hotfixReader);
                foreach (var spellMisc in spellMiscs.Values.Where(misc => SpellInfoStore.ContainsKey(misc.SpellID)))
                {
                    if (spellMisc.DifficultyID != 0)
                        continue;

                    var spell = SpellInfoStore[spellMisc.SpellID];

                    spell.Misc = spellMisc;

                    if (SpellDuration.TryGetValue(spellMisc.DurationIndex, out var durationEntry))
                        spell.DurationEntry = durationEntry;

                    if (SpellRange.TryGetValue(spellMisc.RangeIndex, out var rangeEntry))
                        spell.Range = rangeEntry;
                }
            }), Task.Run(() =>
            {
                var spellEffects = CreateInstance<Storage<SpellEffectEntry>>("SpellEffect", hotfixReader);
                foreach (var effect in spellEffects.Values)
                {
                    if (!SpellInfoStore.ContainsKey(effect.SpellID))
                    {
                        Console.WriteLine(
                            $"Spell effect {effect.ID} is referencing unknown spell {effect.SpellID}, ignoring!");
                        continue;
                    }

                    SpellInfoStore[effect.SpellID].SpellEffectInfoStore.Add(new SpellEffectInfo(effect)); // Helper

                    var triggerId = effect.EffectTriggerSpell;
                    if (triggerId == 0) 
                        continue;

                    if (SpellTriggerStore.TryGetValue(triggerId, out var trigger))
                        trigger.Add(effect.SpellID);
                    else
                        SpellTriggerStore.Add(triggerId, new SortedSet<int> { effect.SpellID });
                }
                    {
                        if (SpellTriggerStore.ContainsKey(triggerId))
                            SpellTriggerStore[triggerId].Add(effect.SpellID);
                        else
                            SpellTriggerStore.Add(triggerId, new SortedSet<int> { effect.SpellID });
                    }

                    SpellInfoStore[traitDefinition.SpellID].TraitDefinitions.Add(traitDefinition);
                }
            }), Task.Run(() =>
            {
                var spellTargetRestrictions = CreateInstance<Storage<SpellTargetRestrictionsEntry>>("SpellTargetRestrictions", hotfixReader);
                foreach (var spellTargetRestriction in spellTargetRestrictions.Values)
                {
                    if (spellTargetRestriction.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(spellTargetRestriction.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellTargetRestrictions: Unknown spell {spellTargetRestriction.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellTargetRestriction.SpellID].TargetRestrictions = spellTargetRestriction;
                }
            }), Task.Run(() =>
            {
                var spellXSpellVisuals = CreateInstance<Storage<SpellXSpellVisualEntry>>("SpellXSpellVisual", hotfixReader);
                foreach (var spellXSpellVisual in spellXSpellVisuals.Values.Where(effect => effect.CasterPlayerConditionID == 0))
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
                var spellScalings = CreateInstance<Storage<SpellScalingEntry>>("SpellScaling", hotfixReader);
                foreach (var spellScaling in spellScalings.Values)
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
                var spellAuraOptions = CreateInstance<Storage<SpellAuraOptionsEntry>>("SpellAuraOptions", hotfixReader);
                var spellProcsPerMinutes = CreateInstance<Storage<SpellProcsPerMinuteEntry>>("SpellProcsPerMinute", hotfixReader);
                foreach (var auraOptions in spellAuraOptions.Values)
                {
                    if (auraOptions.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(auraOptions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraOptions: Unknown spell {auraOptions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[auraOptions.SpellID].AuraOptions = auraOptions;
                    if (auraOptions.SpellProcsPerMinuteID != 0)
                        SpellInfoStore[auraOptions.SpellID].ProcsPerMinute = spellProcsPerMinutes[auraOptions.SpellProcsPerMinuteID];
                }
            }), Task.Run(() =>
            {
                var spellAuraRestrictions = CreateInstance<Storage<SpellAuraRestrictionsEntry>>("SpellAuraRestrictions", hotfixReader);
                foreach (var auraRestrictions in spellAuraRestrictions.Values)
                {
                    if (auraRestrictions.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(auraRestrictions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellAuraRestrictions: Unknown spell {auraRestrictions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[auraRestrictions.SpellID].AuraRestrictions = auraRestrictions;
                }
            }), Task.Run(() =>
            {
                var spellCategories = CreateInstance<Storage<SpellCategoriesEntry>>("SpellCategories", hotfixReader);
                foreach (var categories in spellCategories.Values)
                {
                    if (categories.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(categories.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCategories: Unknown spell {categories.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[categories.SpellID].Categories = categories;
                }
            }), Task.Run(() =>
            {
                var spellCastingRequirements = CreateInstance<Storage<SpellCastingRequirementsEntry>>("SpellCastingRequirements", hotfixReader);
                foreach (var castingRequirements in spellCastingRequirements.Values)
                {
                    if (!SpellInfoStore.ContainsKey(castingRequirements.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCastingRequirements: Unknown spell {castingRequirements.SpellID} referenced, ignoring!");
                        return;
                    }

                    SpellInfoStore[castingRequirements.SpellID].CastingRequirements = castingRequirements;
                }
            }), Task.Run(() =>
            {
                var spellClassOptions = CreateInstance<Storage<SpellClassOptionsEntry>>("SpellClassOptions", hotfixReader);
                foreach (var classOptions in spellClassOptions.Values)
                {
                    if (!SpellInfoStore.ContainsKey(classOptions.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellClassOptions: Unknown spell {classOptions.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[classOptions.SpellID].ClassOptions = classOptions;
                }
            }), Task.Run(() =>
            {
                var spellCooldowns = CreateInstance<Storage<SpellCooldownsEntry>>("SpellCooldowns", hotfixReader);
                foreach (var cooldowns in spellCooldowns.Values)
                {
                    if (cooldowns.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(cooldowns.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellCooldowns: Unknown spell {cooldowns.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[cooldowns.SpellID].Cooldowns = cooldowns;
                }
            }), Task.Run(() =>
            {
                var spellInterrupts = CreateInstance<Storage<SpellInterruptsEntry>>("SpellInterrupts", hotfixReader);
                foreach (var interrupt in spellInterrupts)
                {
                    if (interrupt.Value.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(interrupt.Value.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellInterrupts: Unknown spell {interrupt.Value.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[interrupt.Value.SpellID].Interrupts = interrupt.Value;
                }
            }), Task.Run(() =>
            {
                var spellEquippedItems = CreateInstance<Storage<SpellEquippedItemsEntry>>("SpellEquippedItems", hotfixReader);
                foreach (var equippedItems in spellEquippedItems.Values)
                {
                    if (!SpellInfoStore.ContainsKey(equippedItems.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellEquippedItems: Unknown spell {equippedItems.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[equippedItems.SpellID].EquippedItems = equippedItems;
                }
            }), Task.Run(() =>
            {
                var spellLabels = CreateInstance<Storage<SpellLabelEntry>>("SpellLabel", hotfixReader);
                foreach (var label in spellLabels.Values)
                {
                    if (!SpellInfoStore.ContainsKey(label.SpellID))
                    {
                        Console.WriteLine($"SpellLabel: Unknown spell {label.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[label.SpellID].Labels.Add(label.LabelID);
                }
            }), Task.Run(() =>
            {
                var spellLevels = CreateInstance<Storage<SpellLevelsEntry>>("SpellLevels", hotfixReader);
                foreach (var levels in spellLevels.Values)
                {
                    if (levels.DifficultyID != 0)
                        continue;

                    if (!SpellInfoStore.ContainsKey(levels.SpellID))
                    {
                        Console.WriteLine($"SpellLevels: Unknown spell {levels.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[levels.SpellID].Levels = levels;
                }
            }), Task.Run(() =>
            {
                var spellPowers = CreateInstance<Storage<SpellPowerEntry>>("SpellPower", hotfixReader);
                foreach (var power in spellPowers.Values)
                {
                    if (!SpellInfoStore.ContainsKey(power.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellPower: Unknown spell {power.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[power.SpellID].Powers.Add(power);
                }
            }), Task.Run(() =>
            {
                var spellReagents = CreateInstance<Storage<SpellReagentsEntry>>("SpellReagents", hotfixReader);
                foreach (var reagents in spellReagents.Values)
                {
                    if (!SpellInfoStore.ContainsKey(reagents.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagents: Unknown spell {reagents.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[reagents.SpellID].Reagents = reagents;
                }
            }), Task.Run(() =>
            {
                var spellReagentsCurrencies = CreateInstance<Storage<SpellReagentsCurrencyEntry>>("SpellReagentsCurrency", hotfixReader);
                foreach (var spellReagentsCurrency in spellReagentsCurrencies.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellReagentsCurrency.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellReagentsCurrency: Unknown spell {spellReagentsCurrency.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellReagentsCurrency.SpellID].ReagentsCurrency.Add(spellReagentsCurrency);
                }
            }), Task.Run(() =>
            {
                var spellShapeshifts = CreateInstance<Storage<SpellShapeshiftEntry>>("SpellShapeshift", hotfixReader);
                foreach (var spellShapeshift in spellShapeshifts.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellShapeshift.SpellID))
                    {
                        Console.WriteLine(
                            $"SpellShapeshift: Unknown spell {spellShapeshift.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellShapeshift.SpellID].Shapeshift = spellShapeshift;
                }
            }), Task.Run(() =>
            {
                var spellTotems = CreateInstance<Storage<SpellTotemsEntry>>("SpellTotems", hotfixReader);
                foreach (var spellTotem in spellTotems.Values)
                {
                    if (!SpellInfoStore.ContainsKey(spellTotem.SpellID))
                    {
                        Console.WriteLine($"SpellTotems: Unknown spell {spellTotem.SpellID} referenced, ignoring!");
                        continue;
                    }

                    SpellInfoStore[spellTotem.SpellID].Totems = spellTotem;
                }
            }), Task.Run(() =>
            {
                var spellXDescriptionVariables = CreateInstance<Storage<SpellXDescriptionVariablesEntry>>("SpellXDescriptionVariables", hotfixReader);
                var spellDescriptionVariables = CreateInstance<Storage<SpellDescriptionVariablesEntry>>("SpellDescriptionVariables", hotfixReader);
                foreach (var descriptionVariable in spellXDescriptionVariables.Values)
                {
                    if (!SpellInfoStore.ContainsKey(descriptionVariable.SpellID))
                    {
                        Console.WriteLine($"SpellXDescriptionVariables: Unknown spell {descriptionVariable.SpellID} referenced, ignoring!");
                        continue;
                    }
                    SpellInfoStore[descriptionVariable.SpellID].DescriptionVariables = spellDescriptionVariables.GetValue(descriptionVariable.SpellDescriptionVariablesID);
                }
            }), Task.Run(() =>
            {
                var itemEffects = CreateInstance<Storage<ItemEffectEntry>>("ItemEffect", hotfixReader);
                var itemSparses = CreateInstance<Storage<ItemSparseEntry>>("ItemSparse", hotfixReader);
                var itemXItemEffects = CreateInstance<Storage<ItemXItemEffectEntry>>("ItemXItemEffect", hotfixReader);

                foreach (var (_, itemXItemEffect) in itemXItemEffects)
                {
                    itemEffects.TryGetValue(itemXItemEffect.ItemEffectID, out var itemEffect);
                    if (itemEffect == null)
                        continue;

                    if (!SpellInfoStore.ContainsKey(itemEffect.SpellID))
                        continue;

                    itemEffect.ItemID = itemXItemEffect.ItemID;
                    if (itemSparses.TryGetValue(itemXItemEffect.ItemID, out var item))
                        itemEffect.Item = item;

                    SpellInfoStore[itemEffect.SpellID].ItemEffects.Add(itemEffect);
                }
            }));

            if (Settings.Default.UseDbConnect)
                MySqlConnection.LoadServersideSpells();

            GameTable<GtSpellScalingEntry>.Open($@"{Settings.Default.GtPath}\SpellScaling.txt");

            DataLoadedInMs = watch.ElapsedMilliseconds;

            // The GC doesn't free all the garbage left, so we clear it here after loading
            Collect();
        }

        private static void Collect()
        {
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive, blocking: true, compacting: true);
            GC.WaitForPendingFinalizers();
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive, blocking: true, compacting: true);
        }

        private static T CreateInstance<T>(string name, HotfixReader hotfixReader)
        {
            Type type = typeof(T);
            if (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(Storage<>))
                return default;

            var db2Reader = new DBReader($@"{Settings.Default.DbcPath}\{Settings.Default.Locale}\{name}.db2");

            dynamic storage = Activator.CreateInstance(typeof(T), db2Reader);

            if (hotfixReader != null)
                hotfixReader.ApplyHotfixes(storage, db2Reader);

            return storage;
        }
        }

        public static uint SelectedLevel = MaxLevel;
        public static uint SelectedItemLevel = 475;
        public static MapDifficultyEntry SelectedMapDifficulty;
    }
}
