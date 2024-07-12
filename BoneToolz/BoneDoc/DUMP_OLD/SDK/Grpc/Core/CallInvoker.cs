namespace Grpc.Core
{
	public abstract class CallInvoker
	{
		public abstract TResponse BlockingUnaryCall<TResponse, TRequest>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) where TResponse : class where TRequest : class;

		public CallInvoker()
			: base()
		{
		}
	}
}
