namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public uint ID;
        public float ConeDegrees;
        public float Width;
        public int Targets;
        public short TargetCreatureType;
        public byte DifficultyID;
        public byte MaxTargets;
        public uint MaxTargetLevel;
        public int SpellID;
    }
}
