namespace Grpc.Core
{
	public struct CallInvocationDetails<TRequest, TResponse>
	{
		private readonly Channel channel;

		private readonly string method;

		private readonly string host;

		private readonly Marshaller<TRequest> requestMarshaller;

		private readonly Marshaller<TResponse> responseMarshaller;

		private CallOptions options;

		public Channel Channel
		{
			get
			{
				return null;
			}
		}

		public string Method
		{
			get
			{
				return null;
			}
		}

		public string Host
		{
			get
			{
				return null;
			}
		}

		public Marshaller<TRequest> RequestMarshaller
		{
			get
			{
				return null;
			}
		}

		public Marshaller<TResponse> ResponseMarshaller
		{
			get
			{
				return null;
			}
		}

		public CallOptions Options
		{
			get
			{
				return default(CallOptions);
			}
		}

		public CallInvocationDetails(Channel channel, Method<TRequest, TResponse> method, string host, CallOptions options)
		{
			this.options = default(CallOptions);
			this.responseMarshaller = default(Marshaller<TResponse>);
			this.requestMarshaller = default(Marshaller<TRequest>);
			this.host = default(string);
			this.method = default(string);
			this.channel = default(Channel);
		}

		public CallInvocationDetails(Channel channel, string method, string host, Marshaller<TRequest> requestMarshaller, Marshaller<TResponse> responseMarshaller, CallOptions options)
		{
			this.options = default(CallOptions);
			this.responseMarshaller = default(Marshaller<TResponse>);
			this.requestMarshaller = default(Marshaller<TRequest>);
			this.host = default(string);
			this.method = default(string);
			this.channel = default(Channel);
		}

		public CallInvocationDetails<TRequest, TResponse> WithOptions(CallOptions options)
		{
			return default(CallInvocationDetails<TRequest, TResponse>);
		}
	}
}
