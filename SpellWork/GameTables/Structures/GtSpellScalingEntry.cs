namespace SpellWork.GameTables.Structures
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class GtSpellScalingEntry : GameTableRecord
    {
        // ReSharper disable MemberCanBePrivate.Global
        public uint ID;
        public float Rogue;
        public float Druid;
        public float Hunter;
        public float Mage;
        public float Paladin;
        public float Priest;
        public float Shaman;
        public float Warlock;
        public float Warrior;
        public float DeathKnight;
        public float Monk;
        public float DemonHunter;
        public float Item;
        public float Consumable;
        public float Gem1;
        public float Gem2;
        public float Gem3;
        public float Health;
        public float DamageReplaceStat;
        // ReSharper restore MemberCanBePrivate.Global

        public float GetColumnForClass(int scalingClass)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (scalingClass)
            {
                case 1: return Warrior;
                case 2: return Paladin;
                case 3: return Hunter;
                case 4: return Rogue;
                case 5: return Priest;
                case 6: return DeathKnight;
                case 7: return Shaman;
                case 8: return Mage;
                case 9: return Warlock;
                case 10: return Monk;
                case 11: return Druid;
                case 12: return DemonHunter;
                case -1: return Item;
                case -2: return Consumable;
                case -3: return Gem1;
                case -4: return Gem2;
                case -5: return Gem3;
                case -6: return Health;
                case -7: return DamageReplaceStat;
                default:
                    break;
            }
            return 0.0f; // Shut up, compiler
        }
    }
}
