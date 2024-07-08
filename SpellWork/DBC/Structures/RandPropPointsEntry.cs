using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class RandPropPointsEntry
    {
        [Index(true)]
        public uint ID;
        public int DamageReplaceStat;
        [Cardinality(5)]
        public uint[] Epic;
        [Cardinality(5)]
        public uint[] Superior;
        [Cardinality(5)]
        public uint[] Good;
    }
}
