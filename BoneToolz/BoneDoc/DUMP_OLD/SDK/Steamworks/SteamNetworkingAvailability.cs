namespace Steamworks
{
	public enum SteamNetworkingAvailability
	{
		CannotTry = -102,
		Failed = -101,
		Previously = -100,
		Retrying = -10,
		NeverTried = 1,
		Waiting = 2,
		Attempting = 3,
		Current = 100,
		Unknown = 0,
		Force32bit = int.MaxValue
	}
}
