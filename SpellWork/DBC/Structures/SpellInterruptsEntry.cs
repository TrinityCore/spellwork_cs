using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellInterruptsEntry
    {
        public byte Difficulty;
        public short InterruptFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] AuraInterruptFlags;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] ChannelInterruptFlags;
        public int SpellID;
    }
}
