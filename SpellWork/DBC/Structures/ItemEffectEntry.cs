using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemEffectEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        public int CoolDownMSec; // CoolDownMSec<32>
        public int CategoryCoolDownMSec; // CategoryCoolDownMSec<32>
        public short Charges; // Charges<16>
        public ushort SpellCategoryID; // SpellCategoryID<u16>
        public ushort ChrSpecializationID; // ChrSpecializationID<u16>
        public byte LegacySlotIndex; // LegacySlotIndex<u8>
        public sbyte TriggerType; // TriggerType<8>
        public int ParentItemID; // $noninline,relation$ParentItemID<32>
    }
}
