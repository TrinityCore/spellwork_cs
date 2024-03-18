using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        [Index(true)]
        public int ID;
        public string DisplayName;
        public string DisplayNameShort;
        [Cardinality(2)]
        public float[] MinRange;
        [Cardinality(2)]
        public float[] MaxRange;
        public byte Flags;
    }
}
