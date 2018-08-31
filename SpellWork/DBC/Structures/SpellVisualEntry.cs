using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellVisualEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] MissileCastOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] MissileImpactOffset;
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
