using System;

namespace Steamworks.Data
{
	internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		public ulong Value;

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

		public bool Equals(SteamAPICall_t p)
		{
			return default(bool);
		}

		public int CompareTo(SteamAPICall_t other)
		{
			return default(int);
		}
	}
}
