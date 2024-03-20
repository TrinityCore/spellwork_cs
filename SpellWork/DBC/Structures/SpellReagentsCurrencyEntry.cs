using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellReagentsCurrencyEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // $relation$SpellID<32>
        public ushort CurrencyTypesID; // CurrencyTypesID<u16>
        public ushort CurrencyCount; // CurrencyCount<u16>
    }
}
