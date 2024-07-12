namespace Grpc.Core.Internal
{
	internal class CStringSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}

		public CStringSafeHandle()
			: base()
		{
		}
	}
}
