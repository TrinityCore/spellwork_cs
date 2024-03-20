using DBFileReaderLib.Attributes;
using System.Security.Policy;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellMissileMotionEntry
    {
        [Index(true)]
        public int ID; // $noninline,id$ID<32>
        public string Name; // Name
        public string ScriptBody; // ScriptBody
        public byte Flags; // Flags<u8>
        public byte MissileCount; // MissileCount<u8>
    }
}
