using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellScalingEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        public short ScalesFromItemLevel; // ScalesFromItemLevel<16>
        public int Class; // Class<32>
        public uint MinScalingLevel; // MinScalingLevel<u32>
        public uint MaxScalingLevel; // MaxScalingLevel<u32>
    }
}
