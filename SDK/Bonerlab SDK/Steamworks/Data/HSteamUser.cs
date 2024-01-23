using System;

namespace Steamworks.Data
{
	internal struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		public int Value;

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

		public bool Equals(HSteamUser p)
		{
			return default(bool);
		}

		public int CompareTo(HSteamUser other)
		{
			return default(int);
		}
	}
}
