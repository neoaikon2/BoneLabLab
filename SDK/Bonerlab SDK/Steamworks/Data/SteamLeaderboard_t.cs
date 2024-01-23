using System;

namespace Steamworks.Data
{
	internal struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		public ulong Value;

		public static implicit operator SteamLeaderboard_t(ulong value)
		{
			return default(SteamLeaderboard_t);
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

		public bool Equals(SteamLeaderboard_t p)
		{
			return default(bool);
		}

		public int CompareTo(SteamLeaderboard_t other)
		{
			return default(int);
		}
	}
}
