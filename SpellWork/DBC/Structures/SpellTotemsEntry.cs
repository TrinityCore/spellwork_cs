using DBFileReaderLib.Attributes;
using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellTotemsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        [Cardinality(2)]
        public int[] Totem = new int[2]; // Totem<32>[2]
        [Cardinality(2)]
        public ushort[] RequiredTotemCategoryID = new ushort[2]; // RequiredTotemCategoryID<u16>[2]
    }
}
