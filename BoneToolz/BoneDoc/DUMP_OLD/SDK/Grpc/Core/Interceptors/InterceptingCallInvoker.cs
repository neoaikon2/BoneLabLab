using System.Runtime.CompilerServices;

namespace Grpc.Core.Interceptors
{
	internal class InterceptingCallInvoker : CallInvoker
	{
		private readonly CallInvoker invoker;

		private readonly Interceptor interceptor;

		public InterceptingCallInvoker(CallInvoker invoker, Interceptor interceptor)
			: base()
		{
		}

		public override TResponse BlockingUnaryCall<TResponse, TRequest>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			return null;
		}
	}
}
