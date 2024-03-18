using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellVisualEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        [Cardinality(3)]
        public float[] MissileCastOffset = new float[3]; // MissileCastOffset[3]
        [Cardinality(3)]
        public float[] MissileImpactOffset = new float[3]; // MissileImpactOffset[3]
        public int Flags; // Flags<32>
        public ushort SpellVisualMissileSetID; // SpellVisualMissileSetID<u16>
        public sbyte MissileDestinationAttachment; // MissileDestinationAttachment<8>
        public sbyte MissileAttachment; // MissileAttachment<8>
        public uint MissileCastPositionerID; // MissileCastPositionerID<u32>
        public uint MissileImpactPositionerID; // MissileImpactPositionerID<u32>
        public int MissileTargetingKit; // MissileTargetingKit<32>
        public uint AnimEventSoundID; // AnimEventSoundID<u32>
        public ushort DamageNumberDelay; // DamageNumberDelay<u16>
        public uint HostileSpellVisualID; // HostileSpellVisualID<u32>
        public uint CasterSpellVisualID; // CasterSpellVisualID<u32>
        public uint LowViolenceSpellVisualID; // LowViolenceSpellVisualID<u32>
    }
}
