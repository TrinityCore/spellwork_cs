namespace SpellWork.DBC.Structures
{
    public class SpellCastingRequirementsEntry
    {
        public uint ID;
        public int SpellID;
        public ushort MinFactionID;
        public ushort RequiredAreasID;
        public ushort RequiresSpellFocus;
        public byte FacingCasterFlags;
        public sbyte MinReputation;
        public byte RequiredAuraVision;
    }
}
