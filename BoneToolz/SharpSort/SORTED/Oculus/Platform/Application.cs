using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Application
	{
		public static Request<AppDownloadResult> CancelAppDownload()
		{
			return null;
		}

		public static Request<AppDownloadProgressResult> CheckAppDownloadProgress()
		{
			return null;
		}

		public static Request<ApplicationVersion> GetVersion()
		{
			return null;
		}

		public static Request<AppDownloadResult> InstallAppUpdateAndRelaunch(ApplicationOptions deeplink_options = null)
		{
			return null;
		}

		public static Request<string> LaunchOtherApp(ulong appID, ApplicationOptions deeplink_options = null)
		{
			return null;
		}

		public static Request<AppDownloadResult> StartAppDownload()
		{
			return null;
		}
	}
}
