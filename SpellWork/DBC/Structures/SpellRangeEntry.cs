using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        [Index(true)]
        public uint ID;
        public string DisplayName;
        public string DisplayNameShort;
        public byte Flags;
        [Cardinality(2)]
        public float[] RangeMin = new float[2];
        [Cardinality(2)]
        public float[] RangeMax = new float[2];
    }
}
