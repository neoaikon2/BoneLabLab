namespace Steamworks
{
	public enum ConnectionState
	{
		None = 0,
		Connecting = 1,
		FindingRoute = 2,
		Connected = 3,
		ClosedByPeer = 4,
		ProblemDetectedLocally = 5,
		FinWait = -1,
		Linger = -2,
		Dead = -3
	}
}
