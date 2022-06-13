using Cosmos.Base.V1Beta1;
using Cosmos.Crypto.Secp256K1;
using Cosmos.Tx.V1Beta1;
using Cosmwasm.Wasm.V1;
using Google.Protobuf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cosmos.Tx.V1Beta1.ModeInfo;



namespace Millicent.Net.Backend.Business.Extension
{
    public static class MessageExtensions
    {
        public const string MsgExecuteContact = "/cosmwasm.wasm.v1beta1.MsgExecuteContract";
        public const string PubKeySecp256k1 = "/cosmos.crypto.secp256k1.PubKey";

        public static BroadcastTxRequest CreateBroadcast(TxRaw tx)
        {
            BroadcastTxRequest request = new BroadcastTxRequest() { TxBytes = tx.ToByteString(), Mode = BroadcastMode.Sync };
            return request;
        }

        public static Coin GenerateCoin(ulong amount, string denom)
        {
            var c = new Coin() { Amount = amount.ToString(), Denom = denom };
            return c;
        }

        public static MsgExecuteContract CreateExecuteContractMessage<TExecuteMessage>(TExecuteMessage executeMessage, string sender, string contract, IEnumerable<Coin>? coins = default, JsonConverter? converter = null)
        {
            var msg = new MsgExecuteContract()
            {
                //ExecuteMsg = ByteString.CopyFromUtf8(JsonConvert.SerializeObject(executeMessage)),
                Contract = contract,
                Sender = sender,
            };
            //if (coins != default && coins.Any())
            //    msg.Coins.AddRange(coins);
            return msg;
        }
        public static SignerInfo GenerateSignerInfo(ulong sequence, byte[] publicKey)
        {
            var signerInfo = new SignerInfo()
            {
                Sequence = sequence,
                ModeInfo = new ModeInfo()
                {
                    Single = new Types.Single() { Mode = Cosmos.Tx.Signing.V1Beta1.SignMode.Direct },
                },
                PublicKey = new PubKey() { Key = ByteString.CopyFrom(publicKey) }.ToAny(PubKeySecp256k1)
            };


            return signerInfo;
        }

        public static AuthInfo GenerateAuthInfo(Fee fee, params SignerInfo[] signerInfos)
        {
            var authInfo = new AuthInfo() { Fee = fee };
            foreach (SignerInfo signerInfo in signerInfos)
                authInfo.SignerInfos.Add(signerInfo);

            return authInfo;
        }
        public static AuthInfo GenerateAuthInfo(Fee fee, SignerInfo signerInfo)
        {
            var authInfo = new AuthInfo() { Fee = fee };
            authInfo.SignerInfos.Add(signerInfo);
            return authInfo;
        }
        public static TxRaw CreateRawTx(ByteString body, ByteString auth, params ByteString[] signatures)
        {
            var tx = new TxRaw() { AuthInfoBytes = auth, BodyBytes = body };
            tx.Signatures.AddRange(signatures);
            return tx;
        }

        public static TxBody ToTxBody(this MsgExecuteContract executeContract, string? memo = null, ulong? timeoutHeight = null)
        {
            var singleMessage = new Dictionary<string, IMessage>() { { MsgExecuteContact, executeContract } };
            return singleMessage.ToTxBody(memo, timeoutHeight);
        }
        /*In order to sign in the default mode, clients take the following steps:

Serialize TxBody and AuthInfo using any valid protobuf implementation.
Create a SignDoc and serialize it using ADR 027.
Sign the encoded SignDoc bytes.
Build a TxRaw and serialize it for broadcasting.*/
        public static SignDoc CreateSignDoc(TxBody txBody, AuthInfo infoes, string chainId, ulong accountNumber)
        {
            return new SignDoc()
            {
                AccountNumber = accountNumber,
                AuthInfoBytes = infoes.ToByteString(),
                BodyBytes = txBody.ToByteString(),
                ChainId = chainId,
            };
        }
        public static TxBody ToTxBody(this Dictionary<string, IMessage> messages, string? memo = null, ulong? timeoutHeight = null)
        {
            TxBody body = new TxBody();
            if (memo != null)
            {
                body.Memo = memo;
            }
            if (timeoutHeight.HasValue)
            {
                body.TimeoutHeight = timeoutHeight.Value;
            }
            body.Messages.AddRange(messages.Select(c => c.Key.ToAny(c.Value)));

            return body;
        }
        public static TxBody ToTxBody(this Dictionary<string, byte[]> messages, string? memo = null, ulong? timeoutHeight = null)
        {
            TxBody body = new TxBody();
            if (memo != null)
            {
                body.Memo = memo;
            }
            if (timeoutHeight.HasValue)
            {
                body.TimeoutHeight = timeoutHeight.Value;
            }
            body.Messages.AddRange(messages.Select(c => c.Key.ToAny(c.Value)));
            return body;
        }
    }
}