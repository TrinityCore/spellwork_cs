using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraOptionsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int ProcCharges; // ProcCharges<32>
        [Cardinality(2)]
        public int[] ProcTypeMask = new int[2]; // ProcTypeMask<32>[2]
        public int ProcCategoryRecovery; // ProcCategoryRecovery<32>
        public ushort CumulativeAura; // CumulativeAura<u16>
        public ushort SpellProcsPerMinuteID; // SpellProcsPerMinuteID<u16>
        public byte DifficultyID; // DifficultyID<u8>
        public byte ProcChance; // ProcChance<u8>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
