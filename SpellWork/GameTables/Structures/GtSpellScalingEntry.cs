namespace SpellWork.GameTables.Structures
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class GtSpellScalingEntry : GameTableRecord
    {
        // ReSharper disable MemberCanBePrivate.Global
        public uint ID;
        public float Warrior;
        public float Paladin;
        public float Hunter;
        public float Rogue;
        public float Priest;
        public float DeathKnight;
        public float Shaman;
        public float Mage;
        public float Warlock;
        public float Monk;
        public float Druid;
        public float Item;
        public float Consumable;
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
                case -1: return Item;
                case -2: return Consumable;
                case -7: return Item;
                default:
                    break;
            }
            return 0.0f; // Shut up, compiler
        }
    }
}
