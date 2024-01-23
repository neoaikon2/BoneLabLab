using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Interceptors;

namespace Grpc.Core
{
	public abstract class ClientBase<T> : ClientBase where T : ClientBase<T>
	{
		public ClientBase(Channel channel)
			: base(channel)
		{
		}
	}
	public abstract class ClientBase
	{
		protected internal class ClientBaseConfiguration
		{
			private class ClientBaseConfigurationInterceptor : Interceptor
			{
				private readonly Func<IMethod, string, CallOptions, Tuple<string, CallOptions>> interceptor;

				public ClientBaseConfigurationInterceptor(Func<IMethod, string, CallOptions, Tuple<string, CallOptions>> interceptor)
					: base()
				{
				}

				private ClientInterceptorContext<TRequest, TResponse> GetNewContext<TRequest, TResponse>(ClientInterceptorContext<TRequest, TResponse> context) where TRequest : class where TResponse : class
				{
					return default(ClientInterceptorContext<TRequest, TResponse>);
				}

				public override TResponse BlockingUnaryCall<TResponse, TRequest>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
				{
					return null;
				}
			}

			private readonly CallInvoker undecoratedCallInvoker;

			private readonly string host;

			internal ClientBaseConfiguration(CallInvoker undecoratedCallInvoker, string host)
				: base()
			{
			}

			internal CallInvoker CreateDecoratedCallInvoker()
			{
				return null;
			}
		}

		private readonly ClientBaseConfiguration configuration;

		private readonly CallInvoker callInvoker;

		protected CallInvoker CallInvoker
		{
			get
			{
				return null;
			}
		}

		protected ClientBase(ClientBaseConfiguration configuration)
			: base()
		{
		}

		public ClientBase(Channel channel)
			: base()
		{
		}

		public ClientBase(CallInvoker callInvoker)
			: base()
		{
		}
	}
}
