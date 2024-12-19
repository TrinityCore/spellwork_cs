using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellMiscEntry
    {
        [Index(true)]
        public uint ID;
        [Cardinality(16)]
        public int[] Attributes = new int[16];
        public byte DifficultyID;
        public ushort CastingTimeIndex;
        public ushort DurationIndex;
        public ushort RangeIndex;
        public byte SchoolMask;
        public float Speed;
        public float LaunchDelay;
        public float MinDuration;
        public int SpellIconFileDataID;
        public int ActiveIconFileDataID;
        public int ContentTuningID;
        public int ShowFutureSpellPlayerConditionID;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
