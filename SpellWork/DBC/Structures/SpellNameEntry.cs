using WDCReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellNameEntry
    {
        [Index]
        public int SpellID;
        public string Name;
    }
}
