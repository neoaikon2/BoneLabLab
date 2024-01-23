using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal abstract class AsyncCallBase<TWrite, TRead> : IReceivedMessageCallback, ISendCompletionCallback
	{
		private static readonly ILogger Logger;

		protected static readonly Status DeserializeResponseFailureStatus;

		private readonly Func<TWrite, byte[]> serializer;

		private readonly Func<byte[], TRead> deserializer;

		protected readonly object myLock;

		protected INativeCall call;

		protected bool disposed;

		protected bool started;

		protected bool cancelRequested;

		protected TaskCompletionSource<TRead> streamingReadTcs;

		protected TaskCompletionSource<object> streamingWriteTcs;

		protected bool isStreamingWriteCompletionDelayed;

		protected bool readingDone;

		protected bool halfcloseRequested;

		protected bool finished;

		protected bool initialMetadataSent;

		protected abstract bool IsClient { get; }

		public AsyncCallBase(Func<TWrite, byte[]> serializer, Func<byte[], TRead> deserializer)
			: base()
		{
		}

		public void Cancel()
		{
		}

		protected void CancelWithStatus(Status status)
		{
		}

		protected void InitializeInternal(INativeCall call)
		{
		}

		protected bool ReleaseResourcesIfPossible()
		{
			return default(bool);
		}

		protected abstract Exception GetRpcExceptionClientOnly();

		private void ReleaseResources()
		{
		}

		protected virtual void OnAfterReleaseResources()
		{
		}

		protected byte[] UnsafeSerialize(TWrite msg)
		{
			return null;
		}

		protected Exception TryDeserialize(byte[] payload, [Out] TRead msg)
		{
			return null;
		}

		protected void HandleSendFinished(bool success)
		{
		}

		protected void HandleReadFinished(bool success, byte[] receivedMessage)
		{
		}

		void ISendCompletionCallback.OnSendCompletion(bool success)
		{
		}

		void IReceivedMessageCallback.OnReceivedMessage(bool success, byte[] receivedMessage)
		{
		}
	}
}
