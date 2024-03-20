using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellDurationEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int Duration; // Duration<32>
        public int MaxDuration; // MaxDuration<32>
        public uint DurationPerLevel; // DurationPerLevel<u32>
    }
}
