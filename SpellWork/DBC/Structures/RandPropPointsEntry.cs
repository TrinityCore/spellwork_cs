using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class RandPropPointsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        [Cardinality(5)]
        public uint[] Epic = new uint[5]; // Epic<u32>[5]
        [Cardinality(5)]
        public uint[] Superior = new uint[5]; // Superior<u32>[5]
        [Cardinality(5)]
        public uint[] Good = new uint[5]; // Good<u32>[5]
    }
}
