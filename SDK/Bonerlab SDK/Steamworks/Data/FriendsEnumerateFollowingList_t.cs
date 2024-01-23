using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 412)]
	internal struct FriendsEnumerateFollowingList_t : ICallbackData
	{
		internal Result Result;

		internal ulong[] GSteamID;

		internal int ResultsReturned;

		internal int TotalResultCount;

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
