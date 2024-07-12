using System.ComponentModel;

namespace Oculus.Platform
{
	public enum AppStatus
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("ENTITLED")]
		Entitled = 1,
		[Description("DOWNLOAD_QUEUED")]
		DownloadQueued = 2,
		[Description("DOWNLOADING")]
		Downloading = 3,
		[Description("INSTALLING")]
		Installing = 4,
		[Description("INSTALLED")]
		Installed = 5,
		[Description("UNINSTALLING")]
		Uninstalling = 6
	}
}
