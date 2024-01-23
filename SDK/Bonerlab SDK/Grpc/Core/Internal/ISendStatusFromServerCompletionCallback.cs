namespace Grpc.Core.Internal
{
	internal interface ISendStatusFromServerCompletionCallback
	{
		void OnSendStatusFromServerCompletion(bool success);
	}
}
