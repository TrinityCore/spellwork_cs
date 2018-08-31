namespace SpellWork.DBC.Structures
{
    public class SpellCastingRequirementsEntry
    {
        public int SpellID;
        public byte FacingCasterFlags;
        public ushort MinFactionID;
        public sbyte MinReputation;
        public ushort RequiredAreasID;
        public byte RequiredAuraVision;
        public ushort RequiresSpellFocus;
    }
}
