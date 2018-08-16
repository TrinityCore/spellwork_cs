namespace SpellWork.DBC.Structures
{
    public sealed class OverrideSpellDataEntry
    {
        public uint ID;
        public int Spells[MAX_OVERRIDE_SPELL];
        public int PlayerActionBarFileDataID;
        public byte Flags;
    }
}
