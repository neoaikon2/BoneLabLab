using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamUserStats : SteamInterface
	{
		internal ISteamUserStats(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamUserStats_v011();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern bool _RequestCurrentStats(IntPtr self);

		internal bool RequestCurrentStats()
		{
			return default(bool);
		}

		private static extern bool _SetAchievement(IntPtr self, string pchName);

		internal bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		private static extern bool _StoreStats(IntPtr self);

		internal bool StoreStats()
		{
			return default(bool);
		}

		private static extern SteamAPICall_t _FindLeaderboard(IntPtr self, string pchLeaderboardName);

		internal CallResult<LeaderboardFindResult_t> FindLeaderboard(string pchLeaderboardName)
		{
			return default(CallResult<LeaderboardFindResult_t>);
		}

		private static extern SteamAPICall_t _DownloadLeaderboardEntries(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd);

		internal CallResult<LeaderboardScoresDownloaded_t> DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(CallResult<LeaderboardScoresDownloaded_t>);
		}

		private static extern bool _GetDownloadedLeaderboardEntry(IntPtr self, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax);

		internal bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, LeaderboardEntry_t pLeaderboardEntry, [In][Out] int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		private static extern SteamAPICall_t _UploadLeaderboardScore(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount);

		internal CallResult<LeaderboardScoreUploaded_t> UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In][Out] int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(CallResult<LeaderboardScoreUploaded_t>);
		}
	}
}
