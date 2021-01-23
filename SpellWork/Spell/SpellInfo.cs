using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using SpellWork.GameTables;
using SpellWork.GameTables.Structures;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpellWork.Spell
{
    public class SpellInfo
    {
        public SpellEntry Spell { get; set; }
        public SpellNameEntry SpellName { get; set; }
        public SpellAuraOptionsEntry AuraOptions { get; set; }
        public SpellAuraRestrictionsEntry AuraRestrictions { get; set; }
        public SpellCastingRequirementsEntry CastingRequirements { get; set; }
        public SpellCategoriesEntry Categories { get; set; }
        public SpellClassOptionsEntry ClassOptions { get; set; }
        public SpellCooldownsEntry Cooldowns { get; set; }
        public SpellEquippedItemsEntry EquippedItems { get; set; }
        public SpellInterruptsEntry Interrupts { get; set; }
        public SpellLevelsEntry Levels { get; set; }
        public SpellMiscEntry Misc { get; set; }
        public List<SpellPowerEntry> Powers { get; } = new List<SpellPowerEntry>();
        public SpellReagentsEntry Reagents { get; set; }
        public List<SpellReagentsCurrencyEntry> ReagentsCurrency { get; } = new List<SpellReagentsCurrencyEntry>();
        public SpellScalingEntry Scaling { get; set; }
        public SpellShapeshiftEntry Shapeshift { get; set; }
        public List<SpellTargetRestrictionsEntry> TargetRestrictions { get; } = new List<SpellTargetRestrictionsEntry>();
        public SpellTotemsEntry Totems { get; set; }
        public SpellXSpellVisualEntry SpellXSpellVisual { get; set; }
        public List<SpellEffectEntry> Effects { get; } = new List<SpellEffectEntry>(32);
        public SpellProcsPerMinuteEntry ProcsPerMinute { get; set; }
        public SpellDescriptionVariablesEntry DescriptionVariables { get; set; }
        public SpellDurationEntry DurationEntry { get; set; }
        public SpellRangeEntry Range { get; set; }

        // Helper
        public readonly IDictionary<int, SpellEffectInfo> SpellEffectInfoStore = new ConcurrentDictionary<int, SpellEffectInfo>();

        #region SpellDuration
        public int Duration => DurationEntry?.Duration ?? 0;
        public int MaxDuration => DurationEntry?.MaxDuration ?? 0;
        #endregion

        #region Spell
        public int ID => (int)SpellName.ID;
        public string Name => SpellName.Name;
        public string Description => Spell?.Description ?? string.Empty;
        public string Tooltip => Spell?.AuraDescription ?? string.Empty;
        #endregion

        #region SpellMisc
        // SpellMisc
        public uint Attributes => (uint)(Misc?.Attributes[0] ?? 0);
        public uint AttributesEx => (uint)(Misc?.Attributes[1] ?? 0);
        public uint AttributesEx2 => (uint)(Misc?.Attributes[2] ?? 0);
        public uint AttributesEx3 => (uint)(Misc?.Attributes[3] ?? 0);
        public uint AttributesEx4 => (uint)(Misc?.Attributes[4] ?? 0);
        public uint AttributesEx5 => (uint)(Misc?.Attributes[5] ?? 0);
        public uint AttributesEx6 => (uint)(Misc?.Attributes[6] ?? 0);
        public uint AttributesEx7 => (uint)(Misc?.Attributes[7] ?? 0);
        public uint AttributesEx8 => (uint)(Misc?.Attributes[8] ?? 0);
        public uint AttributesEx9 => (uint)(Misc?.Attributes[9] ?? 0);
        public uint AttributesEx10 => (uint)(Misc?.Attributes[10] ?? 0);
        public uint AttributesEx11 => (uint)(Misc?.Attributes[11] ?? 0);
        public uint AttributesEx12 => (uint)(Misc?.Attributes[12] ?? 0);
        public uint AttributesEx13 => (uint)(Misc?.Attributes[13] ?? 0);
        public uint AttributesEx14 => (uint)(Misc?.Attributes[14] ?? 0);
        public float Speed => Misc?.Speed ?? 0;
        public int CastingTimeIndex => Misc?.CastingTimeIndex ?? 0;
        public int ActiveIconFileDataID => Misc?.ActiveIconFileDataID ?? 0;
        public int SpellIconFileDataID => Misc?.SpellIconFileDataID ?? 0;
        public int RangeIndex => Misc?.RangeIndex ?? 0;
        public uint SchoolMask => (Misc?.SchoolMask ?? 0);
        #endregion

        #region SpellClassOptions
        // SpellClassOptions
        public uint ModalNextSpell => ClassOptions?.ModalNextSpell ?? 0;
        public uint SpellFamilyName => ClassOptions?.SpellClassSet ?? 0;
        public uint[] SpellClassMask => Array.ConvertAll(ClassOptions?.SpellClassMask ?? new int[4], i => (uint)i);
        #endregion

        #region SpellCategories
        // SpellCategories
        public int DamageClass => Categories?.DefenseType ?? 0;
        public int PreventionType => Categories?.PreventionType ?? 0;
        public int Category => Categories?.Category ?? 0;
        public int Dispel => Categories?.DispelType ?? 0;
        public int Mechanic => Categories?.Mechanic ?? 0;
        #endregion

        #region SpellShapeshift
        // SpellShapeshift
        public long Stances => ((Shapeshift?.ShapeshiftMask[0] ?? 0) << 32) | (Shapeshift?.ShapeshiftMask[1] ?? 0);
        public long StancesNot => ((Shapeshift?.ShapeshiftExclude[0] ?? 0) << 32) | (Shapeshift?.ShapeshiftExclude[1] ?? 0);
        #endregion

        #region SpellCooldowns
        // SpellCooldowns
        public int CategoryRecoveryTime => Cooldowns?.CategoryRecoveryTime ?? 0;
        public int RecoveryTime => Cooldowns?.RecoveryTime ?? 0;
        public int StartRecoveryTime => Cooldowns?.StartRecoveryTime ?? 0;
        public int StartRecoveryCategory => Categories?.StartRecoveryCategory ?? 0;
        #endregion

        #region SpellAuraRestrictions
        // SpellAuraRestrictions
        public int CasterAuraState => AuraRestrictions?.CasterAuraState ?? 0;
        public int TargetAuraState => AuraRestrictions?.TargetAuraState ?? 0;
        public int CasterAuraStateNot => AuraRestrictions?.ExcludeCasterAuraState ?? 0;
        public int TargetAuraStateNot => AuraRestrictions?.ExcludeTargetAuraState ?? 0;
        public int CasterAuraSpell => AuraRestrictions?.CasterAuraSpell ?? 0;
        public int TargetAuraSpell => AuraRestrictions?.TargetAuraSpell ?? 0;
        public int ExcludeCasterAuraSpell => AuraRestrictions?.ExcludeCasterAuraSpell ?? 0;
        public int ExcludeTargetAuraSpell => AuraRestrictions?.ExcludeTargetAuraSpell ?? 0;
        #endregion

        #region SpellAuraOptions
        public int ProcCharges => AuraOptions?.ProcCharges ?? 0;
        public uint ProcChance => AuraOptions?.ProcChance ?? 0;
        public uint ProcFlags => (uint)(AuraOptions?.ProcTypeMask[0] ?? 0);
        public uint ProcFlagsEx => (uint)(AuraOptions?.ProcTypeMask[1] ?? 0);
        public uint CumulativeAura => AuraOptions?.CumulativeAura ?? 0;
        public int ProcCooldown => AuraOptions?.ProcCategoryRecovery ?? 0;
        #endregion

        #region SpellLevels
        // SpellLevels
        public int BaseLevel => Levels?.BaseLevel ?? 0;
        public int MaxLevel => Levels?.MaxLevel ?? 0;
        public int SpellLevel => Levels?.SpellLevel ?? 0;
        public int MaxPassiveAuraLevel => Levels?.MaxPassiveAuraLevel ?? 0;
        #endregion

        #region EquippedItems
        // Equippeditems
        public int EquippedItemClass => EquippedItems?.EquippedItemClass ?? 0;
        public int EquippedItemInvTypes => EquippedItems?.EquippedItemInvTypes ?? 0;
        public int EquippedItemSubclass => EquippedItems?.EquippedItemSubclass ?? 0;
        #endregion

        #region SpellXSpellVisual
        public uint SpellVisualID => SpellXSpellVisual?.SpellVisualID ?? 0;
        #endregion

        #region CastingRequirements
        public uint RequiredAreasId => CastingRequirements?.RequiredAreasID ?? 0;
        public uint FacingCasterFlags => CastingRequirements?.FacingCasterFlags ?? 0;
        public uint MinFactionID => CastingRequirements?.MinFactionID ?? 0;
        public int MinReputation => CastingRequirements?.MinReputation ?? 0;
        public uint RequiredAuraVision => CastingRequirements?.RequiredAuraVision ?? 0;
        public uint RequiresSpellFocus => CastingRequirements?.RequiresSpellFocus ?? 0;
        #endregion

        #region SpellProcsPerMinute
        public float BaseProcRate => ProcsPerMinute?.BaseProcRate ?? 0;
        public byte ProcsPerMinuteFlags => ProcsPerMinute?.Flags ?? 0;
        #endregion

        #region SpellInterrupts
        // SpellInterrupts
        public int AuraInterruptFlags => Interrupts?.AuraInterruptFlags[0] ?? 0;
        public int AuraInterruptFlags2 => Interrupts?.AuraInterruptFlags[1] ?? 0;
        public int ChannelInterruptFlags => Interrupts?.ChannelInterruptFlags[0] ?? 0;
        public int ChannelInterruptFlags2 => Interrupts?.ChannelInterruptFlags[1] ?? 0;
        public int InterruptFlags => Interrupts?.InterruptFlags ?? 0;
        #endregion

        public string ProcInfo
        {
            get
            {
                var i = 0;
                var sb = new StringBuilder();
                var proc = ProcFlags;
                while (proc != 0)
                {
                    if ((proc & 1) != 0)
                        sb.AppendFormatLine("  {0}", SpellEnums.ProcFlagDesc[i]);
                    ++i;
                    proc >>= 1;
                }
                proc = ProcFlagsEx;
                while (proc != 0)
                {
                    if ((proc & 1) != 0)
                        sb.AppendFormatLine("  {0}", SpellEnums.ProcFlagDesc[i + 32]);
                    ++i;
                    proc >>= 1;
                }

                return sb.ToString();
            }
        }

        private const string Separator = "=================================================";

        public SpellInfo(SpellNameEntry spellName, SpellEntry spellEntry)
        {
            Spell = spellEntry;
            SpellName = spellName;
        }

        public void Write(RichTextBox rtb)
        {
            rtb.Clear();

            rtb.SetBold();
            rtb.AppendFormatLine("ID - {0} {1}{2}",
                ID, Name, Scaling != null ? $" (Level {DBC.DBC.SelectedLevel})" : string.Empty);
            rtb.SetDefaultStyle();

            rtb.AppendFormatLine(Separator);

            rtb.AppendLine(Description);
            rtb.AppendFormatLineIfNotNull("ToolTip: {0}", Tooltip);
            if (DescriptionVariables != null)
            {
                rtb.AppendLine("Description variables:");
                rtb.AppendLine(DescriptionVariables.Variables);
            }

            rtb.AppendFormatLineIfNotNull("Modal Next Spell: {0}", ModalNextSpell);
            if (!string.IsNullOrEmpty(Spell.Description) && !string.IsNullOrEmpty(Spell.AuraDescription) && ModalNextSpell != 0)
                rtb.AppendFormatLine(Separator);

            #region Triggered by ...
            var addline = false;
            if (DBC.DBC.SpellTriggerStore.ContainsKey(ID))
            {
                foreach (var procSpellId in DBC.DBC.SpellTriggerStore[ID])
                {
                    var procname = "Spell Not Found";
                    if (DBC.DBC.SpellInfoStore.ContainsKey(procSpellId))
                        procname = DBC.DBC.SpellInfoStore[procSpellId].Name;
                    rtb.SetStyle(Color.Blue, FontStyle.Bold);

                    rtb.AppendFormatLine("Triggered by spell: ({0}) {1}", procSpellId, procname);
                    rtb.SetDefaultStyle();
                    addline = true;
                }
            }
            if (addline)
                rtb.AppendFormatLine(Separator);
            #endregion

            rtb.AppendFormatLine($"Category = { Category }, SpellIconFileDataID = { SpellIconFileDataID }, ActiveIconFileDataID = { ActiveIconFileDataID }, SpellVisualID = { SpellVisualID }");

            rtb.AppendFormatLine("Family {0} ({1}), flag [0] 0x{2:X8} [1] 0x{3:X8} [2] 0x{4:X8} [3] 0x{5:X8}",
                    (SpellFamilyNames)SpellFamilyName, SpellFamilyName,
                    SpellClassMask[0], SpellClassMask[1], SpellClassMask[2], SpellClassMask[3]);

            #region Modified by ...
            foreach (var eff in
                    from s in DBC.DBC.SpellInfoStore.Values
                    where s.SpellFamilyName == SpellFamilyName
                    from eff in s.Effects
                    where eff != null && ((eff.EffectSpellClassMask[0] & SpellClassMask[0]) != 0 ||
                          (eff.EffectSpellClassMask[1] & SpellClassMask[1]) != 0 ||
                          (eff.EffectSpellClassMask[2] & SpellClassMask[2]) != 0 ||
                          (eff.EffectSpellClassMask[3] & SpellClassMask[3]) != 0)
                    select eff)
            {
                rtb.SetStyle(Color.Blue, FontStyle.Bold);
                rtb.AppendFormatLine("Modified by {0} ({1})",
                    DBC.DBC.SpellInfoStore[eff.SpellID].Name, eff.SpellID);
            }
            #endregion

            rtb.AppendLine();

            rtb.AppendFormatLine("SpellSchoolMask = {0} ({1})", (SpellSchoolMask)SchoolMask, SchoolMask);
            rtb.AppendFormatLine("DamageClass = {0} ({1})", DamageClass, (SpellDmgClass)DamageClass);
            rtb.AppendFormatLine("PreventionType = {0} ({1})", PreventionType, (SpellPreventionType)PreventionType);

            #region Attributes
            if (Misc != null && !Misc.Attributes.All(a => a == 0))
                rtb.AppendLine(Separator);

            if (Attributes != 0)
                rtb.AppendFormatLine("Attributes: 0x{0:X8} ({1})", Attributes, (SpellAtribute)Attributes);
            if (AttributesEx != 0)
                rtb.AppendFormatLine("AttributesEx1: 0x{0:X8} ({1})", AttributesEx, (SpellAtributeEx)AttributesEx);
            if (AttributesEx2 != 0)
                rtb.AppendFormatLine("AttributesEx2: 0x{0:X8} ({1})", AttributesEx2, (SpellAtributeEx2)AttributesEx2);
            if (AttributesEx3 != 0)
                rtb.AppendFormatLine("AttributesEx3: 0x{0:X8} ({1})", AttributesEx3, (SpellAtributeEx3)AttributesEx3);
            if (AttributesEx4 != 0)
                rtb.AppendFormatLine("AttributesEx4: 0x{0:X8} ({1})", AttributesEx4, (SpellAtributeEx4)AttributesEx4);
            if (AttributesEx5 != 0)
                rtb.AppendFormatLine("AttributesEx5: 0x{0:X8} ({1})", AttributesEx5, (SpellAtributeEx5)AttributesEx5);
            if (AttributesEx6 != 0)
                rtb.AppendFormatLine("AttributesEx6: 0x{0:X8} ({1})", AttributesEx6, (SpellAtributeEx6)AttributesEx6);
            if (AttributesEx7 != 0)
                rtb.AppendFormatLine("AttributesEx7: 0x{0:X8} ({1})", AttributesEx7, (SpellAtributeEx7)AttributesEx7);
            if (AttributesEx8 != 0)
                rtb.AppendFormatLine("AttributesEx8: 0x{0:X8} ({1})", AttributesEx8, (SpellAtributeEx8)AttributesEx8);
            if (AttributesEx9 != 0)
                rtb.AppendFormatLine("AttributesEx9: 0x{0:X8} ({1})", AttributesEx9, (SpellAtributeEx9)AttributesEx9);
            if (AttributesEx10 != 0)
                rtb.AppendFormatLine("AttributesEx10: 0x{0:X8} ({1})", AttributesEx10, (SpellAtributeEx10)AttributesEx10);
            if (AttributesEx11 != 0)
                rtb.AppendFormatLine("AttributesEx11: 0x{0:X8} ({1})", AttributesEx11, (SpellAtributeEx11)AttributesEx11);
            if (AttributesEx12 != 0)
                rtb.AppendFormatLine("AttributesEx12: 0x{0:X8} ({1})", AttributesEx12, (SpellAtributeEx12)AttributesEx12);
            if (AttributesEx13 != 0)
                rtb.AppendFormatLine("AttributesEx13: 0x{0:X8} ({1})", AttributesEx13, (SpellAtributeEx13)AttributesEx13);
            if (AttributesEx14 != 0)
                rtb.AppendFormatLine("AttributesEx14: 0x{0:X8} ({1})", AttributesEx14, (SpellAtributeEx14)AttributesEx14);

            rtb.AppendLine(Separator);
            #endregion

            if (TargetRestrictions != null)
            {
                foreach (var targetRestriction in TargetRestrictions)
                {
                    if (targetRestriction.Targets != 0)
                        rtb.AppendFormatLine("Targets Mask = 0x{0:X8} ({1})", targetRestriction.Targets, (SpellCastTargetFlags)targetRestriction.Targets);

                    if (targetRestriction.TargetCreatureType != 0)
                        rtb.AppendFormatLine("Creature Type Mask = 0x{0:X8} ({1})",
                            targetRestriction.TargetCreatureType, (CreatureTypeMask)targetRestriction.TargetCreatureType);

                    rtb.AppendFormatLineIfNotNull("MaxTargets: {0}", targetRestriction.MaxTargets);
                    rtb.AppendFormatLineIfNotNull("ConeDegrees: {0}", targetRestriction.ConeDegrees);
                    rtb.AppendFormatLineIfNotNull("Width (line): {0}", targetRestriction.Width);
                }
            }

            if (Stances != 0)
                rtb.AppendFormatLine("Stances: {0}", (ShapeshiftFormMask)Stances);

            if (StancesNot != 0)
                rtb.AppendFormatLine("Stances Not: {0}", (ShapeshiftFormMask)StancesNot);

            // Skills
            {
                var query = DBC.DBC.SkillLineAbility.Where(skl => skl.Value.Spell == ID).ToArray();
                if (query.Length != 0)
                {
                    var skill = query.First().Value;
                    var line = DBC.DBC.SkillLine[skill.SkillLine];

                    rtb.AppendFormatLine(@"Skill (Id {0}) ""{1}""", skill.SkillLine, line.DisplayName);
                    rtb.AppendFormat("    MinSkillLineRank {0}", skill.MinSkillLineRank);

                    rtb.AppendFormat(", SupercedesSpell = {0}, MinMaxValue ({1}, {2})", skill.SupercedesSpell,
                        skill.TrivialSkillLineRankLow, skill.TrivialSkillLineRankHigh);
                    rtb.AppendFormat(", NumSkillups ({0})", skill.NumSkillUps);
                }
            }

            // SpellReagents
            {
                var printedHeader = false;
                for (var i = 0; Reagents != null && i < Reagents.ReagentCount.Length; ++i)
                {
                    if (Reagents.ReagentCount[i] == 0 || Reagents.Reagent[i] == 0)
                        continue;

                    if (!printedHeader)
                    {
                        rtb.AppendLine();
                        rtb.Append("Reagents:");
                        printedHeader = true;
                    }

                    rtb.AppendFormat("  {0} x{1}", Reagents.Reagent[i], Reagents.ReagentCount[i]);
                }

                if (printedHeader)
                    rtb.AppendLine();
            }

            // SpellReagentsCurrency
            {
                var printedHeader = false;
                foreach (var reagentsCurrency in ReagentsCurrency)
                {
                    if (!printedHeader)
                    {
                        rtb.AppendLine();
                        rtb.Append("ReagentsCurrency:");
                        printedHeader = true;
                    }

                    rtb.AppendFormat("  {0} x{1}", reagentsCurrency.CurrencyTypesID, reagentsCurrency.CurrencyCount);
                }

                if (printedHeader)
                    rtb.AppendLine();
            }

            rtb.AppendFormatLine("Spell Level = {0}, base {1}, max {2}, max passive aura level {3}",
                SpellLevel, BaseLevel, MaxLevel, MaxPassiveAuraLevel);

            if (EquippedItemClass != 0)
            {
                rtb.AppendFormatLine("EquippedItemClass = {0} ({1})", EquippedItemClass, (ItemClass)EquippedItemClass);

                if (EquippedItemSubclass != 0)
                {
                    switch ((ItemClass)EquippedItemClass)
                    {
                        case ItemClass.WEAPON:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubclass, (ItemSubClassWeaponMask)EquippedItemSubclass);
                            break;
                        case ItemClass.ARMOR:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubclass, (ItemSubClassArmorMask)EquippedItemSubclass);
                            break;
                        case ItemClass.MISCELLANEOUS:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubclass, (ItemSubClassMiscMask)EquippedItemSubclass);
                            break;
                    }
                }

                if (EquippedItemInvTypes != 0)
                    rtb.AppendFormatLine("    InventoryType mask = 0x{0:X8} ({1})", EquippedItemInvTypes, (InventoryTypeMask)EquippedItemInvTypes);
            }

            rtb.AppendLine();
            rtb.AppendFormatLine("Category = {0}", Category);
            rtb.AppendFormatLine("DispelType = {0} ({1})", Dispel, (DispelType)Dispel);
            rtb.AppendFormatLine("Mechanic = {0} ({1})", Mechanic, (Mechanics)Mechanic);

            if (Range != null)
            {
                rtb.AppendFormatLine("SpellRange: (Id {0}) \"{1}\":", RangeIndex, Range.DisplayName);
                rtb.AppendFormatLine("    MinRangeNegative = {0}, MinRangePositive = {1}", Range.MinRange[0], Range.MinRange[1]);
                rtb.AppendFormatLine("    MaxRangeNegative = {0}, MaxRangePositive = {1}", Range.MaxRange[0], Range.MaxRange[1]);
            }

            if (Misc != null)
                rtb.AppendFormatLineIfNotNull("Speed {0:F}", Speed);

            rtb.AppendFormatLineIfNotNull("Stackable up to {0}", CumulativeAura);

            if (CastingTimeIndex != 0)
            {
                var castTimeEntry = DBC.DBC.SpellCastTimes[CastingTimeIndex];

                var level = DBC.DBC.SelectedLevel;
                if (Scaling != null && level > Scaling.MaxScalingLevel)
                    level = Scaling.MaxScalingLevel;

                if (((SpellAtributeEx13)AttributesEx13).HasFlag(SpellAtributeEx13.SPELL_ATTR13_UNK17))
                    level *= 5;

                if (Scaling != null && level > Scaling.MaxScalingLevel)
                    level = Scaling.MaxScalingLevel;

                if (Levels != null && Levels.BaseLevel != 0)
                    level -= (ushort)Levels.BaseLevel;

                if (Scaling != null && level < Scaling.MinScalingLevel)
                    level = Scaling.MinScalingLevel;

                var castTime = castTimeEntry.Base;
                if (castTime < castTimeEntry.Minimum)
                    castTime = castTimeEntry.Minimum;

                rtb.AppendFormatLine("Cast Time: (ID {0}): {1}", CastingTimeIndex, castTime);
            }

            if (RecoveryTime != 0 || CategoryRecoveryTime != 0 || StartRecoveryCategory != 0)
            {
                rtb.AppendFormatLine("RecoveryTime: {0} ms, CategoryRecoveryTime: {1} ms", RecoveryTime, CategoryRecoveryTime);
                rtb.AppendFormatLine("StartRecoveryCategory = {0}, StartRecoveryTime = {1:F} ms", StartRecoveryCategory, StartRecoveryTime);
            }

            if (DurationEntry != null)
                rtb.AppendFormatLine("Duration {0}, {1}", Duration, MaxDuration);

            foreach (var spellPower in Powers.OrderBy(p => p.OrderIndex))
            {
                rtb.AppendFormat("Power {0}", (Powers)spellPower.PowerType);
                rtb.AppendFormatIfNotNull(", Base {0}", spellPower.ManaCost);
                rtb.AppendFormatIfNotNull(", {0}%", spellPower.PowerCostPct);
                rtb.AppendFormatIfNotNull(" + lvl * {0}", spellPower.ManaCostPerLevel);
                rtb.AppendFormatIfNotNull(" + {0} Per Second", spellPower.ManaPerSecond);
                rtb.AppendFormatIfNotNull(" + {0}% Per Second", spellPower.PowerPctPerSecond);
                rtb.AppendFormatIfNotNull(" + Optional {0}", spellPower.OptionalCost);
                rtb.AppendLine();
            }

            if (Interrupts != null)
            {
                rtb.AppendFormatLine("Interrupt Flags: 0x{0:X8} ({1})", Interrupts.InterruptFlags, (SpellInterruptFlags)Interrupts.InterruptFlags);
                rtb.AppendFormatLine("AuraInterrupt Flags: 0x{0:X8} ({1}), 0x{2:X8} ({3})", Interrupts.AuraInterruptFlags[0], (SpellAuraInterruptFlags)Interrupts.AuraInterruptFlags[0], Interrupts.AuraInterruptFlags[1], (SpellAuraInterruptFlags)Interrupts.AuraInterruptFlags[1]);
                rtb.AppendFormatLine("ChannelInterrupt Flags: 0x{0:X8} ({1}), 0x{2:X8} ({3})", Interrupts.ChannelInterruptFlags[0], (SpellChannelInterruptFlags)Interrupts.ChannelInterruptFlags[0], Interrupts.ChannelInterruptFlags[1], (SpellChannelInterruptFlags)Interrupts.ChannelInterruptFlags[1]);
            }

            if (CasterAuraState != 0)
                rtb.AppendFormatLine("CasterAuraState = {0} ({1})", CasterAuraState, (AuraState)CasterAuraState);

            if (TargetAuraState != 0)
                rtb.AppendFormatLine("TargetAuraState = {0} ({1})", TargetAuraState, (AuraState)TargetAuraState);

            if (CasterAuraStateNot != 0)
                rtb.AppendFormatLine("CasterAuraStateNot = {0} ({1})", CasterAuraStateNot, (AuraState)CasterAuraStateNot);

            if (TargetAuraStateNot != 0)
                rtb.AppendFormatLine("TargetAuraStateNot = {0} ({1})", TargetAuraStateNot, (AuraState)TargetAuraStateNot);

            if (CasterAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(CasterAuraSpell))
                    rtb.AppendFormatLine("  Caster Aura Spell ({0}) {1}", CasterAuraSpell, DBC.DBC.SpellInfoStore[CasterAuraSpell].Name);
                else
                    rtb.AppendFormatLine("  Caster Aura Spell ({0}) ?????", CasterAuraSpell);
            }

            if (TargetAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(TargetAuraSpell))
                    rtb.AppendFormatLine("  Target Aura Spell ({0}) {1}", TargetAuraSpell, DBC.DBC.SpellInfoStore[TargetAuraSpell].Name);
                else
                    rtb.AppendFormatLine("  Target Aura Spell ({0}) ?????", TargetAuraSpell);
            }

            if (ExcludeCasterAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(ExcludeCasterAuraSpell))
                    rtb.AppendFormatLine("  Ex Caster Aura Spell ({0}) {1}", ExcludeCasterAuraSpell, DBC.DBC.SpellInfoStore[ExcludeCasterAuraSpell].Name);
                else
                    rtb.AppendFormatLine("  Ex Caster Aura Spell ({0}) ?????", ExcludeCasterAuraSpell);
            }

            if (ExcludeTargetAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(ExcludeTargetAuraSpell))
                    rtb.AppendFormatLine("  Ex Target Aura Spell ({0}) {1}", ExcludeTargetAuraSpell, DBC.DBC.SpellInfoStore[ExcludeTargetAuraSpell].Name);
                else
                    rtb.AppendFormatLine("  Ex Target Aura Spell ({0}) ?????", ExcludeTargetAuraSpell);
            }

            if (RequiredAreasId > 0)
            {
                var areas = DBC.DBC.AreaGroupMember.Values.Where(ag => ag.AreaGroupID == RequiredAreasId).ToList();
                if (areas.Count == 0)
                    rtb.AppendFormatLine("Cannot find area group id {0} in AreaGroupMember.db2!", RequiredAreasId);
                else
                {
                    rtb.AppendLine();
                    rtb.SetBold();
                    rtb.AppendLine("Allowed areas:");
                    foreach (var areaGroupMember in areas)
                    {
                        var areaId = areaGroupMember.AreaID;
                        if (!DBC.DBC.AreaTable.ContainsKey(areaId))
                            continue;

                        var areaEntry = DBC.DBC.AreaTable[areaId];
                        rtb.AppendFormatLine("{0} - {1} (Map: {2})", areaId, areaEntry.AreaName, areaEntry.ContinentID);
                    }

                    rtb.AppendLine();
                }
            }

            rtb.AppendFormatLineIfNotNull("Requires Spell Focus {0}", RequiresSpellFocus);

            if (Math.Abs(BaseProcRate) > 1.0E-5f)
            {
                rtb.SetBold();
                rtb.AppendFormatLine("PPM flag 0x{0:X2} BaseRate {1}", ProcsPerMinuteFlags, BaseProcRate);
                rtb.SetDefaultStyle();
            }

            if (ProcFlags != 0)
            {
                rtb.SetBold();
                rtb.AppendFormatLine("Proc flag 0x{0:X8}, chance: {1}%, charges: {2}, cooldown: {3}",
                    ProcFlags, ProcChance, ProcCharges, ProcCooldown);
                rtb.SetDefaultStyle();
                rtb.AppendFormatLine(Separator);
                rtb.AppendText(ProcInfo);
            }
            else
                rtb.AppendFormatLine("Chance = {0}, charges - {1}", ProcChance, ProcCharges);

            rtb.AppendLine(Separator);
            foreach (var effect in Effects)
                AppendEffectInfo(rtb, effect);

            AppendItemInfo(rtb);

            AppendSpellVisualInfo();
        }

        private float CalculateBaseEffectValue(SpellEffectEntry effect)
        {
            if (effect.Coefficient != 0.0f)
            {
                if (Scaling == null)
                    return 0.0f;

                var level = DBC.DBC.SelectedLevel - 1;

                if (BaseLevel != 0
                    && (AttributesEx11 & (uint)SpellAtributeEx11.SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL) == 0
                    && (AttributesEx10 & (uint)SpellAtributeEx10.SPELL_ATTR10_USE_SPELL_BASE_LEVEL_FOR_SCALING) != 0)
                    level = (uint)BaseLevel;

                if (Scaling.MinScalingLevel != 0 && Scaling.MinScalingLevel > level)
                    level = Scaling.MinScalingLevel;

                if (Scaling.MaxScalingLevel != 0 && Scaling.MaxScalingLevel < level)
                    level = Scaling.MaxScalingLevel;

                float value = 0.0f;
                if (level > 0)
                {
                    if (Scaling.Class == 0)
                        return 0.0f;

                    if (Scaling.ScalesFromItemLevel != 0 || (AttributesEx11 & (uint)SpellAtributeEx11.SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL) != 0)
                    {
                        var effectiveItemLevel = (int)DBC.DBC.SelectedItemLevel;
                        if (Scaling.ScalesFromItemLevel != 0)
                            effectiveItemLevel = (ushort)Scaling.ScalesFromItemLevel;

                        RandPropPointsEntry randPropPoints;
                        if (!DBC.DBC.RandPropPoints.TryGetValue(effectiveItemLevel, out randPropPoints))
                            randPropPoints = DBC.DBC.RandPropPoints.Last().Value;

                        if (Scaling.Class == -8 || Scaling.Class == -9)
                            value = Scaling.Class == -8 ? randPropPoints.DamageReplaceStat : randPropPoints.DamageSecondary;
                        else
                            value = randPropPoints.Superior[0];
                    }
                    else
                    {
                        var gtScaling = GameTable<GtSpellScalingEntry>.GetRecord((int)level);
                        Debug.Assert(gtScaling != null);
                        value = gtScaling.GetColumnForClass(Scaling.Class);
                    }
                }

                value *= effect.Coefficient;
                if (value != 0.0f && value < 1.0f)
                    value = 1.0f;

                return (float)Math.Round(value);
            }
            else
            {
                float value = effect.EffectBasePoints;
                ExpectedStatType stat = ExpectedStat.GetTypeForSpellEffect(effect);
                if (stat != ExpectedStatType.None)
                {
                    if ((Attributes & (uint)SpellAtribute.SPELL_ATTR0_LEVEL_DAMAGE_CALCULATION) != 0)
                        stat = ExpectedStatType.CreatureAutoAttackDps;

                    var contentTuningId = Misc.ContentTuningID;
                    if (DBC.DBC.SelectedMapDifficulty != null)
                        contentTuningId = DBC.DBC.SelectedMapDifficulty.ContentTuningID;

                    var expansion = -2;
                    if (DBC.DBC.ContentTuning.TryGetValue(contentTuningId, out var contentTuning))
                        expansion = contentTuning.ExpansionID;

                    value = ExpectedStat.Evaluate(stat, DBC.DBC.SelectedLevel, expansion, contentTuningId, 0, Classes.CLASS_NONE) * value / 100.0f;
                }

                return (float)Math.Round(value);
            }
        }

        private void AppendEffectInfo(RichTextBox rtb, SpellEffectEntry effect)
        {
            rtb.SetBold();
            rtb.AppendFormatLine($"Effect { effect.EffectIndex }: Id { effect.Effect } ({ (SpellEffects)effect.Effect })");
            rtb.SetBold();
            rtb.AppendFormatLine($"Difficulty: Id { effect.DifficultyID } ({ (Difficulty)effect.DifficultyID })");
            rtb.SetDefaultStyle();

            var baseValue = CalculateBaseEffectValue(effect);
            if (Math.Abs(effect.Variance) > 1.0E-5f)
            {
                var delta = Math.Abs(baseValue * effect.Variance * 0.5f);
                rtb.AppendFormat("BasePoints = {0:F} to {1:F}", baseValue - delta, baseValue + delta);
            }
            else
                rtb.AppendFormat("BasePoints = {0:F}", baseValue);

            var valuePerResource = 0.0f;
            var usesExpectedStat = false;
            if (Math.Abs(effect.Coefficient) > 1.0E-5f)
            {
                if (Math.Abs(effect.ResourceCoefficient) > 1.0E-5f)
                    valuePerResource = baseValue * effect.ResourceCoefficient;

            }
            else if (ExpectedStat.GetTypeForSpellEffect(effect) == ExpectedStatType.None)
            {
                valuePerResource = effect.EffectPointsPerResource;
                if (Math.Abs(effect.EffectRealPointsPerLevel) > 1.0E-5f)
                    rtb.AppendFormat(" + Level * {0:F}", effect.EffectRealPointsPerLevel);
            }
            else
                usesExpectedStat = true;

            rtb.AppendFormatIfNotNull(" + resource * {0:F}", valuePerResource);

            if (effect.EffectBonusCoefficient > 1.0E-5f)
                rtb.AppendFormat(" + spellPower * {0}", effect.EffectBonusCoefficient);

            if (effect.BonusCoefficientFromAP > 1.0E-5)
                rtb.AppendFormat(" + AP * {0}", effect.BonusCoefficientFromAP);

            // if (Math.Abs(effect.DamageMultiplier - 1.0f) > 1.0E-5f)
            //     rtb.AppendFormat(" x {0:F}", effect.DamageMultiplier);

            // rtb.AppendFormatIfNotNull("  Multiple = {0:F}", effect.ValueMultiplier);

            if (usesExpectedStat && DBC.DBC.SelectedMapDifficulty != null)
            {
                rtb.SelectionColor = Color.MediumPurple;
                rtb.AppendFormat(" ({2} - {0}: {1})", DBC.DBC.Map[(int)DBC.DBC.SelectedMapDifficulty.MapID].MapName,
                    DBC.DBC.Difficulty[DBC.DBC.SelectedMapDifficulty.DifficultyID].Name,
                    DBC.DBC.SelectedMapDifficulty.MapID);
            }

            rtb.AppendLine();

            rtb.AppendFormatLine("Targets ({0}, {1}) ({2}, {3})",
                effect.ImplicitTarget[0], effect.ImplicitTarget[1],
                (Targets)effect.ImplicitTarget[0], (Targets)effect.ImplicitTarget[1]);

            AuraModTypeName(rtb, effect);

            var classMask = Array.ConvertAll(effect.EffectSpellClassMask, i => (uint)i);

            if (classMask[0] != 0 || classMask[1] != 0 || classMask[2] != 0 || classMask[3] != 0)
            {
                rtb.AppendFormatLine("SpellClassMask = {0:X8} {1:X8} {2:X8} {3:X8}", classMask[0], classMask[1], classMask[2], classMask[3]);

                var query = from spell in DBC.DBC.SpellInfoStore.Values
                            where spell.SpellFamilyName == SpellFamilyName && spell.SpellClassMask.ContainsElement(classMask)
                            join sk in DBC.DBC.SkillLineAbility.Values on spell.ID equals sk.Spell into temp
                            from skill in temp.DefaultIfEmpty(new SkillLineAbilityEntry())
                            select new
                            {
                                SpellID = spell.ID,
                                SpellName = spell.Name,
                                SkillId = skill.SkillLine
                            };

                foreach (var row in query)
                {
                    if (row.SkillId > 0)
                    {
                        rtb.SelectionColor = Color.Blue;
                        rtb.AppendFormatLine("\t+ {0} - {1}", row.SpellID, row.SpellName);
                    }
                    else
                    {
                        rtb.SelectionColor = Color.Red;
                        rtb.AppendFormatLine("\t- {0} - {1}", row.SpellID, row.SpellName);
                    }
                    rtb.SelectionColor = Color.Black;
                }
            }

            AppendRadius(rtb, "", effect.EffectRadiusIndex[0]);
            AppendRadius(rtb, "Max ", effect.EffectRadiusIndex[1]);

            // append trigger spell
            var trigger = effect.EffectTriggerSpell;
            if (trigger != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey((int)trigger))
                {
                    var triggerSpell = DBC.DBC.SpellInfoStore[(int)trigger];
                    rtb.SetStyle(Color.Blue, FontStyle.Bold);
                    rtb.AppendFormatLine("   Trigger spell ({0}) {1}. Chance = {2}", trigger, triggerSpell.SpellName.Name, ProcChance);
                    rtb.AppendFormatLineIfNotNull("   Description: {0}", triggerSpell.Spell.Description);
                    rtb.AppendFormatLineIfNotNull("   ToolTip: {0}", triggerSpell.Spell.AuraDescription);
                    rtb.SetDefaultStyle();
                    if (triggerSpell.ProcFlags != 0 || triggerSpell.ProcFlagsEx != 0)
                    {
                        rtb.AppendFormatLine("Charges - {0}", triggerSpell.ProcCharges);
                        rtb.AppendLine(Separator);
                        rtb.AppendLine(triggerSpell.ProcInfo);
                        rtb.AppendLine(Separator);
                    }
                }
                else
                    rtb.AppendFormatLine("Trigger spell ({0}) Not found, Chance = {1}", trigger, ProcChance);
            }

            rtb.AppendFormatLineIfNotNull("EffectChainTargets = {0}", effect.EffectChainTargets);
            rtb.AppendFormatLineIfNotNull("EffectItemType = {0}", effect.EffectItemType);

            if ((Mechanics)effect.EffectMechanic != Mechanics.MECHANIC_NONE)
                rtb.AppendFormatLine("Effect Mechanic = {0} ({1})", effect.EffectMechanic, (Mechanics)effect.EffectMechanic);

            rtb.AppendFormatLineIfNotNull("Attributes {0:X8} ({0})", effect.EffectAttributes);
            rtb.AppendLine();
        }

        private static void AppendRadius(RichTextBox rtb, string name, uint radiusIndex)
        {
            if (!DBC.DBC.SpellRadius.ContainsKey((int)radiusIndex))
                return;

            rtb.AppendLine($"{name}Radius (Id {radiusIndex}) {DBC.DBC.SpellRadius[(int)radiusIndex].Radius:F}" +
                $" (Min: {DBC.DBC.SpellRadius[(int)radiusIndex].RadiusMin:F} Max: {DBC.DBC.SpellRadius[(int)radiusIndex].MaxRadius:F})");
        }

        private static void AuraModTypeName(RichTextBox rtb, SpellEffectEntry effect)
        {
            var aura = (AuraType)effect.EffectAura;
            var misc = effect.EffectMiscValue[0];

            if (effect.EffectAura == 0)
            {
                rtb.AppendFormatLineIfNotNull("EffectMiscValueA = {0}", effect.EffectMiscValue[0]);
                rtb.AppendFormatLineIfNotNull("EffectMiscValueB = {0}", effect.EffectMiscValue[1]);
                rtb.AppendFormatLineIfNotNull("EffectAmplitude = {0}", effect.EffectAmplitude);

                return;
            }

            rtb.AppendFormat("Aura Id {0:D} ({0})", aura);
            rtb.AppendFormat(", value = {0}", effect.EffectBasePoints);
            rtb.AppendFormat(", misc = {0} (", misc);

            switch (aura)
            {
                case AuraType.SPELL_AURA_MOD_STAT:
                    rtb.Append((UnitMods)misc);
                    break;
                case AuraType.SPELL_AURA_MOD_RATING:
                case AuraType.SPELL_AURA_MOD_RATING_PCT:
                    rtb.Append((CombatRating)misc);
                    break;
                case AuraType.SPELL_AURA_ADD_FLAT_MODIFIER:
                case AuraType.SPELL_AURA_ADD_PCT_MODIFIER:
                    rtb.Append((SpellModOp)misc);
                    break;
                // TODO: more case
                default:
                    rtb.Append(misc);
                    break;
            }

            rtb.AppendFormat("), miscB = {0}", effect.EffectMiscValue[1]);
            rtb.AppendFormatLine(", amplitude = {0}, periodic = {1}", effect.EffectAmplitude, effect.EffectAuraPeriod);

            switch (aura)
            {
                case AuraType.SPELL_AURA_OVERRIDE_SPELLS:
                    if (!DBC.DBC.OverrideSpellData.ContainsKey(misc))
                    {
                        rtb.SetStyle(Color.Red, FontStyle.Bold);
                        rtb.AppendFormatLine("Cannot find key {0} in OverrideSpellData.dbc", (uint)misc);
                    }
                    else
                    {
                        rtb.AppendLine();
                        rtb.SetStyle(Color.DarkRed, FontStyle.Bold);
                        var @override = DBC.DBC.OverrideSpellData[misc];
                        for (var i = 0; i < 10; ++i)
                        {
                            if (@override.Spells[i] == 0)
                                continue;

                            rtb.SetStyle(Color.DarkBlue, FontStyle.Regular);
                            rtb.AppendFormatLine("\t - #{0} ({1}) {2}", i + 1, @override.Spells[i],
                                DBC.DBC.SpellInfoStore.ContainsKey((int)@override.Spells[i]) ? DBC.DBC.SpellInfoStore[(int)@override.Spells[i]].Name : "?????");
                        }
                        rtb.AppendLine();
                    }
                    break;
                case AuraType.SPELL_AURA_SCREEN_EFFECT:
                    rtb.SetStyle(Color.DarkBlue, FontStyle.Bold);
                    rtb.AppendFormatLine("ScreenEffect: {0}",
                        DBC.DBC.ScreenEffect.ContainsKey(misc) ? DBC.DBC.ScreenEffect[misc].Name : "?????");
                    break;
            }
        }

        private void AppendItemInfo(RichTextBox rtb)
        {
            var items = DBC.DBC.ItemEffect.Where(effect => effect.Value.SpellID == ID).ToArray();
            if (!items.Any())
                return;

            rtb.AppendLine(Separator);
            rtb.SetStyle(Color.Blue, FontStyle.Bold);
            rtb.AppendLine("Items using this spell:");
            rtb.SetDefaultStyle();

            foreach (var item in items)
            {
                if (!DBC.DBC.ItemSparse.ContainsKey(item.Value.ParentItemID))
                {
                    rtb.AppendFormatLine($@"   Non-existing Item-sparse.db2 entry { item.Value.ParentItemID }");
                    continue;
                }

                var itemTemplate = DBC.DBC.ItemSparse[item.Value.ParentItemID];

                var name = itemTemplate.Display;
                var description = itemTemplate.Description;

                description = string.IsNullOrEmpty(description) ? string.Empty : $" - \"{ description }\"";

                rtb.AppendFormatLine($@"   { item.Value.ParentItemID }: { name } { description }");
            }
        }

        private void AppendSpellVisualInfo()
        {
            /*SpellVisualEntry visualData;
            if (!DBC.DBC.SpellVisual.TryGetValue(_spell.SpellVisual[0], out visualData))
                return;

            SpellMissileEntry missileEntry;
            SpellMissileMotionEntry missileMotionEntry;
            var hasMissileEntry = DBC.DBC.SpellMissile.TryGetValue(visualData.MissileModel, out missileEntry);
            var hasMissileMotion = DBC.DBC.SpellMissileMotion.TryGetValue(visualData.MissileMotionId, out missileMotionEntry);

            if (!hasMissileEntry && !hasMissileMotion)
                return;

            _rtb.AppendLine(_line);
            _rtb.SetBold();
            _rtb.AppendLine("Missile data");
            _rtb.SetDefaultStyle();

            // Missile Model Data.
            if (hasMissileEntry)
            {
                _rtb.AppendFormatLine("Missile Model ID: {0}", visualData.MissileModel);
                _rtb.AppendFormatLine("Missile attachment: {0}", visualData.MissileAttachment);
                _rtb.AppendFormatLine("Missile cast offset: X:{0} Y:{1} Z:{2}", visualData.MissileCastOffsetX, visualData.MissileCastOffsetY, visualData.MissileCastOffsetZ);
                _rtb.AppendFormatLine("Missile impact offset: X:{0} Y:{1} Z:{2}", visualData.MissileImpactOffsetX, visualData.MissileImpactOffsetY, visualData.MissileImpactOffsetZ);
                _rtb.AppendFormatLine("MissileEntry ID: {0}", missileEntry.Id);
                _rtb.AppendFormatLine("Collision Radius: {0}", missileEntry.CollisionRadius);
                _rtb.AppendFormatLine("Default Pitch: {0} - {1}", missileEntry.DefaultPitchMin, missileEntry.DefaultPitchMax);
                _rtb.AppendFormatLine("Random Pitch: {0} - {1}", missileEntry.RandomizePitchMax, missileEntry.RandomizePitchMax);
                _rtb.AppendFormatLine("Default Speed: {0} - {1}", missileEntry.DefaultSpeedMin, missileEntry.DefaultSpeedMax);
                _rtb.AppendFormatLine("Randomize Speed: {0} - {1}", missileEntry.RandomizeSpeedMin, missileEntry.RandomizeSpeedMax);
                _rtb.AppendFormatLine("Gravity: {0}", missileEntry.Gravity);
                _rtb.AppendFormatLine("Maximum duration:", missileEntry.MaxDuration);
                _rtb.AppendLine("");
            }

            // Missile Motion Data.
            if (hasMissileMotion)
            {
                _rtb.AppendFormatLine("Missile motion: {0}", missileMotionEntry.Name);
                _rtb.AppendFormatLine("Missile count: {0}", missileMotionEntry.MissileCount);
                _rtb.AppendLine("Missile Script body:");
                _rtb.AppendText(missileMotionEntry.Script);
            }*/
        }

        public bool HasEffect(SpellEffects effect)
        {
            return Effects.Any(eff => eff != null && eff.Effect == (uint)effect);
        }

        public bool HasAura(AuraType aura)
        {
            return Effects.Any(eff => eff != null && eff.EffectAura == (uint)aura);
        }

        public bool HasTargetA(Targets target)
        {
            return Effects.Any(eff => eff != null && eff.ImplicitTarget[0] == (uint)target);
        }

        public bool HasTargetB(Targets target)
        {
            return Effects.Any(eff => eff != null && eff.ImplicitTarget[1] == (uint)target);
        }
    }

    public class SpellEffectInfo
    {
        public SpellEffectEntry SpellEffect { get; set; }

        public uint ID => SpellEffect.ID;

        public int SpellID => SpellEffect.SpellID;

        public int DifficultyID => SpellEffect.DifficultyID;

        public int Effect => SpellEffect.Effect;
        public int EffectIndex => SpellEffect.EffectIndex;
        public int EffectAttributes => SpellEffect.EffectAttributes;

        public short EffectAura => SpellEffect.EffectAura;
        public int EffectAuraPeriod => SpellEffect.EffectAuraPeriod;

        public float EffectBasePoints => SpellEffect.EffectBasePoints;

        public int EffectMiscValueA => SpellEffect.EffectMiscValue[0];
        public int EffectMiscValueB => SpellEffect.EffectMiscValue[1];

        public int EffectSpellClassMaskA => SpellEffect.EffectSpellClassMask[0];
        public int EffectSpellClassMaskB => SpellEffect.EffectSpellClassMask[1];
        public int EffectSpellClassMaskC => SpellEffect.EffectSpellClassMask[2];
        public int EffectSpellClassMaskD => SpellEffect.EffectSpellClassMask[3];

        public int EffectTriggerSpell => SpellEffect.EffectTriggerSpell;

        public short TargetA => SpellEffect.ImplicitTarget[0];
        public short TargetB => SpellEffect.ImplicitTarget[1];

        public uint EffectRadiusIndex => SpellEffect.EffectRadiusIndex[0];
        public uint EffectRadiusMaxIndex => SpellEffect.EffectRadiusIndex[1];

        public int EffectChainTargets => SpellEffect.EffectChainTargets;
        public int EffectItemType => SpellEffect.EffectItemType;
        public int EffectMechanic => SpellEffect.EffectMechanic;

        public float EffectAmplitude => SpellEffect.EffectAmplitude;
        public float EffectBonusCoefficient => SpellEffect.EffectBonusCoefficient;
        public float EffectChainAmplitude => SpellEffect.EffectChainAmplitude;
        public float EffectPointsPerResource => SpellEffect.EffectPointsPerResource;
        public float EffectRealPointsPerLevel => SpellEffect.EffectRealPointsPerLevel;

        public float EffectPosFacing => SpellEffect.EffectPosFacing;
        public float BonusCoefficientFromAP => SpellEffect.BonusCoefficientFromAP;

        public SpellEffectInfo(SpellEffectEntry spellEffectEntry)
        {
            SpellEffect = spellEffectEntry;
        }
    }
}
