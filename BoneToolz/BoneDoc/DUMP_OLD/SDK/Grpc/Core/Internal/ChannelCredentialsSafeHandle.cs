namespace Grpc.Core.Internal
{
	internal class ChannelCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public ChannelCredentialsSafeHandle()
			: base()
		{
		}
	}
}
