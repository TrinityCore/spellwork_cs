using DBFileReaderLib.Attributes;
using System;

namespace SpellWork.DBC.Structures
{
    public class SpellScalingEntry
    {
        [Index(true)]
        public uint ID;
        public int SpellID;
        public int Class;
        public uint MinScalingLevel;
        public uint MaxScalingLevel;
        public short ScalesFromItemLevel;
        public int CastTimeMin;
        public int CastTimeMax;
        public int CastTimeMaxLevel;
        public float NerfFactor;
        public int NerfMaxLevel;
    }
}
