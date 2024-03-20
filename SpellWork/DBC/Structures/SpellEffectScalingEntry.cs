using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public class SpellEffectScalingEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public float Coefficient; // Coefficient
        public float Variance; // Variance
        public float ResourceCoefficient; // ResourceCoefficient
        public int SpellEffectID; // SpellEffectID<32>
    }
}
