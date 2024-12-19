using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellInterruptsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public short InterruptFlags;
        [Cardinality(2)]
        public int[] AuraInterruptFlags = new int[2];
        [Cardinality(2)]
        public int[] ChannelInterruptFlags = new int[2];
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
