using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 32)]
	internal struct RemoteStorageGetPublishedItemVoteDetailsResult_t : ICallbackData
	{
		internal Result Result;

		internal PublishedFileId PublishedFileId;

		internal int VotesFor;

		internal int VotesAgainst;

		internal int Reports;

		internal float FScore;

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
