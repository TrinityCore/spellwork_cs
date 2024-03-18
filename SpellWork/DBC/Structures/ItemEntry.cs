using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int IconFileDataID; // IconFileDataID<32>
        public byte ClassID; // ClassID<u8>
        public byte SubclassID; // SubclassID<u8>
        public sbyte Sound_override_subclassID; // Sound_override_subclassID<8>
        public byte Material; // Material<u8>
        public byte InventoryType; // InventoryType<u8>
        public byte SheatheType; // SheatheType<u8>
        public byte ItemGroupSoundsID; // ItemGroupSoundsID<u8>
    }
}
