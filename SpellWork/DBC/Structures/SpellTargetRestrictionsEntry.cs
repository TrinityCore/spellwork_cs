namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        public byte DifficultyID;
        public float ConeDegrees;
        public byte MaxTargets;
        public uint MaxTargetLevel;
        public ushort TargetCreatureType;
        public int Targets;
        public float Width;
        public int SpellID;
    }
}
