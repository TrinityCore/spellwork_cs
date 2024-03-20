using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class ScreenEffectEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public string Name; // Name
        [Cardinality(4)]
        public int[] Param = new int[4]; // Param<32>[4]
        public ushort LightParamsID; // LightParamsID<u16>
        public ushort LightParamsFadeIn; // LightParamsFadeIn<u16>
        public ushort LightParamsFadeOut; // LightParamsFadeOut<u16>
        public short TimeOfDayOverride; // TimeOfDayOverride<16>
        public byte Effect; // Effect<u8>
        public byte LightFlags; // LightFlags<u8>
        public sbyte EffectMask; // EffectMask<8>
        public uint FullScreenEffectID; // FullScreenEffectID<u32>
        public uint SoundAmbienceID; // SoundAmbienceID<u32>
        public uint ZoneMusicID; // ZoneMusicID<u32>
    }
}
