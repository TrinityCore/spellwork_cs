using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellVisualMissileEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] CastOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] ImpactOffset;
        public int ID;
        public ushort SpellVisualEffectNameID;
        public uint SoundEntriesID;
        public sbyte Attachment;
        public sbyte DestinationAttachment;
        public ushort CastPositionerID;
        public ushort ImpactPositionerID;
        public int FollowGroundHeight;
        public uint FollowGroundDropSpeed;
        public ushort FollowGroundApproach;
        public uint Flags;
        public ushort SpellMissileMotionID;
        public uint AnimKitID;
        public ushort SpellVisualMissileSetID;
    }
}
