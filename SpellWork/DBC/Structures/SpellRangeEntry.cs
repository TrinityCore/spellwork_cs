using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellRangeEntry
    {
        public string DisplayName;
        public string DisplayNameShort;
        public byte Flags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] MinRange;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] MaxRange;
    }
}
