using DBFileReaderLib.Attributes;
using System;

namespace SpellWork.DBC.Structures
{
    public class MapEntry : IComparable
    {
        [Index(true)]
        public uint ID;
        public string Directory;
        public string MapName;
        public string InternalName;
        public string MapDescription0;
        public string MapDescription1;
        public string PvpShortDescription;
        public string PvpLongDescription;
        [Cardinality(2)]
        public float[] Corpse = new float[2];
        public byte MapType;
        public sbyte InstanceType;
        public byte ExpansionID;
        public ushort AreaTableID;
        public short LoadingScreenID;
        public short TimeOfDayOverride;
        public short ParentMapID;
        public short CosmeticParentMapID;
        public byte TimeOffset;
        public float MinimapIconScale;
        public short CorpseMapID;
        public byte MaxPlayers;
        public short WindSettingsID;
        public int ZmpFileDataID;
        public int WdtFileDataID;
        [Cardinality(2)]
        public uint[] Flags = new uint[2];

        public int CompareTo(object obj)
        {
            return obj is MapEntry m ? ID.CompareTo(m.ID) : 1;
        }
    }
}
