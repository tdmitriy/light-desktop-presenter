﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace Server.Network.PacketTypes
{
    [ProtoContract]
    class LdpPreparableInfoRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public ConnectionType Type { get; set; }
    }

    enum ConnectionType
    {
        REMOTE_DESKTOP_CONTROL = 1,
        REMOTE_VOLUME_CONTROL = 2,
    }

}
