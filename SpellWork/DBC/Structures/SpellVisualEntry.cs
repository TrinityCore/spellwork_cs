namespace SpellWork.DBC.Structures
{
    public sealed class SpellVisualEntry
    {
        public uint SpellVisualID;
        public uint ID;
        public float Probability;
        public ushort CasterPlayerConditionID;
        public ushort CasterUnitConditionID;
        public ushort ViewerPlayerConditionID;
        public ushort ViewerUnitConditionID;
        public int SpellIconFileID;
        public int ActiveIconFileID;
        public byte Flags;
        public byte DifficultyID;
        public byte Priority;
        public int SpellID;
    }
}
