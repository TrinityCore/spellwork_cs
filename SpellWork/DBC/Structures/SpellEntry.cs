using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public string Name_lang; // Name_lang
        public string NameSubtext_lang; // NameSubtext_lang
        public string Description_lang; // Description_lang
        public string AuraDescription_lang; // AuraDescription_lang

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
