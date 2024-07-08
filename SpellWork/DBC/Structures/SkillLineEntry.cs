using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineEntry
    {
        public string DisplayName;
        public string AlternateVerb;
        public string Description;
        public string HordeDisplayName;
        public string OverrideSourceInfoDisplayName;
        [Index(false)]
        public uint ID;
        public sbyte CategoryID;
        public int SpellIconFileID;
        public sbyte CanLink;
        public uint ParentSkillLineID;
        public int ParentTierIndex;
        public ushort Flags;
        public int SpellBookSpellID;
    }
}
