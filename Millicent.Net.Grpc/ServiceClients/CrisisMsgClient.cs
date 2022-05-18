using Grpc.Net.Client;

namespace Millicent.Net.Grpc.ServiceClients
{
    /// <summary>
    /// Cosmos.crisis.v1beta1.tx.proto
    /// </summary>
    public partial class CrisisMsgClient : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {
        public CrisisMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public CrisisMsgClient(GrpcChannel channel) : base(channel)
        {            
        }
    }
}
