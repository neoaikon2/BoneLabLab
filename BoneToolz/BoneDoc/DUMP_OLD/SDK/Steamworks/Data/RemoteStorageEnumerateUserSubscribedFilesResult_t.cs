using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 616)]
	internal struct RemoteStorageEnumerateUserSubscribedFilesResult_t : ICallbackData
	{
		internal Result Result;

		internal int ResultsReturned;

		internal int TotalResultCount;

		internal PublishedFileId[] GPublishedFileId;

		internal uint[] GRTimeSubscribed;

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
