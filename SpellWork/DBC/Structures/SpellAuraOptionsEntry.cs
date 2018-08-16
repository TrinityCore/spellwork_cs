namespace SpellWork.DBC.Structures
{
    public class SpellAuraOptionsEntry
    {
        public uint ID;
        public int ProcCharges;
        public int ProcTypeMask;
        public int ProcCategoryRecovery;
        public ushort CumulativeAura;
        public ushort SpellProcsPerMinuteID;
        public byte DifficultyID;
        public byte ProcChance;
        public int SpellID;
    }
}
