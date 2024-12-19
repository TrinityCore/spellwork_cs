using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraRestrictionsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public byte CasterAuraState;
        public byte TargetAuraState;
        public byte ExcludeCasterAuraState;
        public byte ExcludeTargetAuraState;
        public int CasterAuraSpell;
        public int TargetAuraSpell;
        public int ExcludeCasterAuraSpell;
        public int ExcludeTargetAuraSpell;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
