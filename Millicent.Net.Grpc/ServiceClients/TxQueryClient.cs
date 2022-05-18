using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Grpc.ServiceClients
{    
    public partial class TxQueryClient : Cosmos.Tx.V1Beta1.Service.ServiceClient
    {       
        public TxQueryClient(MillicentGrpcClientOptions terraGrpcClientOptions) : base(GrpcChannel.ForAddress(terraGrpcClientOptions.BaseAddress, terraGrpcClientOptions.GrpcChannelOptions))
        {
        }

        public TxQueryClient(GrpcChannel channel) : base(channel)
        {
            
        }
    }
}
