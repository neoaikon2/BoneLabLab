namespace Grpc.Core.Internal
{
	internal interface ISendCompletionCallback
	{
		void OnSendCompletion(bool success);
	}
}
