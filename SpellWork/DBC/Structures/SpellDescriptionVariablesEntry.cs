using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellDescriptionVariablesEntry
    {
        [Index(true)]
        public int ID;
        public string Variables;
    }
}
