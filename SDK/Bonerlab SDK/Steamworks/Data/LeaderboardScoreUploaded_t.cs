using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 32)]
	internal struct LeaderboardScoreUploaded_t : ICallbackData
	{
		internal byte Success;

		internal ulong SteamLeaderboard;

		internal int Score;

		internal byte ScoreChanged;

		internal int GlobalRankNew;

		internal int GlobalRankPrevious;

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
