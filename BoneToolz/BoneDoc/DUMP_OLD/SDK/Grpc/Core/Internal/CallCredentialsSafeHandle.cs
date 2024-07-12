namespace Grpc.Core.Internal
{
	internal class CallCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public CallCredentialsSafeHandle()
			: base()
		{
		}
	}
}
