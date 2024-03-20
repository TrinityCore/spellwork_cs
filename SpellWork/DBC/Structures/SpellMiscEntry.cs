using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellMiscEntry
    {
        [Index(true)]
        public int ID;
        public ushort CastingTimeIndex;
        public ushort DurationIndex;
        public ushort RangeIndex;
        public byte SchoolMask;
        public int SpellIconFileDataID;
        public float Speed;
        public int ActiveIconFileDataID;
        public float LaunchDelay;
        public byte DifficultyID;
        [Cardinality(14)]
        public int[] Attributes = new int[14];
        public int SpellID;
    }
}
