using System;

namespace Steamworks.Data
{
	internal struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		public uint Value;

		public static implicit operator HSteamNetPollGroup(uint value)
		{
			return default(HSteamNetPollGroup);
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

		public bool Equals(HSteamNetPollGroup p)
		{
			return default(bool);
		}

		public int CompareTo(HSteamNetPollGroup other)
		{
			return default(int);
		}
	}
}
