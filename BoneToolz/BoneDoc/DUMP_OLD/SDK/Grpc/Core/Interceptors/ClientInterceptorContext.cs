using System.Runtime.CompilerServices;

namespace Grpc.Core.Interceptors
{
	public struct ClientInterceptorContext<TRequest, TResponse> where TRequest : class where TResponse : class
	{
		public Method<TRequest, TResponse> Method { get; }

		public string Host { get; }

		public CallOptions Options { get; }

		public ClientInterceptorContext(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			this.Options = default(CallOptions);
			this.Host = default(string);
			this.Method = default(Method<TRequest, TResponse>);
		}
	}
}
