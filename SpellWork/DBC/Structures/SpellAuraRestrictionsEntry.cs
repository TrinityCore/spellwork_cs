namespace SpellWork.DBC.Structures
{
    public class SpellAuraRestrictionsEntry
    {
        public byte DifficultyID;
        public byte CasterAuraState;
        public byte TargetAuraState;
        public byte ExcludeCasterAuraState;
        public byte ExcludeTargetAuraState;
        public int CasterAuraSpell;
        public int TargetAuraSpell;
        public int ExcludeCasterAuraSpell;
        public int ExcludeTargetAuraSpell;
        public int SpellID;
    }
}
