using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellXSpellVisualEntry
    {
        public uint SpellVisualID; // SpellVisualID<u32>
        public float Probability; // Probability
        public ushort CasterPlayerConditionID; // CasterPlayerConditionID<u16>
        public ushort CasterUnitConditionID; // CasterUnitConditionID<u16>
        public ushort ViewerPlayerConditionID; // ViewerPlayerConditionID<u16>
        public ushort ViewerUnitConditionID; // ViewerUnitConditionID<u16>
        public int SpellIconFileID; // SpellIconFileID<32>
        public int ActiveIconFileID; // ActiveIconFileID<32>
        public byte Flags; // Flags<u8>
        public byte DifficultyID; // DifficultyID<u8>
        public byte Priority; // Priority<u8>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
