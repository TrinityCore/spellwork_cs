using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public class SpellProcsPerMinuteEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public float BaseProcRate; // BaseProcRate
        public byte Flags; // Flags<u8>
    }
}
