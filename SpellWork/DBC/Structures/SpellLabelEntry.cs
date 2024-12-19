using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellLabelEntry
    {
        [Index(true)]
        public uint ID;
        public uint LabelID;
        [NonInlineRelation(typeof(uint))]
        public int SpellID;
    }
}
