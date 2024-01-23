namespace Grpc.Core.Internal
{
	internal interface IReceivedMessageCallback
	{
		void OnReceivedMessage(bool success, byte[] receivedMessage);
	}
}
