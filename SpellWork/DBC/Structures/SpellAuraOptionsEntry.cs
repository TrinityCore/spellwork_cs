using System.Runtime.InteropServices;

namespace SpellWork.DBC.Structures
{
    public class SpellAuraOptionsEntry
    {
        public byte DifficultyID;
        public ushort CumulativeAura;
        public int ProcCategoryRecovery;
        public byte ProcChance;
        public int ProcCharges;
        public ushort SpellProcsPerMinuteID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] ProcTypeMask;
        public int SpellID;
    }
}
