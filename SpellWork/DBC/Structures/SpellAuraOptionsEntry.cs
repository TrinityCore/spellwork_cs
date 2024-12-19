using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraOptionsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public uint CumulativeAura;
        public int ProcCategoryRecovery;
        public byte ProcChance;
        public int ProcCharges;
        public ushort SpellProcsPerMinuteID;
        [Cardinality(2)]
        public int[] ProcTypeMask = new int[2];
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
