namespace SpellWork.DBC.Structures
{
    public sealed class ItemEffectEntry
    {
        public uint ID;
        public int SpellID;
        public int CoolDownMSec;
        public int CategoryCoolDownMSec;
        public short Charges;
        public ushort SpellCategoryID;
        public ushort ChrSpecializationID;
        public byte LegacySlotIndex;
        public sbyte TriggerType;
        public int ParentItemID;
    }
}
