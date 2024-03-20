using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public string DisplayName_lang; // DisplayName_lang
        public string Description_lang; // Description_lang
        public string AlternateVerb_lang; // AlternateVerb_lang
        public ushort Flags; // Flags<u16>
        public sbyte CategoryID; // CategoryID<8>
        public sbyte CanLink; // CanLink<8>
        public int SpellIconFileID; // SpellIconFileID<32>
        public uint ParentSkillLineID; // ParentSkillLineID<u32>
    }
}
