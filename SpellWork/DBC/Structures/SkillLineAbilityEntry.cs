using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineAbilityEntry
    {
        public long RaceMask; // RaceMask<64>
        [Index(true)]
        public int ID; // $id$ID<32>
        public int Spell; // Spell<32>
        public int SupercedesSpell; // SupercedesSpell<32>
        public short SkillLine; // $relation$SkillLine<16>
        public short TrivialSkillLineRankHigh; // TrivialSkillLineRankHigh<16>
        public short TrivialSkillLineRankLow; // TrivialSkillLineRankLow<16>
        public short UniqueBit; // UniqueBit<16>
        public short TradeSkillCategoryID; // TradeSkillCategoryID<16>
        public sbyte NumSkillUps; // NumSkillUps<8>
        public int   ClassMask; // ClassMask<32>
        public short MinSkillLineRank; // MinSkillLineRank<16>
        public sbyte AcquireMethod; // AcquireMethod<8>
        public sbyte Flags; // Flags<8>
    }
}
