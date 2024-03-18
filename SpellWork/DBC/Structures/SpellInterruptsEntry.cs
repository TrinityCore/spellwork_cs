using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellInterruptsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public byte DifficultyID; // DifficultyID<u8>
        public short InterruptFlags; // InterruptFlags<16>
        [Cardinality(2)]
        public int[] AuraInterruptFlags = new int[2]; // AuraInterruptFlags<32>[2]
        [Cardinality(2)]
        public int[] ChannelInterruptFlags = new int[2]; // ChannelInterruptFlags<32>[2]
        public int SpellID; // SpellID<32>

    }
}
