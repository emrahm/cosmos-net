using Google.Protobuf;
using Grpc.Net.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Millicent.Net.Grpc.ServiceClients;

namespace Millicent.Net.Grpc
{
    public partial class MillicentGrpcClient
    {
        public MillicentGrpcClient(MillicentGrpcClientOptions grpcClientOptions)
        {
            BlocksQuery = new(grpcClientOptions);
            Tx = new(grpcClientOptions);
            AuthQuery = new(grpcClientOptions);
            AuthZQuery = new(grpcClientOptions);
            AuthZMessage = new(grpcClientOptions);
            BankQuery = new(grpcClientOptions);
            BankMessage = new(grpcClientOptions);
            DistributionQuery = new(grpcClientOptions);
            EvidenceQuery = new(grpcClientOptions);
            EvidenceMsg = new(grpcClientOptions);
            FeegrantQuery = new(grpcClientOptions);
            FeegrantMsg = new(grpcClientOptions);
            GovMsg = new(grpcClientOptions);
            GovQuery = new(grpcClientOptions);
            MintQuery = new(grpcClientOptions);
            ParamsQuery = new(grpcClientOptions);
            SlashingQuery = new(grpcClientOptions);
            UpgradeQuery = new(grpcClientOptions);
            WasmQuery = new(grpcClientOptions);
        }
        public MillicentGrpcClient(GrpcChannel channel)
        {
            BlocksQuery = new(channel);
            Tx = new(channel);
            AuthQuery = new(channel);
            AuthZQuery = new(channel);
            AuthZMessage = new(channel);
            BankQuery = new(channel);
            BankMessage = new(channel);
            DistributionQuery = new(channel);
            EvidenceQuery = new(channel);
            EvidenceMsg = new(channel);
            FeegrantQuery = new(channel);
            FeegrantMsg = new(channel);
            GovMsg = new(channel);
            GovQuery = new(channel);
            MintQuery = new(channel);
            ParamsQuery = new(channel);
            SlashingQuery = new(channel);
            UpgradeQuery = new(channel);
            WasmQuery = new(channel);
        }
        public readonly BlocksQueryClient BlocksQuery;
        public readonly TxQueryClient Tx;
        public readonly AuthQueryClient AuthQuery;
        public readonly AuthZQueryClient AuthZQuery;
        public readonly AuthZMsgClient AuthZMessage;
        public readonly BankQueryClient BankQuery;
        public readonly BankMsgClient BankMessage;
        public readonly DistributionQueryClient DistributionQuery;
        public readonly EvidenceQueryClient EvidenceQuery;
        public readonly EvidenceMsgClient EvidenceMsg;
        public readonly FeegrantQueryClient FeegrantQuery;
        public readonly FeegrantMsgClient FeegrantMsg;
        public readonly GovMsgClient GovMsg;
        public readonly GovQueryClient GovQuery;
        public readonly MintQueryClient MintQuery;
        public readonly ParamsQueryClient ParamsQuery;
        public readonly SlashingQueryClient SlashingQuery;
        public readonly UpgradeQueryClient UpgradeQuery;
        public readonly WasmTxQueryClient WasmQuery;
    }
}
