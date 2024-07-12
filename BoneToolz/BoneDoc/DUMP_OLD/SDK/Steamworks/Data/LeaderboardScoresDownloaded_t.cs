using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct LeaderboardScoresDownloaded_t : ICallbackData
	{
		internal ulong SteamLeaderboard;

		internal ulong SteamLeaderboardEntries;

		internal int CEntryCount;

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
