using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCategoriesEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public short Category; // Category<16>
        public short StartRecoveryCategory; // StartRecoveryCategory<16>
        public short ChargeCategory; // ChargeCategory<16>
        public byte DifficultyID; // DifficultyID<u8>
        public sbyte DefenseType; // DefenseType<8>
        public sbyte DispelType; // DispelType<8>
        public sbyte Mechanic; // Mechanic<8>
        public sbyte PreventionType; // PreventionType<8>
        public int SpellID; // $noninline,relation$SpellID<32>
    }
}
