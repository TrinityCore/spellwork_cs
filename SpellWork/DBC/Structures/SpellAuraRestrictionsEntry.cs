using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraRestrictionsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int CasterAuraSpell; // CasterAuraSpell<32>
        public int TargetAuraSpell; // TargetAuraSpell<32>
        public int ExcludeCasterAuraSpell; // ExcludeCasterAuraSpell<32>
        public int ExcludeTargetAuraSpell; // ExcludeTargetAuraSpell<32>
        public byte DifficultyID; // DifficultyID<u8>
        public byte CasterAuraState; // CasterAuraState<u8>
        public byte TargetAuraState; // TargetAuraState<u8>
        public byte ExcludeCasterAuraState; // ExcludeCasterAuraState<u8>
        public byte ExcludeTargetAuraState; // ExcludeTargetAuraState<u8>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
