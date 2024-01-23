using System;

namespace Steamworks.Data
{
	internal struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		public ulong Value;

		public static implicit operator SteamLeaderboardEntries_t(ulong value)
		{
			return default(SteamLeaderboardEntries_t);
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object p)
		{
			return default(bool);
		}

		public bool Equals(SteamLeaderboardEntries_t p)
		{
			return default(bool);
		}

		public int CompareTo(SteamLeaderboardEntries_t other)
		{
			return default(int);
		}
	}
}
