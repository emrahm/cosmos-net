
using Cosmos.Bank.V1Beta1;
using Cosmos.Base.V1Beta1;
using Cosmos.Tx.V1Beta1;
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
    public class Transaction
    {
        private readonly MillicentGrpcClient millicentGrpcClient;

        public Transaction(MillicentGrpcClient millicentGrpcClient)
        {
            this.millicentGrpcClient = millicentGrpcClient;
        }

        public Object Send(string address)
        {
            //create a new connection
            var simulateRequest = new SimulateRequest(); 
            var msgSend = new MsgSend(); 
            msgSend.FromAddress = "";
            millicentGrpcClient.BankMessage.Send(msgSend);
            
            //create and use a user account name like alice or bob.


            //create a POST
            // TxRaw txRaw = new TxRaw();
            // txRaw.AuthInfoBytes = null;
            // txRaw.Signatures.Add();
            //braodcast 
            // var broadcastTxRequest = new Cosmos.Tx.V1Beta1.BroadcastTxRequest(); 

            //millicentGrpcClient.Tx.BroadcastTx(broadcastTxRequest);
            //Display

            // var amount = new Google.Protobuf.Collections.RepeatedField<Coin>() { new Coin{ Denom="milli", Amount="1200000" }};
            // MsgSend msgSend = new MsgSend
            // {
            //     FromAddress = "",
            //     ToAddress=""
            // };
           // return millicentGrpcClient.BankMessage.Send(msgSend);
           return null;
        }
    }
}
