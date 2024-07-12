namespace Grpc.Core.Internal
{
	internal class ChannelSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		public static ChannelSafeHandle CreateInsecure(string target, ChannelArgsSafeHandle channelArgs)
		{
			return null;
		}

		public static ChannelSafeHandle CreateSecure(ChannelCredentialsSafeHandle credentials, string target, ChannelArgsSafeHandle channelArgs)
		{
			return null;
		}

		public CallSafeHandle CreateCall(CallSafeHandle parentCall, ContextPropagationFlags propagationMask, CompletionQueueSafeHandle cq, string method, string host, Timespec deadline, CallCredentialsSafeHandle credentials)
		{
			return null;
		}

		public ChannelState CheckConnectivityState(bool tryToConnect)
		{
			return default(ChannelState);
		}

		public void WatchConnectivityState(ChannelState lastObservedState, Timespec deadline, CompletionQueueSafeHandle cq, BatchCompletionDelegate callback, object callbackState)
		{
		}

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public ChannelSafeHandle()
			: base()
		{
		}
	}
}
