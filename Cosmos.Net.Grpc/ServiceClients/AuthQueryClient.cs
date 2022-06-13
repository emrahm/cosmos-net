using Grpc.Net.Client;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class AuthQueryClient: Cosmos.Auth.V1Beta1.Query.QueryClient
    {
        public AuthQueryClient(MillicentGrpcClientOptions millicentGrpcClientOptions) : base(GrpcChannel.ForAddress(millicentGrpcClientOptions.BaseAddress, millicentGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public AuthQueryClient(GrpcChannel channel) : base(channel)
        {

        }
    }
}
