using WDCReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellEntry
    {
        [Index]
        public int ID;
        public string NameSubtext;
        public string Description;
        public string AuraDescription;

        /*public List<SpellPowerEntry> SpellPowerList
        {
            get
            {
                if (DBC._spellPower.ContainsKey(Id))
                    return DBC._spellPower[Id];
                return null;
            }
        }*/
    }
}
