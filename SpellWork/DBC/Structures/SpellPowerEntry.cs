namespace SpellWork.DBC.Structures
{
    public sealed class SpellPowerEntry
    {
        public int ID;
        public byte OrderIndex;
        public int ManaCost;
        public int ManaCostPerLevel;
        public uint ManaPerSecond;
        public uint PowerDisplayID;
        public int AltPowerBarID;
        public float PowerCostPct;
        public float PowerCostMaxPct;
        public float PowerPctPerSecond;
        public sbyte PowerType;
        public int RequiredAuraSpellID;
        public uint OptionalCost;
        public int SpellID;
    }
}
