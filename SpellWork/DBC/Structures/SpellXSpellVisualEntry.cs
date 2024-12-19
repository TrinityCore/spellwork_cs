using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellXSpellVisualEntry
    {
        [Index(false)]
        public uint ID;
        public byte DifficultyID;
        public uint SpellVisualID;
        public float Probability;
        public byte Flags;
        public int Priority;
        public int SpellIconFileID;
        public int ActiveIconFileID;
        public ushort ViewerUnitConditionID;
        public uint ViewerPlayerConditionID;
        public ushort CasterUnitConditionID;
        public uint CasterPlayerConditionID;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
