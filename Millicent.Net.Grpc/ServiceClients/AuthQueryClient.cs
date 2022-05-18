using Grpc.Net.Client;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class AuthQueryClient: Cosmos.Auth.V1Beta1.Query.QueryClient
    {
        public AuthQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthQueryClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}
