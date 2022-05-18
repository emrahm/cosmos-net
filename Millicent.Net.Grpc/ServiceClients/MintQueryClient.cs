﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class MintQueryClient : Cosmos.Mint.V1Beta1.Query.QueryClient
    {       
        public MintQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public MintQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
