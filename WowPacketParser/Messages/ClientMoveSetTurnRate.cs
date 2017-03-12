using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientMoveSetTurnRate
    {
        public ulong MoverGUID;
        public uint SequenceIndex;
        public float Speed;
    }
}