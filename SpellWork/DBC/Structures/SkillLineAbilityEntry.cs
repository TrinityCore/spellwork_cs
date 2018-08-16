namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineAbilityEntry
    {
        public long RaceMask;
        public uint ID;
        public int Spell;
        public int SupercedesSpell;
        public short SkillLine;
        public short TrivialSkillLineRankHigh;
        public short TrivialSkillLineRankLow;
        public short UniqueBit;
        public short TradeSkillCategoryID;
        public sbyte NumSkillUps;
        public int ClassMask;
        public short MinSkillLineRank;
        public sbyte AcquireMethod;
        public sbyte Flags;
    }
}
