using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellReagentsEntry
    {
        public uint ID;
        public int SpellID;
        public int Reagent[MAX_SPELL_REAGENTS];
        public short ReagentCount[MAX_SPELL_REAGENTS];
    }
}
