using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class RandPropPointsEntry
    {
        [Index(true)]
        public uint ID;
        public int DamageReplaceStat;
        [Cardinality(5)]
        public uint[] Epic = new uint[5];
        [Cardinality(5)]
        public uint[] Superior = new uint[5];
        [Cardinality(5)]
        public uint[] Good = new uint[5];
    }
}
