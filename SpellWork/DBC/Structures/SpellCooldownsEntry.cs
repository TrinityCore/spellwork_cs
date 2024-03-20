using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCooldownsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int CategoryRecoveryTime; // CategoryRecoveryTime<32>
        public int RecoveryTime; // RecoveryTime<32>
        public int StartRecoveryTime; // StartRecoveryTime<32>
        public byte DifficultyID; // DifficultyID<u8>
        public int SpellID; // SpellID<32>
    }
}
