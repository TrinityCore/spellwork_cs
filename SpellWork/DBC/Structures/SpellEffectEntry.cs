using System.Runtime.InteropServices;
using WDCReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEffectEntry
    {
        [Index]
        public uint ID;
        public int DifficultyID;
        public int EffectIndex;
        public uint Effect;
        public float EffectAmplitude;
        public int EffectAttributes;
        public short EffectAura;
        public int EffectAuraPeriod;
        public float EffectBonusCoefficient;
        public float EffectChainAmplitude;
        public int EffectChainTargets;
        public int EffectItemType;
        public int EffectMechanic;
        public float EffectPointsPerResource;
        public float EffectPosFacing;
        public float EffectRealPointsPerLevel;
        public int EffectTriggerSpell;
        public float BonusCoefficientFromAP;
        public float PvpMultiplier;
        public float Coefficient;
        public float Variance;
        public float ResourceCoefficient;
        public float GroupSizeBasePointsCoefficient;
        public float EffectBasePoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public int[] EffectMiscValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] EffectRadiusIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] EffectSpellClassMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ushort[] ImplicitTarget;
        public int SpellID;

        public string MaxRadius
        {
            get
            {
                if (EffectRadiusIndex[1] == 0 || !DBC.SpellRadius.ContainsKey((int)EffectRadiusIndex[1]))
                    return string.Empty;

                return $"Max Radius (Id {EffectRadiusIndex[1]}) {DBC.SpellRadius[(int)EffectRadiusIndex[1]].Radius:F}" +
                       $" (Min: {DBC.SpellRadius[(int)EffectRadiusIndex[1]].RadiusMin:F} Max: {DBC.SpellRadius[(int)EffectRadiusIndex[1]].MaxRadius:F})";
            }
        }

        public string Radius
        {
            get
            {
                if (EffectRadiusIndex[0] == 0 || !DBC.SpellRadius.ContainsKey((int)EffectRadiusIndex[0]))
                    return string.Empty;

                return $"Radius (Id {EffectRadiusIndex[0]}) {DBC.SpellRadius[(int)EffectRadiusIndex[0]].Radius:F}" +
                       $" (Min: {DBC.SpellRadius[(int)EffectRadiusIndex[0]].RadiusMin:F} Max: {DBC.SpellRadius[(int)EffectRadiusIndex[0]].MaxRadius:F})";
            }
        }
    }
}
