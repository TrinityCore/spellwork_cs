using System;
using System.Linq;
using System.Text;
using SpellWork.DBC.Structures;
using SpellWork.Extensions;
using System.Collections.Generic;

namespace SpellWork.Spell
{
    public sealed class SpellInfoHelper
    {
        public uint ID = 0;                                           // 0        m_ID
        public uint Category = 0;                                     // 1        m_category
        public uint Dispel = 0;                                       // 2        m_dispelType
        public uint Mechanic = 0;                                     // 3        m_mechanic
        public uint Attributes = 0;                                   // 4        m_attribute
        public uint AttributesEx = 0;                                 // 5        m_attributesEx
        public uint AttributesEx2 = 0;                                // 6        m_attributesExB
        public uint AttributesEx3 = 0;                                // 7        m_attributesExC
        public uint AttributesEx4 = 0;                                // 8        m_attributesExD
        public uint AttributesEx5 = 0;                                // 9        m_attributesExE
        public uint AttributesEx6 = 0;                                // 10       m_attributesExF
        public uint AttributesEx7 = 0;                                // 11       3.2.0 (0x20 - totems, 0x4 - paladin auras, etc...)
        public uint AttributesEx8 = 0;
        public uint AttributesEx9 = 0;
        public uint AttributesEx10 = 0;
        public uint AttributesEx11 = 0;
        public uint AttributesEx12 = 0;
        public uint AttributesEx13 = 0;
        public ulong Stances = 0;                                     // 12-13    m_shapeshiftMask
        public ulong StancesNot = 0;                                  // 14-15    m_shapeshiftExclude
        //public uint Targets = 0;                                      // 16       m_targets
        //public uint TargetCreatureType = 0;                           // 17       m_targetCreatureType
        public uint RequiresSpellFocus = 0;                           // 18       m_requiresSpellFocus
        public uint FacingCasterFlags = 0;                            // 19       m_facingCasterFlags
        public uint CasterAuraState = 0;                              // 20       m_casterAuraState
        public uint TargetAuraState = 0;                              // 21       m_targetAuraState
        public uint CasterAuraStateNot = 0;                           // 22       m_excludeCasterAuraState
        public uint TargetAuraStateNot = 0;                           // 23       m_excludeTargetAuraState
        public uint CasterAuraSpell = 0;                              // 24       m_casterAuraSpell
        public uint TargetAuraSpell = 0;                              // 25       m_targetAuraSpell
        public uint ExcludeCasterAuraSpell = 0;                       // 26       m_excludeCasterAuraSpell
        public uint ExcludeTargetAuraSpell = 0;                       // 27       m_excludeTargetAuraSpell
        public uint CastingTimeIndex = 0;                             // 28       m_castingTimeIndex
        public uint RecoveryTime = 0;                                 // 29       m_recoveryTime
        public uint CategoryRecoveryTime = 0;                         // 30       m_categoryRecoveryTime
        public uint InterruptFlags = 0;                               // 31       m_interruptFlags
        public uint AuraInterruptFlags = 0;                           // 32       m_auraInterruptFlags
        public uint ChannelInterruptFlags = 0;                        // 33       m_channelInterruptFlags
        public uint ProcFlags = 0;                                    // 34       m_procTypeMask
        public uint ProcChance = 0;                                   // 35       m_procChance
        public uint ProcCharges = 0;                                  // 36       m_procCharges
        public uint MaxLevel = 0;                                     // 37       m_maxLevel
        public uint BaseLevel = 0;                                    // 38       m_baseLevel
        public uint SpellLevel = 0;                                   // 39       m_spellLevel
        public uint DurationIndex = 0;                                // 40       m_durationIndex
        //public uint PowerType;                                    // 41       m_powerType
        //public uint ManaCost;                                     // 42       m_manaCost
        //public uint ManaCostPerlevel;                             // 43       m_manaCostPerLevel
        //public uint ManaPerSecond;                                // 44       m_manaPerSecond
        public uint RangeIndex = 0;                                   // 46       m_rangeIndex
        public float Speed = 0;                                       // 47       m_speed
        public uint ModalNextSpell = 0;                               // 48       m_modalNextSpell not used
        public uint StackAmount = 0;                                  // 49       m_cumulativeAura
        public uint[] Totem;                                      // 50-51    m_totem
        public uint[] Reagent;                                    // 52-59    m_reagent
        public uint[] ReagentCount;                               // 60-67    m_reagentCount
        public uint EquippedItemClass = 0;                             // 68       m_equippedItemClass (value)
        public uint EquippedItemSubClassMask = 0;                      // 69       m_equippedItemSubclass (mask)
        public uint EquippedItemInventoryTypeMask = 0;                 // 70       m_equippedItemInvTypes (mask)
        public List<SpellEffectEntry> Effects = new List<SpellEffectEntry>();
        public uint[] SpellVisual = new uint[2];                                // 131-132  m_spellVisualID
        public uint SpellIconID = 0;                                  // 133      m_spellIconID
        public uint ActiveIconID = 0;                                 // 134      m_activeIconID
        public string SpellName;                                // 136-151  m_name_lang
        public string Rank;                                     // 153-168  m_nameSubtext_lang
        public string _Description;                              // 170-185  m_description_lang not used
        public string ToolTip;                                  // 187-202  m_auraDescription_lang not used
        //public uint ManaCostPercentage;                           // 204      m_manaCostPct
        public uint StartRecoveryCategory = 0;                        // 205      m_startRecoveryCategory
        public uint StartRecoveryTime = 0;                            // 206      m_startRecoveryTime
        //public uint MaxTargetLevel = 0;                               // 207      m_maxTargetLevel
        public uint SpellFamilyName = 0;                              // 208      m_spellClassSet
        public uint[] SpellFamilyFlags;                           // 209-212  m_spellClassMask
        //public uint MaxAffectedTargets = 0;                           // 213      m_maxTargets
        public uint DmgClass = 0;                                     // 214      m_defenseType
        public uint PreventionType = 0;                               // 215      m_preventionType
        public int StanceBarOrder = 0;                                // 216      m_stanceBarOrder not used
        public uint MinFactionId = 0;                                 // 219      m_minFactionID not used
        public uint MinReputation = 0;                                // 220      m_minReputation not used
        public uint RequiredAuraVision = 0;                           // 221      m_requiredAuraVision not used
        public uint[] TotemCategory;                              // 222-223  m_requiredTotemCategoryID
        public int AreaGroupId = 0;                                  // 224      m_requiredAreaGroupId
        public uint SchoolMask = 0;                                   // 225      m_schoolMask
        public uint RuneCostID = 0;                                   // 226      m_runeCostID
        public uint SpellMissileID = 0;                               // 227      m_spellMissileID not used
        public uint PowerDisplayId = 0;                               // 228      PowerDisplay.dbc, new in 3.1
        public uint SpellDescriptionVariableID = 0;                   // 232      3.2.0
        public uint SpellDifficultyId = 0;                            // 233      3.3.0                           // 239      3.3.0
        public SpellScalingEntry Scaling;
        public List<SpellPowerEntry> SpellPowerList;
        public List<SpellTargetRestrictionsEntry> SpellTargetRestrictionsList;
        public SpellRuneCostEntry RuneCost;

        public string CastTime
        {
            get
            {
                if (Scaling != null)
                {
                    if (Scaling.MaxCastTime > 0)
                    {
                        if (Scaling.MaxCastTimeLevel > DBC.DBC.SelectedLevel)
                            return String.Format("Cast time = {0:F}", (Scaling.MinCastTime + (DBC.DBC.SelectedLevel - 1) * (Scaling.MaxCastTime - Scaling.MinCastTime) / (Scaling.MaxCastTimeLevel - 1)) / 1000.0f);

                        return String.Format("Cast time = {0:F}", Scaling.MaxCastTime / 1000.0f);
                    }

                    return String.Empty;
                }

                if (CastingTimeIndex == 0)
                    return String.Empty;

                return !DBC.DBC.SpellCastTimes.ContainsKey(CastingTimeIndex)
                           ? String.Format("Cast time (Id {0}) = ????", CastingTimeIndex)
                           : String.Format("Cast time (Id {0}) = {1:F}", CastingTimeIndex,
                                           DBC.DBC.SpellCastTimes[CastingTimeIndex].CastTime / 1000.0f);
            }
        }

        public string Duration
        {
            get { return DBC.DBC.SpellDuration.ContainsKey(DurationIndex) ? DBC.DBC.SpellDuration[DurationIndex].ToString() : String.Empty; }
        }

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

                return sb.ToString();
            }
        }

        public string Range
        {
            get
            {
                if (RangeIndex == 0 || !DBC.DBC.SpellRange.ContainsKey(RangeIndex))
                    return String.Empty;

                var range = DBC.DBC.SpellRange[RangeIndex];
                var sb = new StringBuilder();
                sb.AppendFormatLine("SpellRange: (Id {0}) \"{1}\":", range.Id, range.Name);
                sb.AppendFormatLine("    MinRangeNegative = {0}, MinRangePositive = {1}", range.MinRangeNegative, range.MinRangePositive);
                sb.AppendFormatLine("    MaxRangeNegative = {0}, MaxRangePositive = {1}", range.MaxRangeNegative, range.MaxRangePositive);

                return sb.ToString();
            }
        }

        public SpellSchoolMask School
        {
            get { return (SpellSchoolMask)SchoolMask; }
        }

        public string SpellNameRank
        {
            get { return String.IsNullOrEmpty(Rank) ? SpellName : String.Format("{0} ({1})", SpellName, Rank); }
        }

        public string ScalingText { get { return Scaling != null ? String.Format(" (Level {0})", DBC.DBC.SelectedLevel) : String.Empty; } }

        public string Description
        {
            get
            {
                var sb = new StringBuilder();
                if (!String.IsNullOrEmpty(_Description))
                    sb.AppendFormatLine("Description: {0}", _Description);

                if (SpellDescriptionVariableID == 0 || !DBC.DBC.SpellDescriptionVariables.ContainsKey(SpellDescriptionVariableID))
                    return sb.ToString();

                var sdesc = DBC.DBC.SpellDescriptionVariables[SpellDescriptionVariableID];
                sb.AppendFormatLine("Description variable Id: {0}", sdesc.Id);
                sb.AppendFormatLine("Description variable: {0}", sdesc.Variables);
                return sb.ToString();
            }
        }

        public SpellInfoHelper(SpellEntry dbcData)
        {
            ID = dbcData.Id;
            var miscs = dbcData.MiscEntry;
            if (miscs != null)
            {
                Attributes = dbcData.MiscEntry.Attributes;
                AttributesEx = dbcData.MiscEntry.AttributesEx;
                AttributesEx2 = dbcData.MiscEntry.AttributesEx2;
                AttributesEx3 = dbcData.MiscEntry.AttributesEx3;
                AttributesEx4 = dbcData.MiscEntry.AttributesEx4;
                AttributesEx5 = dbcData.MiscEntry.AttributesEx5;
                AttributesEx6 = dbcData.MiscEntry.AttributesEx6;
                AttributesEx7 = dbcData.MiscEntry.AttributesEx7;
                AttributesEx8 = dbcData.MiscEntry.AttributesEx8;
                AttributesEx9 = dbcData.MiscEntry.AttributesEx9;
                AttributesEx10 = dbcData.MiscEntry.AttributesEx10;
                AttributesEx11 = dbcData.MiscEntry.AttributesEx11;
                AttributesEx12 = dbcData.MiscEntry.AttributesEx12;
                AttributesEx13 = dbcData.MiscEntry.AttributesEx13;
                CastingTimeIndex = dbcData.MiscEntry.CastingTimeIndex;
                DurationIndex = dbcData.MiscEntry.DurationIndex;
                //PowerType = dbcData.MiscEntry.PowerType;
                RangeIndex = dbcData.MiscEntry.RangeIndex;
                Speed = dbcData.MiscEntry.Speed;
                SpellVisual[0] = dbcData.MiscEntry.SpellVisual[0];
                SpellVisual[1] = dbcData.MiscEntry.SpellVisual[1];
                SpellIconID = dbcData.MiscEntry.SpellIconID;
                ActiveIconID = dbcData.MiscEntry.ActiveIconID;
                SchoolMask = dbcData.MiscEntry.SchoolMask;
            }
            SpellName = dbcData.SpellName;
            Rank = dbcData.Rank;
            _Description = dbcData.Description;
            ToolTip = dbcData.ToolTip;
            RuneCostID = dbcData.RuneCostID;
            SpellMissileID = dbcData.SpellMissileID;
            SpellDescriptionVariableID = dbcData.SpellDescriptionVariableID;
            SpellDifficultyId = dbcData.SpellDifficultyId;

            if (DBC.DBC.SpellRuneCost.ContainsKey(RuneCostID))
                RuneCost = DBC.DBC.SpellRuneCost[RuneCostID];

            // SpellCategories.dbc
            var cat = dbcData.Category;
            if (cat != null)
            {
                Category = cat.Category;
                Dispel = cat.Dispel;
                Mechanic = cat.Mechanic;
                StartRecoveryCategory = cat.StartRecoveryCategory;
                DmgClass = cat.DmgClass;
                PreventionType = cat.PreventionType;
            }

            // SpellShapeshift.dbc
            var shapeshift = dbcData.Shapeshift;
            if (shapeshift != null)
            {
                Stances = shapeshift.Stances;
                StancesNot = shapeshift.StancesNot;
                StanceBarOrder = shapeshift.StanceBarOrder;
            }

            // SpellTargetRestrictions.dbc
            SpellTargetRestrictionsList = dbcData.TargetRestrictionsList;

            // SpellCastingRequirements.dbc
            var castingRequirements = dbcData.CastingRequirements;
            if (castingRequirements != null)
            {
                RequiresSpellFocus = castingRequirements.RequiresSpellFocus;
                FacingCasterFlags = castingRequirements.FacingCasterFlags;
                MinFactionId = castingRequirements.MinFactionId;
                MinReputation = castingRequirements.MinReputation;
                RequiredAuraVision = castingRequirements.RequiredAuraVision;
                AreaGroupId = castingRequirements.AreaGroupId;
            }

            // SpellAuraRestrictions.dbc
            var auraRestrictions = dbcData.AuraRestrictions;
            if (auraRestrictions != null)
            {
                CasterAuraState = auraRestrictions.CasterAuraState;
                TargetAuraState = auraRestrictions.TargetAuraState;
                CasterAuraStateNot = auraRestrictions.CasterAuraStateNot;
                TargetAuraStateNot = auraRestrictions.TargetAuraStateNot;
                CasterAuraSpell = auraRestrictions.CasterAuraSpell;
                TargetAuraSpell = auraRestrictions.TargetAuraSpell;
                ExcludeCasterAuraSpell = auraRestrictions.ExcludeCasterAuraSpell;
                ExcludeTargetAuraSpell = auraRestrictions.ExcludeTargetAuraSpell;
            }

            // SpellCooldowns.dbc
            var cooldowns = dbcData.Cooldowns;
            if (cooldowns != null)
            {
                RecoveryTime = cooldowns.RecoveryTime;
                CategoryRecoveryTime = cooldowns.CategoryRecoveryTime;
                StartRecoveryTime = cooldowns.StartRecoveryTime;
            }

            // SpellInterrupts.dbc
            var interrupts = dbcData.Interrupts;
            if (interrupts != null)
            {
                InterruptFlags = interrupts.InterruptFlags;
                AuraInterruptFlags = interrupts.AuraInterruptFlags;
                ChannelInterruptFlags = interrupts.ChannelInterruptFlags;
            }

            // SpellAuraOptions.dbc
            var options = dbcData.AuraOptions;
            if (options != null)
            {
                ProcFlags = options.ProcFlags;
                ProcChance = options.ProcChance;
                ProcCharges = options.ProcCharges;
                StackAmount = options.StackAmount;
            }

            // SpellLevels.dbc
            var levels = dbcData.Levels;
            if (levels != null)
            {
                MaxLevel = levels.MaxLevel;
                BaseLevel = levels.BaseLevel;
                SpellLevel = levels.SpellLevel;
            }

            SpellPowerList = dbcData.SpellPowerList;


            // SpellClassOptions.dbc
            var classOptions = dbcData.ClassOptions;
            if (classOptions != null)
            {
                ModalNextSpell = classOptions.ModalNextSpell;
                SpellFamilyName = classOptions.SpellFamilyName;
                SpellFamilyFlags = (uint[])classOptions.SpellFamilyFlags.Clone();
            }
            else
                SpellFamilyFlags = new uint[4];

            // SpellTotems.dbc
            /*var totems = dbcData.Totems;
            if (totems != null)
            {
                Totem = (uint[])totems.Totem.Clone();
                TotemCategory = (uint[])totems.TotemCategory.Clone();
            }
            else
            {
                Totem = new uint[2];
                TotemCategory = new uint[2];
            }*/

            // SpellReagents.dbc
            var reagents = dbcData.Reagents;
            if (reagents != null)
            {
                Reagent = (uint[])reagents.ItemId.Clone();
                ReagentCount = (uint[])reagents.Count.Clone();
            }
            else
            {
                Reagent = new uint[8];
                ReagentCount = new uint[8];
            }

            // SpellEquippedItems.dbc
            var equippedItems = dbcData.EquippedItems;
            if (equippedItems != null)
            {
                EquippedItemClass = equippedItems.EquippedItemClass;
                EquippedItemSubClassMask = equippedItems.EquippedItemSubClassMask;
                EquippedItemInventoryTypeMask = equippedItems.EquippedItemInventoryTypeMask;
            }

            Scaling = dbcData.Scaling;
            Effects = new List<SpellEffectEntry>();

            if (DBC.DBC.SpellEffectLists.ContainsKey(ID))
            {
                Effects = DBC.DBC.SpellEffectLists[ID];
            }
        }

        public bool HasEffect(SpellEffects effect)
        {
            return Effects.Where(eff => eff != null && eff.Type == (uint)effect).Count() > 0;
        }

        public bool HasAura(AuraType aura)
        {
            return Effects.Where(eff => eff != null && eff.ApplyAuraName == (uint)aura).Count() > 0;
        }

        public bool HasTargetA(Targets target)
        {
            return Effects.Where(eff => eff != null && eff.ImplicitTargetA == (uint)target).Count() > 0;
        }

        public bool HasTargetB(Targets target)
        {
            return Effects.Where(eff => eff != null && eff.ImplicitTargetB == (uint)target).Count() > 0;
        }
    }
}
