using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class DistributionMsgClient : Cosmos.Distribution.V1Beta1.Query.QueryClient
    {       
        public DistributionMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public DistributionMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
