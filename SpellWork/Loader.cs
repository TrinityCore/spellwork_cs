using System;
using SpellWork.DBC;
using SpellWork.Spell;

namespace SpellWork
{
    class Loader
    {
        public Loader()
        {
            DBC.DBC.AreaGroup = DBCReader.ReadDBC<AreaGroupEntry>(null);
            DBC.DBC.AreaTable = DBCReader.ReadDBC<AreaTableEntry>(DBC.DBC.AreaStrings);
            DBC.DBC.OverrideSpellData = DBCReader.ReadDBC<OverrideSpellDataEntry>(null);
            DBC.DBC.ScreenEffect = DBCReader.ReadDBC<ScreenEffectEntry>(DBC.DBC.ScreenEffectStrings);
            DBC.DBC.SkillLine = DBCReader.ReadDBC<SkillLineEntry>(DBC.DBC.SkillLineStrings);
            DBC.DBC.SkillLineAbility = DBCReader.ReadDBC<SkillLineAbilityEntry>(null);
            DBC.DBC.Spell = DBCReader.ReadDBC<SpellEntry>(DBC.DBC.SpellStrings);
            DBC.DBC.SpellCastTimes = DBCReader.ReadDBC<SpellCastTimesEntry>(null);
            DBC.DBC.SpellDifficulty = DBCReader.ReadDBC<SpellDifficultyEntry>(null);
            DBC.DBC.SpellDuration = DBCReader.ReadDBC<SpellDurationEntry>(null);
            DBC.DBC.SpellRadius = DBCReader.ReadDBC<SpellRadiusEntry>(null);
            DBC.DBC.SpellRange = DBCReader.ReadDBC<SpellRangeEntry>(DBC.DBC.SpellRangeStrings);
            DBC.DBC.SpellMissile = DBCReader.ReadDBC<SpellMissileEntry>(null);
            DBC.DBC.SpellMissileMotion = DBCReader.ReadDBC<SpellMissileMotionEntry>(DBC.DBC.SpellMissileMotionStrings);
            DBC.DBC.SpellVisual = DBCReader.ReadDBC<SpellVisualEntry>(null);

            DBC.DBC.Locale = DetectedLocale;
        }

        /// <exception cref="Exception"><c>Exception</c>.</exception>
        private static LocalesDBC DetectedLocale
        {
            get
            {
                byte locale = 0;
                while (DBC.DBC.Spell[DBC.DBC.SpellEntryForDetectLocale].GetName(locale) == String.Empty)
                {
                    ++locale;

                    if (locale >= DBC.DBC.MaxDbcLocale)
                        throw new Exception("Detected unknown locale index " + locale);
                }
                return (LocalesDBC)locale;
            }
        }
    }
}
