using Grpc.Net.Client;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class BankQueryClient : Cosmos.Bank.V1Beta1.Query.QueryClient
    {
        public BankQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public BankQueryClient(GrpcChannel channel) : base(channel)
        {            
        }
    }
}
