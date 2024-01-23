using Grpc.Core.Internal;

namespace Grpc.Core
{
	public abstract class CallCredentials
	{
		internal abstract CallCredentialsSafeHandle ToNativeCredentials();

		public CallCredentials()
			: base()
		{
		}
	}
}
