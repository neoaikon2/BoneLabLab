using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct Leaderboard
	{
		internal SteamLeaderboard_t Id;

		private static int[] detailsBuffer;

		private static int[] noDetails;

		[DebuggerStepThrough]
		public Task<LeaderboardUpdate?> SubmitScoreAsync(int score, int[] details = default(int[]))
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<LeaderboardEntry[]> GetScoresAsync(int count, int offset = 1)
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<LeaderboardEntry[]> GetScoresAroundUserAsync(int start = -10, int end = 10)
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<LeaderboardEntry[]> GetScoresFromFriendsAsync()
		{
			return null;
		}

		[DebuggerStepThrough]
		internal Task<LeaderboardEntry[]> LeaderboardResultToEntries(LeaderboardScoresDownloaded_t r)
		{
			return null;
		}

		[DebuggerStepThrough]
		internal static Task WaitForUserNames(LeaderboardEntry[] entries)
		{
			return null;
		}
	}
}
