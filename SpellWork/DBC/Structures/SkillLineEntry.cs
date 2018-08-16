namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineEntry
    {
        public uint ID;
        public string DisplayName;
        public string Description;
        public string AlternateVerb;
        public ushort Flags;
        public sbyte CategoryID;
        public sbyte CanLink;
        public int SpellIconFileID;
        public uint ParentSkillLineID;
    }
}
