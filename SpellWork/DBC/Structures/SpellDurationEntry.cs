using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellDurationEntry
    {
        [Index(true)]
        public uint ID;
        public int Duration;
        public int MaxDuration;
    }
}
