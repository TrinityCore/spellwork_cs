using WDCReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class ItemEffectEntry
    {
        [Index]
        public int ID;
        public byte LegacySlotIndex;
        public byte TriggerType;
        public short Charges;
        public int CoolDownMSec;
        public int CategoryCoolDownMSec;
        public ushort SpellCategoryID;
        public int SpellID;
        public ushort ChrSpecializationID;
        public int ParentItemID;
    }
}
