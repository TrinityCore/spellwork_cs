using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCastTimesEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int Base; // Base<32>
        public int Minimum; // Minimum<32>
        public short PerLevel; // PerLevel<16>
    }
}
