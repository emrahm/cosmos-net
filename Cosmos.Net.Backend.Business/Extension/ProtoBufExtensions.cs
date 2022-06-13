using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Millicent.Net.Backend.Business.Extension
{
    public static class ProtoBufExtensions
    {
        public static Any ToAny(this string typeUrl, IMessage protoMessage) => new Any() { TypeUrl = typeUrl, Value = ByteString.CopyFrom(protoMessage.ToByteArray()) };
        public static Any ToAny(this string typeUrl, byte[] protoMessageSerialized) => new Any() { TypeUrl = typeUrl, Value = ByteString.CopyFrom(protoMessageSerialized) };
        public static Any ToAny(this IMessage protoMessage, string typeUrl) => new Any() { TypeUrl = typeUrl, Value = ByteString.CopyFrom(protoMessage.ToByteArray()) };

    }
}