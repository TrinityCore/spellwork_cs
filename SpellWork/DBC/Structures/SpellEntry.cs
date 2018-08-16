namespace SpellWork.DBC.Structures
{
    public sealed class SpellEntry
    {
        public uint ID;
        public int SpellID;
        public int LearnSpellID;
        public int OverridesSpellID;

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
