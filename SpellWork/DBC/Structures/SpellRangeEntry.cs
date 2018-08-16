namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        public uint ID;
        public string DisplayName;
        public string DisplayNameShort;
        public float[] RangeMin;
        public float[] RangeMax;
        public byte Flags;
    }
}
