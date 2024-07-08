using DBFileReaderLib.Attributes;
using System;

namespace SpellWork.DBC.Structures
{
    public class MapDifficultyEntry : IComparable
    {
        [Index(true)]
        public uint ID;
        public string Message;
        public uint ItemContextPickerID;
        public int ContentTuningID;
        public int ItemContext;
        public byte DifficultyID;
        public byte LockID;
        public byte ResetInterval;
        public byte MaxPlayers;
        public byte Flags;
        public uint MapID;

        public int CompareTo(object obj)
        {
            return obj is MapDifficultyEntry m ? ID.CompareTo(m.ID) : 1;
        }
    }
}
