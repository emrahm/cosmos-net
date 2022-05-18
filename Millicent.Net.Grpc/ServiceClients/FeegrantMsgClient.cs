using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class FeegrantMsgClient : Cosmos.Feegrant.V1Beta1.Msg.MsgClient
    {       
        public FeegrantMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public FeegrantMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
