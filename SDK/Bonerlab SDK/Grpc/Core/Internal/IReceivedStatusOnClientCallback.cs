namespace Grpc.Core.Internal
{
	internal interface IReceivedStatusOnClientCallback
	{
		void OnReceivedStatusOnClient(bool success, ClientSideStatus receivedStatus);
	}
}
