using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellLevelsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public short BaseLevel;
        public short MaxLevel;
        public short SpellLevel;
        public byte MaxPassiveAuraLevel;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
