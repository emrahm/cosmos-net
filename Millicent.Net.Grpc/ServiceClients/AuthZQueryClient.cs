using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class AuthZQueryClient : Cosmos.Authz.V1Beta1.Query.QueryClient
    {
        public AuthZQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthZQueryClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}
