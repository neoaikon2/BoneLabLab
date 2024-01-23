namespace Steamworks.Data
{
	public struct LeaderboardUpdate
	{
		public int Score;

		public bool Changed;

		public int NewGlobalRank;

		public int OldGlobalRank;

		internal static LeaderboardUpdate From(LeaderboardScoreUploaded_t e)
		{
			return default(LeaderboardUpdate);
		}
	}
}
