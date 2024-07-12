namespace Grpc.Core.Internal
{
	internal interface IReceivedResponseHeadersCallback
	{
		void OnReceivedResponseHeaders(bool success, Metadata responseHeaders);
	}
}
