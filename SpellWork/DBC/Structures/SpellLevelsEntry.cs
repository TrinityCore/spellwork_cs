using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellLevelsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public short BaseLevel; // BaseLevel<16>
        public short MaxLevel; // MaxLevel<16>
        public short SpellLevel; // SpellLevel<16>
        public byte DifficultyID; // DifficultyID<u8>
        public byte MaxPassiveAuraLevel; // MaxPassiveAuraLevel<u8>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
