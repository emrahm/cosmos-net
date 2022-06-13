
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
    public class Account
    {
        private readonly MillicentGrpcClient millicentGrpcClient;

        public Account(MillicentGrpcClient millicentGrpcClient)
        {
            this.millicentGrpcClient = millicentGrpcClient;
        }

        public object GetAccounts()
        {
            var queryAccountsRequest = new Cosmos.Auth.V1Beta1.QueryAccountsRequest();
            return millicentGrpcClient.AuthQuery.Accounts(queryAccountsRequest);
        }
 
    }
}
