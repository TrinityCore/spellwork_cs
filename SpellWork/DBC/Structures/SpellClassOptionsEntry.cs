using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellClassOptionsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        [Cardinality(4)]
        public int[] SpellClassMask = new int[4]; // SpellClassMask<32>[4]
        public byte SpellClassSet; // SpellClassSet<u8>
        public uint ModalNextSpell; // ModalNextSpell<u32>
    }
}
