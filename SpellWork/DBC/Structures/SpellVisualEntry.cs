namespace SpellWork.DBC.Structures
{
    public sealed class SpellVisualEntry
    {
        public float MissileCastOffsetX;
        public float MissileCastOffsetY;
        public float MissileCastOffsetZ;
        public float MissileImpactOffsetX;
        public float MissileImpactOffsetY;
        public float MissileImpactOffsetZ;
        public uint AnimEventSoundID;
        public int Flags;
        public sbyte MissileAttachment;
        public sbyte MissileDestinationAttachment;
        public uint MissileCastPositionerID;
        public uint MissileImpactPositionerID;
        public int MissileTargetingKit;
        public uint HostileSpellVisualID;
        public uint CasterSpellVisualID;
        public ushort SpellVisualMissileSetID;
        public ushort DamageNumberDelay;
        public uint LowViolenceSpellVisualID;
        public uint RaidSpellVisualMissileSetID;
    }
}
