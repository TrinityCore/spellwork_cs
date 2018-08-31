using System.Runtime.InteropServices;
using WDCReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellMiscEntry
    {
        [Index]
        public int ID;
        public byte DifficultyID;
        public ushort CastingTimeIndex;
        public ushort DurationIndex;
        public ushort RangeIndex;
        public byte SchoolMask;
        public float Speed;
        public float LaunchDelay;
        public float Field_1532576006;
        public int SpellIconFileDataID;
        public int ActiveIconFileDataID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public int[] Attributes;
        public int SpellID;
    }
}
