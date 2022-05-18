
using Cosmos.Bank.V1Beta1;
using Cosmos.Base.V1Beta1;
using Grpc.Net.Client;
using Millicent.Net.Grpc.ServiceClients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Millicent.Net.Backend.Business.Wallet
{
    public class ChainBalance
    {
        public Coin GetBalance(string address)
        {
            BankQueryClient bankQueryClient = new BankQueryClient(GrpcChannel.ForAddress("http://158.175.120.248:26657"));
            var response = bankQueryClient.Balance(new QueryBalanceRequest() { Address = address });
            return response.Balance;
        }
    }
}
