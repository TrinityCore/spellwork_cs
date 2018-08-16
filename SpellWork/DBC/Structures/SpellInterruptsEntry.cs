namespace SpellWork.DBC.Structures
{
    public class SpellInterruptsEntry
    {
        public uint ID;
        public byte DifficultyID;
        public short InterruptFlags;
        public int AuraInterruptFlags[MAX_SPELL_AURA_INTERRUPT_FLAGS];
        public int ChannelInterruptFlags[MAX_SPELL_AURA_INTERRUPT_FLAGS];
        public int SpellID;
    }
}
