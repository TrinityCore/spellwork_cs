using DBFileReaderLib.Attributes;
using System;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellDurationEntry
    {
        [Index(true)]
        public uint ID;
        public int Duration;
        public uint DurationPerLevel;
        public int MaxDuration;
    }
}
