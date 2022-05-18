﻿using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class ParamsQueryClient : Cosmos.Params.V1Beta1.Query.QueryClient
    {       
        public ParamsQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public ParamsQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
