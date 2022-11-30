using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraRestrictionsEntry
    {
        [Index(true)]
        public uint ID;
        public int DifficultyID;
        public int CasterAuraState;
        public int TargetAuraState;
        public int ExcludeCasterAuraState;
        public int ExcludeTargetAuraState;
        public int CasterAuraSpell;
        public int TargetAuraSpell;
        public int ExcludeCasterAuraSpell;
        public int ExcludeTargetAuraSpell;
        public int CasterAuraType;
        public int TargetAuraType;
        public int ExcludeCasterAuraType;
        public int ExcludeTargetAuraType;
        public int SpellID;
    }
}
