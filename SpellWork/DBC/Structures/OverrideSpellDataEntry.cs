using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class OverrideSpellDataEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        [Cardinality(10)]
        public int[] Spells = new int[10]; // Spells<32>[10]
        public int PlayerActionbarFileDataID; // PlayerActionbarFileDataID<32>
        public byte Flags; // Flags<u8>
    }
}
