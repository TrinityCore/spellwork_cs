using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemEffectEntry
    {
        [Index(true)]
        public uint ID;
        public byte LegacySlotIndex;
        public sbyte TriggerType;
        public short Charges;
        public int CoolDownMSec;
        public int CategoryCoolDownMSec;
        public ushort SpellCategoryID;
        public int SpellID;
        public ushort ChrSpecializationID;
        public uint ParentItemID;

        // Helper
        public ItemSparseEntry Item { get; set; }
        public int ItemID { get; set; }
    }
}
