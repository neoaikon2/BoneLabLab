namespace Grpc.Core.Internal
{
	internal delegate void BatchCompletionDelegate(bool success, BatchContextSafeHandle ctx, object state);
}
