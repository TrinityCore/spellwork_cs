using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public float ConeDegrees;
        public byte MaxTargets;
        public uint MaxTargetLevel;
        public short TargetCreatureType;
        public int Targets;
        public float Width;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
