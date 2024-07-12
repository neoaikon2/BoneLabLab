using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class BatchContextSafeHandle : SafeHandleZeroIsInvalid, IOpCompletionCallback, IPooledObject<BatchContextSafeHandle>, IDisposable
	{
		private struct CompletionCallbackData
		{
			public BatchCompletionDelegate Callback { get; }

			public object State { get; }

			public CompletionCallbackData(BatchCompletionDelegate callback, object state)
			{
				this.State = default(object);
				this.Callback = default(BatchCompletionDelegate);
			}
		}

		private static readonly NativeMethods Native;

		private static readonly ILogger Logger;

		private Action<BatchContextSafeHandle> returnToPoolAction;

		private CompletionCallbackData completionCallbackData;

		public IntPtr Handle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static BatchContextSafeHandle Create()
		{
			return null;
		}

		public void SetReturnToPoolAction(Action<BatchContextSafeHandle> returnAction)
		{
		}

		public void SetCompletionCallback(BatchCompletionDelegate callback, object state)
		{
		}

		public Metadata GetReceivedInitialMetadata()
		{
			return null;
		}

		public ClientSideStatus GetReceivedStatusOnClient()
		{
			return default(ClientSideStatus);
		}

		public byte[] GetReceivedMessage()
		{
			return null;
		}

		public bool GetReceivedCloseOnServerCancelled()
		{
			return default(bool);
		}

		public void Recycle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		void IOpCompletionCallback.OnComplete(bool success)
		{
		}

		public BatchContextSafeHandle()
			: base()
		{
		}
	}
}
