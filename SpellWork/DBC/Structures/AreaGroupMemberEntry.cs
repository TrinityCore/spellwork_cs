using DBFileReaderLib.Attributes;

namespace SpellWork.DBC.Structures
{
    public sealed class AreaGroupMemberEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public ushort AreaID; // AreaID<u16>
        public ushort AreaGroupID; // AreaGroupID<u16>
    };
}
