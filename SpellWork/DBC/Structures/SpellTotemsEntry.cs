using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellTotemsEntry
    {
        public int SpellID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] RequiredTotemCategoryID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] Totem;
    }
}
