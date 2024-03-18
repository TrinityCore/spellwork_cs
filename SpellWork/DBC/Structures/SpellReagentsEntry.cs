using DBFileReaderLib.Attributes;
using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellReagentsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        [Cardinality(8)]
        public int[] Reagent = new int[8]; // Reagent<32>[8]
        [Cardinality(8)]
        public short[] ReagentCount = new short[8]; // ReagentCount<16>[8]
    }
}
