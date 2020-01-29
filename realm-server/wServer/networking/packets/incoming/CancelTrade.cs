﻿using common;

namespace wServer.networking.packets.incoming
{
    public class CancelTrade : IncomingMessage
    {
        public override PacketId GetPacketId => PacketId.CANCELTRADE;
        public override Packet CreateInstance() { return new CancelTrade(); }

        protected override void Read(NReader rdr) { }

        protected override void Write(NWriter wtr) { }
    }
}
