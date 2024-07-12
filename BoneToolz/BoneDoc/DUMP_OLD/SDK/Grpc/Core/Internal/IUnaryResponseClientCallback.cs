namespace Grpc.Core.Internal
{
	internal interface IUnaryResponseClientCallback
	{
		void OnUnaryResponseClient(bool success, ClientSideStatus receivedStatus, byte[] receivedMessage, Metadata responseHeaders);
	}
}
