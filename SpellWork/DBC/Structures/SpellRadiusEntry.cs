using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellRadiusEntry
    {
        [Index(true)]
        public int ID;
        public float Radius;
        public float RadiusPerLevel;
        public float RadiusMin;
        public float RadiusMax;
    }
}
