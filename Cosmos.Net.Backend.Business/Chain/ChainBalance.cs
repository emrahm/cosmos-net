
using Cosmos.Bank.V1Beta1;
using Cosmos.Base.V1Beta1;
using Grpc.Net.Client;
using Millicent.Net.Grpc;
using Millicent.Net.Grpc.ServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Backend.Business.Chain
{
    public class ChainBalance
    {
        private readonly MillicentGrpcClient millicentGrpcClient;

        public ChainBalance(MillicentGrpcClient millicentGrpcClient)
        {
            this.millicentGrpcClient = millicentGrpcClient;
        }

        public Object GetBalance(string address)
        {
            return millicentGrpcClient.BankQuery.Balance(new QueryBalanceRequest() { Denom="milli", Address = address }); 
        }
    }
}
