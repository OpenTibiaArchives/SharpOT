﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpOT.Packets
{
    public class VipLogoutPacket:Packet
    {
        public static void Add(NetworkMessage message,uint id)
        {
            message.AddUInt32(id);
        }
    }
}