using Grpc.Net.Client;

namespace Millicent.Net.Grpc
{

    public partial class MillicentGrpcClientOptions
    {
        public readonly string BaseAddress;
        public readonly GrpcChannelOptions GrpcChannelOptions;

        public MillicentGrpcClientOptions(string baseAddress)
        {
            BaseAddress = baseAddress;
            GrpcChannelOptions = new GrpcChannelOptions() { MaxReceiveMessageSize = 25 * 1024 * 1024 };
        }

        public MillicentGrpcClientOptions(string baseAddress, HttpClient httpClient)
        {
            BaseAddress = baseAddress;

            GrpcChannelOptions = new GrpcChannelOptions() { MaxReceiveMessageSize = 25 * 1024 * 1024, HttpClient = httpClient };

        }
        public MillicentGrpcClientOptions(string baseAddress, GrpcChannelOptions options)
        {
            BaseAddress = baseAddress;
            GrpcChannelOptions = options;
        }
    }


}