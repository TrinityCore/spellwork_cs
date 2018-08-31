using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellClassOptionsEntry
    {
        public int SpellID;
        public uint ModalNextSpell;
        public byte SpellClassSet;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] SpellFamilyFlags;
    }
}
