using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCategoriesEntry
    {
        [Index(true)]
        public uint ID;
        public byte DifficultyID;
        public short Category;
        public sbyte DefenseType;
        public sbyte DispelType;
        public sbyte Mechanic;
        public sbyte PreventionType;
        public short StartRecoveryCategory;
        public short ChargeCategory;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
