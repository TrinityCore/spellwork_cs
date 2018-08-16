namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        public uint ID;
        public string DisplayName;
        public string DisplayNameShort;
        public float RangeMin[2];
        public float RangeMax[2];
        public byte Flags;
    }
}
