using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class AreaTableEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public string ZoneName; // ZoneName
        public string AreaName_lang; // AreaName_lang
        [Cardinality(2)]
        public int[] Flags = new int[2]; // Flags<32>[2]
        public float Ambient_multiplier; // Ambient_multiplier
        public ushort ContinentID; // ContinentID<u16>
        public ushort ParentAreaID; // ParentAreaID<u16>
        public short AreaBit; // AreaBit<16>
        public ushort AmbienceID; // AmbienceID<u16>
        public ushort ZoneMusic; // ZoneMusic<u16>
        public ushort IntroSound; // IntroSound<u16>
        [Cardinality(4)]
        public ushort[] LiquidTypeID = new ushort[4]; // LiquidTypeID<u16>[4]
        public ushort UwZoneMusic; // UwZoneMusic<u16>
        public ushort UwAmbience; // UwAmbience<u16>
        public short PvpCombatWorldStateID; // PvpCombatWorldStateID<16>
        public byte SoundProviderPref; // SoundProviderPref<u8>
        public byte SoundProviderPrefUnderwater; // SoundProviderPrefUnderwater<u8>
        public sbyte ExplorationLevel; // ExplorationLevel<8>
        public byte FactionGroupMask; // FactionGroupMask<u8>
        public byte MountFlags; // MountFlags<u8>
        public byte WildBattlePetLevelMin; // WildBattlePetLevelMin<u8>
        public byte WildBattlePetLevelMax; // WildBattlePetLevelMax<u8>
        public byte WindSettingsID; // WindSettingsID<u8>
        public uint UwIntroSound; // UwIntroSound<u32>
    }
}
