namespace Grpc.Core.Internal
{
	internal interface IOpCompletionCallback
	{
		void OnComplete(bool success);
	}
}
