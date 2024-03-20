using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellMissileEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        public float DefaultPitchMin; // DefaultPitchMin
        public float DefaultPitchMax; // DefaultPitchMax
        public float DefaultSpeedMin; // DefaultSpeedMin
        public float DefaultSpeedMax; // DefaultSpeedMax
        public float RandomizeFacingMin; // RandomizeFacingMin
        public float RandomizeFacingMax; // RandomizeFacingMax
        public float RandomizePitchMin; // RandomizePitchMin
        public float RandomizePitchMax; // RandomizePitchMax
        public float RandomizeSpeedMin; // RandomizeSpeedMin
        public float RandomizeSpeedMax; // RandomizeSpeedMax
        public float Gravity; // Gravity
        public float MaxDuration; // MaxDuration
        public float CollisionRadius; // CollisionRadius
        public byte Flags; // Flags<u8>
    }
}
