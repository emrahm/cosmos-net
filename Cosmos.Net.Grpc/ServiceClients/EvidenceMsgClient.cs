using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{
    public partial class EvidenceMsgClient : Cosmos.Evidence.V1Beta1.Msg.MsgClient
    {       
        public EvidenceMsgClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public EvidenceMsgClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
