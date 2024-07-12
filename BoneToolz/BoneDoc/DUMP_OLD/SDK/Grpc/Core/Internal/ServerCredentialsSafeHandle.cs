namespace Grpc.Core.Internal
{
	internal class ServerCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public ServerCredentialsSafeHandle()
			: base()
		{
		}
	}
}
