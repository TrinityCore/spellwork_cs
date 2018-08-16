namespace SpellWork.DBC.Structures
{
    public sealed class AreaTableEntry
    {
        public uint ID;
        public string ZoneName;
        public string AreaName;
        public int[] Flags;
        public float AmbientMultiplier;
        public ushort ContinentID;
        public ushort ParentAreaID;
        public short AreaBit;
        public ushort AmbienceID;
        public ushort ZoneMusic;
        public ushort IntroSound;
        public ushort LiquidTypeID[4];
        public ushort UwZoneMusic;
        public ushort UwAmbience;
        public short PvpCombatWorldStateID;
        public byte SoundProviderPref;
        public byte SoundProviderPrefUnderwater;
        public sbyte ExplorationLevel;
        public byte FactionGroupMask;
        public byte MountFlags;
        public byte WildBattlePetLevelMin;
        public byte WildBattlePetLevelMax;
        public byte WindSettingsID;
        public uint UwIntroSound;
    }
}
