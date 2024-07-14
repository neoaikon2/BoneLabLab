using System;

namespace Oculus.Platform.Models
{
	public class AppDownloadProgressResult
	{
		public readonly long DownloadBytes;

		public readonly long DownloadedBytes;

		public readonly AppStatus StatusCode;

		public AppDownloadProgressResult(IntPtr o)
		{
		}
	}
}
