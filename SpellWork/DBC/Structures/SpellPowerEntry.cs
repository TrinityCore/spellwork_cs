namespace SpellWork.DBC.Structures
{
    public sealed class SpellPowerEntry
    {
        public int ManaCost;
        public float PowerCostPct;
        public float PowerPctPerSecond;
        public int RequiredAuraSpellID;
        public float PowerCostMaxPct;
        public byte OrderIndex;
        public sbyte PowerType;
        public uint ID;
        public int ManaCostPerLevel;
        public int ManaPerSecond;
        public uint OptionalCost;                                            // Spell uses [ManaCost, ManaCost+ManaCostAdditional] power - affects tooltip parsing as multiplier on SpellEffectEntry::EffectPointsPerResource
                                                                        //   only SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL, SPELL_EFFECT_WEAPON_PERCENT_DAMAGE, SPELL_EFFECT_WEAPON_DAMAGE, SPELL_EFFECT_NORMALIZED_WEAPON_DMG
        public uint PowerDisplayID;
        public int AltPowerBarID;
        public int SpellID;
    }
}
