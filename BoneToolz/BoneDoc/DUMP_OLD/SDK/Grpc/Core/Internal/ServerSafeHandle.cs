namespace Grpc.Core.Internal
{
	internal sealed class ServerSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		public void ShutdownAndNotify(BatchCompletionDelegate callback, CompletionQueueSafeHandle completionQueue)
		{
		}

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public void CancelAllCalls()
		{
		}

		public ServerSafeHandle()
			: base()
		{
		}
	}
}
