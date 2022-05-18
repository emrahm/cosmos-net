﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class AuthZMsgClient : Cosmos.Authz.V1Beta1.Msg.MsgClient
    {
        public AuthZMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthZMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
