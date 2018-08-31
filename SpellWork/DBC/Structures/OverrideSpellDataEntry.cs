using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public sealed class OverrideSpellDataEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public int[] Spells;
        public int PlayerActionbarFileDataID;
        public byte Flags;
    }
}
