using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift
{
	[PublicAPI]
	public struct FileDownloadProgress
	{
		public readonly long BytesDownloaded;

		public readonly long BytesTotal;

		public FileDownloadProgress(long bytesDownloaded, long? bytesTotal)
		{
			this.BytesTotal = default(long);
			this.BytesDownloaded = default(long);
		}
	}
}
