using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellShapeshiftEntry
    {
        public int SpellID;
        public sbyte StanceBarOrder;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ShapeshiftExclude;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ShapeshiftMask;
    }
}
