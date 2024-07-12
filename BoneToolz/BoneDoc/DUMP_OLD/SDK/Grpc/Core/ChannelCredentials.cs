using Grpc.Core.Internal;

namespace Grpc.Core
{
	public abstract class ChannelCredentials
	{
		private sealed class InsecureCredentialsImpl : ChannelCredentials
		{
			internal override ChannelCredentialsSafeHandle ToNativeCredentials()
			{
				return null;
			}

			public InsecureCredentialsImpl()
				: base()
			{
			}
		}

		private static readonly ChannelCredentials InsecureInstance;

		public static ChannelCredentials Insecure
		{
			get
			{
				return null;
			}
		}

		internal abstract ChannelCredentialsSafeHandle ToNativeCredentials();

		public ChannelCredentials()
			: base()
		{
		}
	}
}
