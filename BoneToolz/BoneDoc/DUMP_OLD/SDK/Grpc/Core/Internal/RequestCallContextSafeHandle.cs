using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class RequestCallContextSafeHandle : SafeHandleZeroIsInvalid, IOpCompletionCallback, IPooledObject<RequestCallContextSafeHandle>, IDisposable
	{
		private static readonly NativeMethods Native;

		private static readonly ILogger Logger;

		private Action<RequestCallContextSafeHandle> returnToPoolAction;

		public RequestCallCompletionDelegate CompletionCallback { get; set; }

		public static RequestCallContextSafeHandle Create()
		{
			return null;
		}

		public void SetReturnToPoolAction(Action<RequestCallContextSafeHandle> returnAction)
		{
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

		public RequestCallContextSafeHandle()
			: base()
		{
		}
	}
}
