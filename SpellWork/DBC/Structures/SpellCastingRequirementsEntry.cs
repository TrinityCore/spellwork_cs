using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public class SpellCastingRequirementsEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public int SpellID; // SpellID<32>
        public ushort MinFactionID; // MinFactionID<u16>
        public ushort RequiredAreasID; // RequiredAreasID<u16>
        public ushort RequiresSpellFocus; // RequiresSpellFocus<u16>
        public byte FacingCasterFlags; // FacingCasterFlags<u8>
        public sbyte MinReputation; // MinReputation<8>
        public byte RequiredAuraVision; // RequiredAuraVision<u8>
    }
}
