using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellEquippedItemsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        public int EquippedItemInvTypes; // EquippedItemInvTypes<32>
        public int EquippedItemSubclass; // EquippedItemSubclass<32>
        public sbyte EquippedItemClass; // EquippedItemClass<8>
    }
}
