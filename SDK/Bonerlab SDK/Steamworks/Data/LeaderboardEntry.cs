namespace Steamworks.Data
{
	public struct LeaderboardEntry
	{
		public Friend User;

		public int GlobalRank;

		public int Score;

		public int[] Details;

		internal static LeaderboardEntry From(LeaderboardEntry_t e, int[] detailsBuffer)
		{
			return default(LeaderboardEntry);
		}
	}
}
