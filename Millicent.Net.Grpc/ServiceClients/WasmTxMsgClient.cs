using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class WasmTxMsgClient : Cosmos.Bank.V1Beta1.Msg.MsgClient
    {       
        public WasmTxMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public WasmTxMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
