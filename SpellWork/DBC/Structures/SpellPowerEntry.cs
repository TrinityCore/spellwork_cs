using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellPowerEntry
    {
        public int ManaCost; // ManaCost<32>
        public float PowerCostPct; // PowerCostPct
        public float PowerPctPerSecond; // PowerPctPerSecond
        public int RequiredAuraSpellID; // RequiredAuraSpellID<32>
        public float PowerCostMaxPct; // PowerCostMaxPct
        public byte OrderIndex; // OrderIndex<u8>
        public sbyte PowerType; // PowerType<8>
        [Index(false)]
        public int ID; // $id$ID<32>
        public int ManaCostPerLevel; // ManaCostPerLevel<32>
        public int ManaPerSecond; // ManaPerSecond<32>
        public uint OptionalCost; // OptionalCost<u32>
        public uint PowerDisplayID; // PowerDisplayID<u32>
        public int AltPowerBarID; // AltPowerBarID<32>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
