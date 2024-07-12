using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class AsyncCall<TRequest, TResponse> : AsyncCallBase<TRequest, TResponse>, IUnaryResponseClientCallback, IReceivedStatusOnClientCallback, IReceivedResponseHeadersCallback
	{
		private static readonly ILogger Logger;

		private readonly CallInvocationDetails<TRequest, TResponse> details;

		private readonly INativeCall injectedNativeCall;

		private IDisposable cancellationTokenRegistration;

		private TaskCompletionSource<TResponse> unaryResponseTcs;

		private TaskCompletionSource<object> streamingResponseCallFinishedTcs;

		private TaskCompletionSource<Metadata> responseHeadersTcs;

		private ClientSideStatus? finishedStatus;

		protected override bool IsClient
		{
			get
			{
				return default(bool);
			}
		}

		public AsyncCall(CallInvocationDetails<TRequest, TResponse> callDetails)
			: base(default(System.Func<TRequest, System.Byte[]>), default(System.Func<System.Byte[], TResponse>))
		{
		}

		public TResponse UnaryCall(TRequest msg)
		{
			return (TResponse)default(TResponse);
		}

		protected override void OnAfterReleaseResources()
		{
		}

		protected override Exception GetRpcExceptionClientOnly()
		{
			return null;
		}

		private void Initialize(CompletionQueueSafeHandle cq)
		{
		}

		private INativeCall CreateNativeCall(CompletionQueueSafeHandle cq)
		{
			return null;
		}

		private void RegisterCancellationCallback()
		{
		}

		private WriteFlags GetWriteFlagsForCall()
		{
			return default(WriteFlags);
		}

		private void HandleReceivedResponseHeaders(bool success, Metadata responseHeaders)
		{
		}

		private void HandleUnaryResponse(bool success, ClientSideStatus receivedStatus, byte[] receivedMessage, Metadata responseHeaders)
		{
		}

		private void HandleFinished(bool success, ClientSideStatus receivedStatus)
		{
		}

		void IUnaryResponseClientCallback.OnUnaryResponseClient(bool success, ClientSideStatus receivedStatus, byte[] receivedMessage, Metadata responseHeaders)
		{
		}

		void IReceivedStatusOnClientCallback.OnReceivedStatusOnClient(bool success, ClientSideStatus receivedStatus)
		{
		}

		void IReceivedResponseHeadersCallback.OnReceivedResponseHeaders(bool success, Metadata responseHeaders)
		{
		}
	}
}
