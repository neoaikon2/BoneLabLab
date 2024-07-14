using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift
{
	[PublicAPI]
	public readonly struct FileDownloadProgress
	{
		public readonly long BytesDownloaded;

		public readonly long BytesTotal;

		public FileDownloadProgress(long bytesDownloaded, long? bytesTotal)
		{
			BytesDownloaded = 0L;
			BytesTotal = 0L;
		}
	}
}
