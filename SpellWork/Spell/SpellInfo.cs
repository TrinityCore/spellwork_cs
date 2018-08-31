using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpellWork.Database;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using SpellWork.GameTables;
using SpellWork.GameTables.Structures;
using System.Collections.Concurrent;

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
        public SpellVisualEntry SpellVisual { get; set; }
        public SpellMissileEntry SpellMissile { get; set; }
        // Helper
        public readonly IDictionary<int, SpellEffectInfo> SpellEffectInfoStore = new ConcurrentDictionary<int, SpellEffectInfo>();

        #region SpellDuration
        public int Duration => DurationEntry?.Duration ?? 0;
        public uint DurationPerLevel => DurationEntry?.DurationPerLevel ?? 0;
        public int MaxDuration => DurationEntry?.MaxDuration ?? 0;
        #endregion

        #region Spell
        public int ID => SpellName.SpellID;
        public string Name => SpellName.Name;
        public string Description => Spell?.Description ?? string.Empty;
        public string Tooltip => Spell?.AuraDescription ?? string.Empty;
        public int MiscID => Misc?.ID ?? 0;
        #endregion

        #region SpellMisc
        // SpellMisc
        public int Attributes => Misc?.Attributes[0] ?? 0;
        public int AttributesEx => Misc?.Attributes[1] ?? 0;
        public int AttributesEx2 => Misc?.Attributes[2] ?? 0;
        public int AttributesEx3 => Misc?.Attributes[3] ?? 0;
        public int AttributesEx4 => Misc?.Attributes[4] ?? 0;
        public int AttributesEx5 => Misc?.Attributes[5] ?? 0;
        public int AttributesEx6 => Misc?.Attributes[6] ?? 0;
        public int AttributesEx7 => Misc?.Attributes[7] ?? 0;
        public int AttributesEx8 => Misc?.Attributes[8] ?? 0;
        public int AttributesEx9 => Misc?.Attributes[9] ?? 0;
        public int AttributesEx10 => Misc?.Attributes[10] ?? 0;
        public int AttributesEx11 => Misc?.Attributes[11] ?? 0;
        public int AttributesEx12 => Misc?.Attributes[12] ?? 0;
        public int AttributesEx13 => Misc?.Attributes[13] ?? 0;
        public float Speed => Misc?.Speed ?? 0;
        public int CastingTimeIndex => Misc?.CastingTimeIndex ?? 0;
        public int ActiveIconFileDataID => Misc?.ActiveIconFileDataID ?? 0;
        public int IconFileDataID => Misc?.SpellIconFileDataID ?? 0;
        public int RangeIndex => Misc?.RangeIndex ?? 0;
        public uint SchoolMask => (uint)(Misc?.SchoolMask ?? 0);
        #endregion

        #region SpellClassOptions
        // SpellClassOptions
        public uint ModalNextSpell => ClassOptions?.ModalNextSpell ?? 0;
        public uint SpellFamilyName => ClassOptions?.SpellClassSet ?? 0;
        public uint[] SpellFamilyFlags => ClassOptions?.SpellFamilyFlags ?? new uint[4];
        #endregion

        #region SpellCategories
        // SpellCategories
        public int DamageClass => Categories?.DefenseType ?? 0;
        public int PreventionType => Categories?.PreventionType ?? 0;
        public uint Category => Categories?.Category ?? 0;
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
        public int CasterAuraSpell => (int)(AuraRestrictions?.CasterAuraSpell ?? 0);
        public int TargetAuraSpell => (int)(AuraRestrictions?.TargetAuraSpell ?? 0);
        public int ExcludeCasterAuraSpell => (int)(AuraRestrictions?.ExcludeCasterAuraSpell ?? 0);
        public int ExcludeTargetAuraSpell => (int)(AuraRestrictions?.ExcludeTargetAuraSpell ?? 0);
        #endregion

        #region SpellAuraOptions
        public int ProcCharges => AuraOptions?.ProcCharges ?? 0;
        public int ProcChance => AuraOptions?.ProcChance ?? 0;
        public uint ProcFlags0 => AuraOptions?.ProcTypeMask[0] ?? 0;
        public uint ProcFlags1 => AuraOptions?.ProcTypeMask[1] ?? 0;
        public int CumulativeAura => AuraOptions?.CumulativeAura ?? 0;
        public int ProcCooldown => AuraOptions?.ProcCategoryRecovery ?? 0;
        #endregion

        #region SpellLevels
        // SpellLevels
        public int BaseLevel => Levels?.BaseLevel ?? 0;
        public int MaxLevel => Levels?.MaxLevel ?? 0;
        public int SpellLevel => Levels?.SpellLevel ?? 0;
        public int MaxUsableLevel => Levels?.MaxPassiveAuraLevel ?? 0;
        #endregion

        #region EquippedItems
        // Equippeditems
        public int EquippedItemClass => EquippedItems?.EquippedItemClass ?? 0;
        public int EquippedItemInventoryTypeMask => EquippedItems?.EquippedItemInvTypes ?? 0;
        public int EquippedItemSubClassMask => EquippedItems?.EquippedItemSubclass ?? 0;
        #endregion

        #region SpellXSpellVisual
        public int SpellVisualID => SpellXSpellVisual?.SpellVisualID ?? 0;
        #endregion

        #region SpellVisual
        public ushort SpellVisualMissileSetID => SpellVisual?.SpellVisualMissileSetID ?? 0;
        public sbyte MissileAttachment => SpellVisual?.MissileAttachment ?? 0;
        public float MissileCastOffsetX => SpellVisual?.MissileCastOffset[0] ?? 0;
        public float MissileCastOffsetY => SpellVisual?.MissileCastOffset[1] ?? 0;
        public float MissileCastOffsetZ => SpellVisual?.MissileCastOffset[2] ?? 0;
        public float MissileImpactOffsetX => SpellVisual?.MissileImpactOffset[0] ?? 0;
        public float MissileImpactOffsetY => SpellVisual?.MissileImpactOffset[1] ?? 0;
        public float MissileImpactOffsetZ => SpellVisual?.MissileImpactOffset[2] ?? 0;
        #endregion

        #region SpellMissile
        public int MissileID => SpellMissile?.ID ?? 0;
        public float DefaultPitchMin => SpellMissile?.DefaultPitchMin ?? 0;
        public float DefaultPitchMax => SpellMissile?.DefaultPitchMax ?? 0;
        public float DefaultSpeedMin => SpellMissile?.DefaultSpeedMin ?? 0;
        public float DefaultSpeedMax => SpellMissile?.DefaultSpeedMax ?? 0;
        public float RandomizeFacingMin => SpellMissile?.RandomizeFacingMin ?? 0;
        public float RandomizeFacingMax => SpellMissile?.RandomizeFacingMax ?? 0;
        public float RandomizePitchMin => SpellMissile?.RandomizePitchMin ?? 0;
        public float RandomizePitchMax => SpellMissile?.RandomizePitchMax ?? 0;
        public float RandomizeSpeedMin => SpellMissile?.RandomizeSpeedMin ?? 0;
        public float RandomizeSpeedMax => SpellMissile?.RandomizeSpeedMax ?? 0;
        public float Gravity => SpellMissile?.Gravity ?? 0;
        public float MaximumDuration => SpellMissile?.MaxDuration ?? 0;
        public float CollisionRadius => SpellMissile?.CollisionRadius ?? 0;
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

        public string ProcInfo0
        {
            get
            {
                var i = 0;
                var sb = new StringBuilder();
                var proc0 = ProcFlags0;

                while (proc0 != 0)
                {
                    if ((proc0 & 1) != 0)
                        sb.AppendFormatLine("  {0}", SpellEnums.ProcFlagDesc[i]);
                    ++i;
                    proc0 >>= 1;
                }

                return sb.ToString();
            }
        }

        public string ProcInfo1
        {
            get
            {
                var i = 0;
                var sb = new StringBuilder();
                var proc1 = ProcFlags1;

                while (proc1 != 0)
                {
                    if ((proc1 & 1) != 0)
                        sb.AppendFormatLine("  {0}", SpellEnums.ProcFlagDesc2[i]);
                    ++i;
                    proc1 >>= 1;
                }

                return sb.ToString();
            }
        }

        private const string Separator = "=================================================";

        public SpellInfo(SpellNameEntry spellNameEntry)
        {
            SpellDescriptionVariablesEntry variables;
            SpellName = spellNameEntry;
            foreach (var spellXDescriptionVariables in DBC.DBC.SpellXDescriptionVariables)
            {
                if (spellXDescriptionVariables.Value.SpellID == spellNameEntry.SpellID)
                    if (DBC.DBC.SpellDescriptionVariables.TryGetValue(spellXDescriptionVariables.Value.SpellDescriptionVariablesID, out variables))
                        DescriptionVariables = variables;
            }
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
            if (ModalNextSpell != 0)
                rtb.AppendFormatLine(Separator);

            #region Triggered by ...
            var addline = false;
            if (DBC.DBC.SpellTriggerStore.ContainsKey(SpellName.SpellID))
            {
                foreach (var procSpellId in DBC.DBC.SpellTriggerStore[SpellName.SpellID])
                {
                    var procname = "Spell Not Found";
                    if (DBC.DBC.SpellInfoStore.ContainsKey(procSpellId))
                        procname = DBC.DBC.SpellName[procSpellId].Name;
                    rtb.SetStyle(Color.Blue, FontStyle.Bold);

                    rtb.AppendFormatLine("Triggered by spell: ({0}) {1}", procSpellId, procname);
                    rtb.SetDefaultStyle();
                    addline = true;
                }
            }
            if (addline)
                rtb.AppendFormatLine(Separator);
            #endregion

            rtb.AppendFormatLine($"Category = { Category }, IconFileDataID = { IconFileDataID }, ActiveIconFileDataID = { ActiveIconFileDataID }, SpellVisualID = { SpellVisualID }");

            rtb.AppendFormatLine("Family {0} ({1}), flag [0] 0x{2:X8} [1] 0x{3:X8} [2] 0x{4:X8} [3] 0x{5:X8}",
                    (SpellFamilyNames)SpellFamilyName, SpellFamilyName,
                    SpellFamilyFlags[0], SpellFamilyFlags[1], SpellFamilyFlags[2], SpellFamilyFlags[3]);

            #region Modified by ...
            foreach (var eff in
                    from s in DBC.DBC.SpellInfoStore.Values
                    where s.SpellFamilyName == SpellFamilyName
                    from eff in s.Effects
                    where eff != null && ((eff.EffectSpellClassMask[0] & SpellFamilyFlags[0]) != 0 ||
                          (eff.EffectSpellClassMask[1] & SpellFamilyFlags[1]) != 0 ||
                          (eff.EffectSpellClassMask[2] & SpellFamilyFlags[2]) != 0 ||
                          (eff.EffectSpellClassMask[3] & SpellFamilyFlags[3]) != 0)
                    select eff)
            {
                rtb.SetStyle(Color.Blue, FontStyle.Bold);
                rtb.AppendFormatLine("Modified by {0} ({1})",
                    DBC.DBC.SpellInfoStore[eff.SpellID].SpellName.Name, eff.SpellID);
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

                    if (targetRestriction.MaxTargets != 0)
                        rtb.AppendFormatLine("MaxAffectedTargets: {0}", targetRestriction.MaxTargets);
                }
            }

            if (Stances != 0)
                rtb.AppendFormatLine("Stances: {0}", (ShapeshiftFormMask)Stances);

            if (StancesNot != 0)
                rtb.AppendFormatLine("Stances Not: {0}", (ShapeshiftFormMask)StancesNot);

            // Skills
            {
                var query = DBC.DBC.SkillLineAbility.Where(skl => skl.Value.Spell == SpellName.SpellID).ToArray();
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

                    rtb.AppendFormat("  {0} x{1}", reagentsCurrency.CurrencyTypeID, reagentsCurrency.CurrencyCount);
                }

                if (printedHeader)
                    rtb.AppendLine();
            }

            rtb.AppendFormatLine("Spell Level = {0}, base {1}, max {2}, max usable {3}",
                SpellLevel, BaseLevel, MaxLevel, MaxUsableLevel);

            if (EquippedItemClass != 0)
            {
                rtb.AppendFormatLine("EquippedItemClass = {0} ({1})", EquippedItemClass, (ItemClass)EquippedItemClass);

                if (EquippedItemSubClassMask != 0)
                {
                    switch ((ItemClass)EquippedItemClass)
                    {
                        case ItemClass.WEAPON:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubClassMask, (ItemSubClassWeaponMask)EquippedItemSubClassMask);
                            break;
                        case ItemClass.ARMOR:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubClassMask, (ItemSubClassArmorMask)EquippedItemSubClassMask);
                            break;
                        case ItemClass.MISC:
                            rtb.AppendFormatLine("    SubClass mask 0x{0:X8} ({1})", EquippedItemSubClassMask, (ItemSubClassMiscMask)EquippedItemSubClassMask);
                            break;
                    }
                }

                if (EquippedItemInventoryTypeMask != 0)
                    rtb.AppendFormatLine("    InventoryType mask = 0x{0:X8} ({1})", EquippedItemInventoryTypeMask, (InventoryTypeMask)EquippedItemInventoryTypeMask);
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

                var castTime = castTimeEntry.Base + castTimeEntry.PerLevel * level;
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
                rtb.AppendFormatLine("Duration {0}, {1}, {2}", Duration, DurationPerLevel, MaxDuration);

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
                    rtb.AppendFormatLine("  Caster Aura Spell ({0}) {1}", CasterAuraSpell, DBC.DBC.SpellInfoStore[CasterAuraSpell].SpellName.Name);
                else
                    rtb.AppendFormatLine("  Caster Aura Spell ({0}) ?????", CasterAuraSpell);
            }

            if (TargetAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(TargetAuraSpell))
                    rtb.AppendFormatLine("  Target Aura Spell ({0}) {1}", TargetAuraSpell, DBC.DBC.SpellInfoStore[TargetAuraSpell].SpellName.Name);
                else
                    rtb.AppendFormatLine("  Target Aura Spell ({0}) ?????", TargetAuraSpell);
            }

            if (ExcludeCasterAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(ExcludeCasterAuraSpell))
                    rtb.AppendFormatLine("  Ex Caster Aura Spell ({0}) {1}", ExcludeCasterAuraSpell, DBC.DBC.SpellInfoStore[ExcludeCasterAuraSpell].SpellName.Name);
                else
                    rtb.AppendFormatLine("  Ex Caster Aura Spell ({0}) ?????", ExcludeCasterAuraSpell);
            }

            if (ExcludeTargetAuraSpell != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey(ExcludeTargetAuraSpell))
                    rtb.AppendFormatLine("  Ex Target Aura Spell ({0}) {1}", ExcludeTargetAuraSpell, DBC.DBC.SpellInfoStore[ExcludeTargetAuraSpell].SpellName.Name);
                else
                    rtb.AppendFormatLine("  Ex Target Aura Spell ({0}) ?????", ExcludeTargetAuraSpell);
            }

            if (RequiredAreasId > 0)
            {
                var areas = DBC.DBC.AreaGroupMember.Values.Where(ag => ag.AreaGroupId == RequiredAreasId).ToList();
                if (areas.Count == 0)
                    rtb.AppendFormatLine("Cannot find area group id {0} in AreaGroupMember.db2!", RequiredAreasId);
                else
                {
                    rtb.AppendLine();
                    rtb.SetBold();
                    rtb.AppendLine("Allowed areas:");
                    foreach (var areaGroupMember in areas)
                    {
                        var areaId = areaGroupMember.AreaId;
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

            if (ProcFlags0 != 0 && ProcFlags1 == 0)
            {
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags0: 0x{0:X8}, chance: {1}%, charges: {2}, cooldown: {3}",
                    ProcFlags0, ProcChance, ProcCharges, ProcCooldown);
                rtb.SetDefaultStyle();
                rtb.AppendFormatLine(Separator);
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags0:");
                rtb.SetDefaultStyle();
                rtb.AppendText(ProcInfo0);
            }
            else if (ProcFlags0 == 0 && ProcFlags1 != 0)
            {
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags1: 0x{0:X8}, chance: {1}%, charges: {2}, cooldown: {3}",
                    ProcFlags1, ProcChance, ProcCharges, ProcCooldown);
                rtb.SetDefaultStyle();
                rtb.AppendFormatLine(Separator);
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags1:");
                rtb.SetDefaultStyle();
                rtb.AppendText(ProcInfo1);
            }
            else if (ProcFlags0 != 0 && ProcFlags1 != 0)
            {
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags0: 0x{0:X8}, ProcFlags1: 0x{1:X8}, chance: {2}%, charges: {3}, cooldown: {4}",
                    ProcFlags0, ProcFlags1, ProcChance, ProcCharges, ProcCooldown);
                rtb.SetDefaultStyle();
                rtb.AppendFormatLine(Separator);
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags0:");
                rtb.SetDefaultStyle();
                rtb.AppendText(ProcInfo0);
                rtb.SetBold();
                rtb.AppendFormatLine("ProcFlags1:");
                rtb.SetDefaultStyle();
                rtb.AppendText(ProcInfo1);
            }
            else
                rtb.AppendFormatLine("Chance = {0}, charges - {1}", ProcChance, ProcCharges);

            rtb.AppendLine(Separator);
            foreach (var effect in Effects)
                AppendEffectInfo(rtb, effect);

            AppendItemInfo(rtb);

            AppendSpellVisualInfo(rtb);
        }

        private void AppendEffectInfo(RichTextBox rtb, SpellEffectEntry effect)
        {
            rtb.SetBold();
            rtb.AppendFormatLine($"Effect { effect.EffectIndex }: Id { effect.Effect } ({ (SpellEffects)effect.Effect })");
            rtb.SetBold();
            rtb.AppendFormatLine($"Difficulty: Id { effect.DifficultyID } ({ (Difficulty)effect.DifficultyID })");
            rtb.SetDefaultStyle();

            var value = 0.0f;

            if (effect != null &&
                Math.Abs(effect.Coefficient) > 1.0E-5f &&
                Scaling != null &&
                Scaling.Class != 0)
            {
                var level = (int)(DBC.DBC.SelectedLevel - 1);
                if ((AttributesEx11 & (uint)SpellAtributeEx11.SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL) == 0)
                {
                    if ((AttributesEx10 & (uint)SpellAtributeEx10.SPELL_ATTR10_USE_SPELL_BASE_LEVEL_FOR_SCALING) != 0)
                        level = BaseLevel;
                }
                else
                    level = (int)DBC.DBC.SelectedItemLevel;

                if (Scaling.MaxScalingLevel != 0 && Scaling.MaxScalingLevel < level)
                    level = (int)Scaling.MaxScalingLevel;

                if (level < 1)
                    level = 1;

                if (Scaling.Class != 0)
                {

                    if (Scaling.ScalesFromItemLevel == 0)
                    {
                        if ((AttributesEx11 & (uint)SpellAtributeEx11.SPELL_ATTR11_SCALES_WITH_ITEM_LEVEL) == 0)
                        {
                            var gtScaling = GameTable<GtSpellScalingEntry>.GetRecord(level);
                            Debug.Assert(gtScaling != null);
                            value = gtScaling.GetColumnForClass(Scaling.Class);
                        }
                        else if (DBC.DBC.RandPropPoints.ContainsKey(level))
                        {
                            var randPropPoints = DBC.DBC.RandPropPoints[level];
                            value = randPropPoints.Superior[0];
                        }
                    }
                    else
                    {
                        if (DBC.DBC.RandPropPoints.ContainsKey(Scaling.ScalesFromItemLevel))
                        {
                            var randPropPoints = DBC.DBC.RandPropPoints[Scaling.ScalesFromItemLevel];
                            value = randPropPoints.Superior[0];
                        }
                    }

                    // if (level < Scaling.CastTimeMaxLevel && Scaling.CastTimeMax != 0)
                    //     value *= (float)(Scaling.CastTimeMin + (level - 1) * (Scaling.CastTimeMax - Scaling.CastTimeMin) / (Scaling.CastTimeMaxLevel - 1)) / (Scaling.CastTimeMax);

                    // if (level < Scaling.NerfMaxLevel)
                    //     value *= ((((1.0f - Scaling.NerfFactor) * (level - 1)) / (Scaling.NerfMaxLevel - 1)) + Scaling.NerfFactor);
                }

                value *= effect.Coefficient;
                if (Math.Abs(value) > 1.0E-5f && value < 1.0f)
                    value = 1.0f;
                
                if (Math.Abs(effect.Variance) > 1.0E-5f)
                {
                    var delta = Math.Abs(value * effect.Variance * 0.5f);
                    rtb.AppendFormat("BasePoints = {0:F} to {1:F}", value - delta, value + delta);
                }
                else
                    rtb.AppendFormat("BasePoints = {0:F}", value);
                
                if (Math.Abs(effect.ResourceCoefficient) > 1.0E-5f)
                    rtb.AppendFormatIfNotNull(" + combo * {0:F}", effect.ResourceCoefficient * value);
            }
            else
            {
                rtb.AppendFormat("BasePoints = {0}", effect.EffectBasePoints/* + (effect.EffectDieSides == 0 ? 0 : 1)*/);

                if (Math.Abs(effect.EffectRealPointsPerLevel) > 1.0E-5f)
                    rtb.AppendFormat(" + Level * {0:F}", effect.EffectRealPointsPerLevel);

                //if (effect.EffectDieSides > 1)
                //{
                //    if (Math.Abs(effect.EffectRealPointsPerLevel) > 1.0E-5f)
                //        rtb.AppendFormat(" to {0} + lvl * {1:F}",
                //            effect.EffectBasePoints + effect.EffectDieSides, effect.EffectRealPointsPerLevel);
                //    else
                //        rtb.AppendFormat(" to {0}", effect.EffectBasePoints + effect.EffectDieSides);
                //}

                rtb.AppendFormatIfNotNull(" + resource * {0:F}", effect.EffectPointsPerResource);
            }

            if (effect.EffectBonusCoefficient > 1.0E-5f)
                rtb.AppendFormat(" + spellPower * {0}", effect.EffectBonusCoefficient);

            if (effect.BonusCoefficientFromAP > 1.0E-5)
                rtb.AppendFormat(" + AP * {0}", effect.BonusCoefficientFromAP);

            // if (Math.Abs(effect.DamageMultiplier - 1.0f) > 1.0E-5f)
            //     rtb.AppendFormat(" x {0:F}", effect.DamageMultiplier);

            // rtb.AppendFormatIfNotNull("  Multiple = {0:F}", effect.ValueMultiplier);
            rtb.AppendLine();

            rtb.AppendFormatLine("Targets ({0}, {1}) ({2}, {3})",
                effect.ImplicitTarget[0], effect.ImplicitTarget[1],
                (Targets)effect.ImplicitTarget[0], (Targets)effect.ImplicitTarget[1]);

            AuraModTypeName(rtb, effect);

            var classMask = effect.EffectSpellClassMask;

            if (classMask[0] != 0 || classMask[1] != 0 || classMask[2] != 0 || classMask[3] != 0)
            {
                rtb.AppendFormatLine("SpellClassMask = {0:X8} {1:X8} {2:X8} {3:X8}", classMask[0], classMask[1], classMask[2], classMask[3]);

                var query = from spell in DBC.DBC.SpellInfoStore.Values
                            where spell.SpellFamilyName == SpellFamilyName && spell.SpellFamilyFlags.ContainsElement(classMask)
                            join sk in DBC.DBC.SkillLineAbility.Values on spell.ID equals sk.Spell into temp
                            from skill in temp.DefaultIfEmpty(new SkillLineAbilityEntry())
                            select new
                            {
                                SpellID = spell.SpellName.SpellID,
                                SpellName = spell.SpellName.Name,
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

            rtb.AppendFormatLineIfNotNull("{0}", effect.Radius);
            rtb.AppendFormatLineIfNotNull("{0}", effect.MaxRadius);

            // append trigger spell
            var trigger = effect.EffectTriggerSpell;
            if (trigger != 0)
            {
                if (DBC.DBC.SpellInfoStore.ContainsKey((int)trigger))
                {
                    var triggerSpell = DBC.DBC.SpellInfoStore[(int)trigger];
                    rtb.SetStyle(Color.Blue, FontStyle.Bold);
                    rtb.AppendFormatLine("   Trigger spell ({0}) {1}. Chance = {2}", trigger, triggerSpell.Name, ProcChance);
                    rtb.AppendFormatLine("   Description: {0}", triggerSpell.Description);
                    rtb.AppendFormatLine("   ToolTip: {0}", triggerSpell.Tooltip);
                    rtb.SetDefaultStyle();
                    if (triggerSpell.ProcFlags0 != 0 && triggerSpell.ProcFlags1 == 0)
                    {
                        rtb.AppendFormatLine("Charges - {0}", triggerSpell.ProcCharges);
                        rtb.AppendLine(Separator);
                        rtb.AppendFormatLine("Triggered Spell ProcFlags0:");
                        rtb.AppendLine(triggerSpell.ProcInfo0);
                        rtb.AppendLine(Separator);
                    }
                    else if (triggerSpell.ProcFlags0 == 0 && triggerSpell.ProcFlags1 != 0)
                    {
                        rtb.AppendFormatLine("Charges - {0}", triggerSpell.ProcCharges);
                        rtb.AppendLine(Separator);
                        rtb.AppendFormatLine("Triggered Spell ProcFlags1:");
                        rtb.AppendLine(triggerSpell.ProcInfo1);
                        rtb.AppendLine(Separator);
                    }
                    else if (triggerSpell.ProcFlags0 != 0 && triggerSpell.ProcFlags1 != 0)
                    {
                        rtb.AppendFormatLine("Charges - {0}", triggerSpell.ProcCharges);
                        rtb.AppendLine(Separator);
                        rtb.AppendFormatLine("Triggered Spell ProcFlags0:");
                        rtb.AppendLine(triggerSpell.ProcInfo0);
                        rtb.AppendFormatLine("Triggered Spell ProcFlags1:");
                        rtb.AppendLine(triggerSpell.ProcInfo1);
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
            var items = DBC.DBC.ItemEffect.Where(effect => effect.Value.SpellID == (int)ID).ToArray();
            if (!items.Any())
                return;

            rtb.AppendLine(Separator);
            rtb.SetStyle(Color.Blue, FontStyle.Bold);
            rtb.AppendLine("Items using this spell:");
            rtb.SetDefaultStyle();

            foreach (var item in items)
            {
                if (!DBC.DBC.ItemSparse.ContainsKey((int)item.Value.ParentItemID))
                {
                    rtb.AppendFormatLine($@"   Non-existing Item-sparse.db2 entry { item.Value.ParentItemID }");
                    continue;
                }

                var itemTemplate = DBC.DBC.ItemSparse[(int)item.Value.ParentItemID];

                var name = itemTemplate.Display;
                var description = itemTemplate.Description;

                description = string.IsNullOrEmpty(description) ? string.Empty : $" - \"{ description }\"";

                rtb.AppendFormatLine($@"   { item.Value.ParentItemID }: { name } { description }");
            }
        }

        private void AppendSpellVisualInfo(RichTextBox rtb)
        {
            if (SpellVisual != null && SpellMissile != null || SpellVisualMissileSetID != 0)
            {
                rtb.AppendLine(Separator);
                rtb.SetBold();
                rtb.AppendLine("Missile data");
                rtb.SetDefaultStyle();
            }

            // Missile Model Data.
            if (SpellVisual != null && SpellMissile != null)
            {
                //rtb.AppendFormatLine("Missile Model ID: {0}", visualData.MissileModel);
                rtb.AppendFormatLine("(SpellVisual) SpellVisualID: {0}", SpellXSpellVisual.SpellVisualID);
                rtb.AppendFormatLine("(SpellVisual) Missile attachment: {0}", MissileAttachment);
                rtb.AppendFormatLine("(SpellVisual) Missile cast offset: X:{0} Y:{1} Z:{2}", MissileCastOffsetX, MissileCastOffsetY, MissileCastOffsetZ);
                rtb.AppendFormatLine("(SpellVisual) Missile impact offset: X:{0} Y:{1} Z:{2}", MissileImpactOffsetX, MissileImpactOffsetY, MissileImpactOffsetZ);
                rtb.AppendLine();
                rtb.AppendFormatLine("(SpellMissile) MissileEntry ID: {0}", MissileID);
                rtb.AppendFormatLine("(SpellMissile) Default Pitch: {0} - {1}", DefaultPitchMin, DefaultPitchMax);
                rtb.AppendFormatLine("(SpellMissile) Random Pitch: {0} - {1}", RandomizePitchMax, RandomizePitchMax);
                rtb.AppendFormatLine("(SpellMissile) Default Speed: {0} - {1}", DefaultSpeedMin, DefaultSpeedMax);
                rtb.AppendFormatLine("(SpellMissile) Randomize Speed: {0} - {1}", RandomizeSpeedMin, RandomizeSpeedMax);
                rtb.AppendFormatLine("(SpellMissile) Gravity: {0}", Gravity);
                rtb.AppendFormatLine("(SpellMissile) Maximum duration: {0}", MaximumDuration);
                rtb.AppendFormatLine("(SpellMissile) Collision Radius: {0}", CollisionRadius);
                rtb.AppendLine();
            }

            ushort MotionID = 0;
            ushort count = 0;

            if (SpellVisualMissileSetID != 0)
                foreach (var spellVisualMissile in DBC.DBC.SpellVisualMissileStore[SpellVisualMissileSetID])
                {
                    MotionID = spellVisualMissile.SpellMissileMotionID;

                    rtb.AppendFormatLine("(SpellVisualMissile)[{0}] SpellVisualMissileID: {1}", count, spellVisualMissile.ID);
                    rtb.AppendFormatLine("(SpellVisualMissile)[{0}] Attachment: {1}", count, spellVisualMissile.Attachment);
                    rtb.AppendFormatLine("(SpellVisualMissile)[{0}] Cast offset: X:{1} Y:{2} Z:{3}", count, spellVisualMissile.CastOffset[0], spellVisualMissile.CastOffset[1], spellVisualMissile.CastOffset[2]);
                    rtb.AppendFormatLine("(SpellVisualMissile)[{0}] Impact offset: X:{1} Y:{2} Z:{3}", count, spellVisualMissile.ImpactOffset[0], spellVisualMissile.ImpactOffset[1], spellVisualMissile.ImpactOffset[2]);
                    rtb.AppendLine();
                    count++;
                }

            //Missile Motion Data.
            if (DBC.DBC.SpellMissileMotion.ContainsKey(MotionID))
            {
                rtb.AppendFormatLine("(SpellMissileMotion) MissileMotionID: {0}", MotionID);
                rtb.AppendFormatLine("(SpellMissileMotion) Missile motion: {0}", DBC.DBC.SpellMissileMotion[MotionID].Name);
                rtb.AppendFormatLine("(SpellMissileMotion) Missile count: {0}", DBC.DBC.SpellMissileMotion[MotionID].MissileCount);
                rtb.AppendLine("(SpellMissileMotion) Missile Script body:");
                rtb.AppendText(DBC.DBC.SpellMissileMotion[MotionID].ScriptBody);
            }
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

        public uint Effect => SpellEffect.Effect;
        public int EffectIndex => SpellEffect.EffectIndex;
        public int EffectAttributes => SpellEffect.EffectAttributes;

        public int EffectAura => SpellEffect.EffectAura;
        public int EffectAuraPeriod => SpellEffect.EffectAuraPeriod;

        public float EffectBasePoints => SpellEffect.EffectBasePoints;

        public int EffectMiscValueA => SpellEffect.EffectMiscValue[0];
        public int EffectMiscValueB => SpellEffect.EffectMiscValue[1];

        public uint EffectSpellClassMaskA => SpellEffect.EffectSpellClassMask[0];
        public uint EffectSpellClassMaskB => SpellEffect.EffectSpellClassMask[1];
        public uint EffectSpellClassMaskC => SpellEffect.EffectSpellClassMask[2];
        public uint EffectSpellClassMaskD => SpellEffect.EffectSpellClassMask[3];

        public int EffectTriggerSpell => SpellEffect.EffectTriggerSpell;

        public int TargetA => SpellEffect.ImplicitTarget[0];
        public int TargetB => SpellEffect.ImplicitTarget[1];

        public uint EffectRadiusIndex => SpellEffect.EffectRadiusIndex[0];
        public uint EffectRadiusMaxIndex => SpellEffect.EffectRadiusIndex[1];

        public int EffectChainTargets => SpellEffect.EffectChainTargets;
        //public int EffectDieSides => SpellEffect.EffectDieSides;
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
