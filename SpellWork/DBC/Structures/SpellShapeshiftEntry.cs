using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellShapeshiftEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        [Cardinality(2)]
        public int[] ShapeshiftExclude = new int[2]; // ShapeshiftExclude<32>[2]
        [Cardinality(2)]
        public int[] ShapeshiftMask = new int[2]; // ShapeshiftMask<32>[2]
        public sbyte StanceBarOrder; // StanceBarOrder<8>
    }
}
