using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class AndroidPlatform
	{
		public bool Initialize(string appId)
		{
			return false;
		}

		public Request<PlatformInitialize> AsyncInitialize(string appId)
		{
			return null;
		}
	}
}
