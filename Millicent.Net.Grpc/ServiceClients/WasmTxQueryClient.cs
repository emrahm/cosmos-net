using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class WasmTxQueryClient : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {       
        public WasmTxQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public WasmTxQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
