using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellReagentsEntry
    {
        public int SpellID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public int[] Reagent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] ReagentCount;
    }
}
