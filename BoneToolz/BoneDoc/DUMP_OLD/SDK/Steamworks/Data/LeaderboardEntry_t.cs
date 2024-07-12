using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 32)]
	internal struct LeaderboardEntry_t
	{
		internal ulong SteamIDUser;

		internal int GlobalRank;

		internal int Score;

		internal int CDetails;

		internal ulong UGC;
	}
}
