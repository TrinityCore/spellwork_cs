namespace SpellWork.DBC.Structures
{
    public class SpellInterruptsEntry
    {
        public uint ID;
        public byte DifficultyID;
        public short InterruptFlags;
        public int[] AuraInterruptFlags;
        public int[] ChannelInterruptFlags;
        public int SpellID;
    }
}
