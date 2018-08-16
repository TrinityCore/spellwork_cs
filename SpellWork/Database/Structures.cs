using System.Globalization;

namespace SpellWork.Database
{
    public sealed class SpellProcEventEntry
    {
        public int SpellID;
        public byte SchoolMask;
        public short SpellFamilyName;
        public int[] SpellFamilyMask;
        public int ProcFlags;
        public int SpellTypeMask;
        public int SpellPhaseMask;
        public int HitMask;
        public int AttributesMask;
        public float ProcsPerMinute;
        public float Chance;
        public int Cooldown;
        public byte Charges;

        public string[] ToArray()
        {
            return new[]
            {
                SpellID.ToString(),
                SchoolMask.ToString(),
                SpellFamilyName.ToString(),
                SpellFamilyMask[0].ToString(),
                SpellFamilyMask[1].ToString(),
                SpellFamilyMask[2].ToString(),
                SpellFamilyMask[3].ToString(),
                ProcFlags.ToString(),
                SpellTypeMask.ToString(),
                SpellPhaseMask.ToString(),
                HitMask.ToString(),
                AttributesMask.ToString(),
                ProcsPerMinute.ToString(CultureInfo.InvariantCulture),
                Chance.ToString(CultureInfo.InvariantCulture),
                Cooldown.ToString(),
                Charges.ToString()
            };
        }
    }
}
