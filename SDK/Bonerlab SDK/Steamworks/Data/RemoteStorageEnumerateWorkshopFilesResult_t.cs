using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 624)]
	internal struct RemoteStorageEnumerateWorkshopFilesResult_t : ICallbackData
	{
		internal Result Result;

		internal int ResultsReturned;

		internal int TotalResultCount;

		internal PublishedFileId[] GPublishedFileId;

		internal float[] GScore;

		internal AppId AppId;

		internal uint StartIndex;

		public static int _datasize;

		public int DataSize
		{
			get
			{
				return default(int);
			}
		}

		public CallbackType CallbackType
		{
			get
			{
				return default(CallbackType);
			}
		}
	}
}
