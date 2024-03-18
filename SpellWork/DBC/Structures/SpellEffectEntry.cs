using DBFileReaderLib.Attributes;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public class SpellEffectEntry
    {
        [Index(false)]
        public int ID; // $id$ID<32>
        public uint Effect; // Effect<u32>
        public int EffectBasePoints; // EffectBasePoints<32>
        public int EffectIndex; // EffectIndex<32>
        public int EffectAura; // EffectAura<32>
        public int DifficultyID; // DifficultyID<32>
        public float EffectAmplitude; // EffectAmplitude
        public int EffectAuraPeriod; // EffectAuraPeriod<32>
        public float EffectBonusCoefficient; // EffectBonusCoefficient
        public float EffectChainAmplitude; // EffectChainAmplitude
        public int EffectChainTargets; // EffectChainTargets<32>
        public int EffectDieSides; // EffectDieSides<32>
        public int EffectItemType; // EffectItemType<32>
        public int EffectMechanic; // EffectMechanic<32>
        public float EffectPointsPerResource; // EffectPointsPerResource
        public float EffectRealPointsPerLevel; // EffectRealPointsPerLevel
        public int EffectTriggerSpell; // EffectTriggerSpell<32>
        public float EffectPos_facing; // EffectPos_facing
        public int EffectAttributes; // EffectAttributes<32>
        public float BonusCoefficientFromAP; // BonusCoefficientFromAP
        public float PvpMultiplier; // PvpMultiplier
        public float Coefficient; // Coefficient
        public float Variance; // Variance
        public float ResourceCoefficient; // ResourceCoefficient
        public float GroupSizeBasePointsCoefficient; // GroupSizeBasePointsCoefficient
        [Cardinality(4)]
        public int[] EffectSpellClassMask = new int[4]; // EffectSpellClassMask<32>[4]
        [Cardinality(2)]
        public int[] EffectMiscValue = new int[2]; // EffectMiscValue<32>[2]
        [Cardinality(2)]
        public uint[] EffectRadiusIndex = new uint[2]; // EffectRadiusIndex<u32>[2]
        [Cardinality(2)]
        public uint[] ImplicitTarget = new uint[2]; // ImplicitTarget<u32>[2]
        public int SpellID; // $noninline,relation$SpellID<32>

        public SpellEffectScalingEntry SpellEffectScalingEntry { get; set; }

        public string MaxRadius
        {
            get
            {
                if (EffectRadiusIndex[1] == 0 || !DBC.SpellRadius.ContainsKey((int)EffectRadiusIndex[1]))
                    return string.Empty;

                return $"Max Radius (Id {EffectRadiusIndex[1]}) {DBC.SpellRadius[(int)EffectRadiusIndex[1]].Radius:F}" +
                       $" (Min: {DBC.SpellRadius[(int)EffectRadiusIndex[1]].RadiusMin:F} Max: {DBC.SpellRadius[(int)EffectRadiusIndex[1]].RadiusMax:F})";
            }
        }

        public string Radius
        {
            get
            {
                if (EffectRadiusIndex[0] == 0 || !DBC.SpellRadius.ContainsKey((int)EffectRadiusIndex[0]))
                    return string.Empty;

                return $"Radius (Id {EffectRadiusIndex[0]}) {DBC.SpellRadius[(int)EffectRadiusIndex[0]].Radius:F}" +
                       $" (Min: {DBC.SpellRadius[(int)EffectRadiusIndex[0]].RadiusMin:F} Max: {DBC.SpellRadius[(int)EffectRadiusIndex[0]].RadiusMax:F})";
            }
        }
    }
}
