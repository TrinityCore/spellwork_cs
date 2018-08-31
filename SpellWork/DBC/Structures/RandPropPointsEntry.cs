using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class RandPropPointsEntry
    {
        public int DamageReplaceStat;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] Epic;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] Superior;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public uint[] Good;
    }
}
