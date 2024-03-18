using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellTargetRestrictionsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public float ConeDegrees; // ConeDegrees
        public float Width; // Width
        public int Targets; // Targets<32>
        public short TargetCreatureType; // TargetCreatureType<16>
        public byte DifficultyID; // DifficultyID<u8>
        public byte MaxTargets; // MaxTargets<u8>
        public uint MaxTargetLevel; // MaxTargetLevel<u32>
        public int  SpellID; // $noninline,relation$SpellID<32>
    }
}
