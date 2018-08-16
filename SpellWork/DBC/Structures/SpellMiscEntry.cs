namespace SpellWork.DBC.Structures
{
    public class SpellMiscEntry
    {
        public uint ID;
        public ushort CastingTimeIndex;
        public ushort DurationIndex;
        public ushort RangeIndex;
        public byte SchoolMask;
        public int SpellIconFileDataID;
        public float Speed;
        public int ActiveIconFileDataID;
        public float LaunchDelay;
        public byte DifficultyID;
        public int Attributes[14];
        public int SpellID;
    }
}
