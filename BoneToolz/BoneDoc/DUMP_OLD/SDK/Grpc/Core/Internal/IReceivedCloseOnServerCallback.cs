namespace Grpc.Core.Internal
{
	internal interface IReceivedCloseOnServerCallback
	{
		void OnReceivedCloseOnServer(bool success, bool cancelled);
	}
}
