namespace Grpc.Core.Interceptors
{
	public abstract class Interceptor
	{
		public delegate TResponse BlockingUnaryCallContinuation<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context) where TRequest : class where TResponse : class;

		public virtual TResponse BlockingUnaryCall<TResponse, TRequest>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation) where TResponse : class where TRequest : class
		{
			return null;
		}

		public Interceptor()
			: base()
		{
		}
	}
}
