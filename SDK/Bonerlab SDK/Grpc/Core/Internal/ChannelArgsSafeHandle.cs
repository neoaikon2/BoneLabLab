namespace Grpc.Core.Internal
{
	internal class ChannelArgsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private ChannelArgsSafeHandle()
			: base()
		{
		}

		public static ChannelArgsSafeHandle CreateNull()
		{
			return null;
		}

		public static ChannelArgsSafeHandle Create(int size)
		{
			return null;
		}

		public void SetString(int index, string key, string value)
		{
		}

		public void SetInteger(int index, string key, int value)
		{
		}

		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
