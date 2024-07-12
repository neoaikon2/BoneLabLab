using System;

namespace Steamworks.Data
{
	internal struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		public int Value;

		public static implicit operator HSteamPipe(int value)
		{
			return default(HSteamPipe);
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

		public bool Equals(HSteamPipe p)
		{
			return default(bool);
		}

		public static bool operator ==(HSteamPipe a, HSteamPipe b)
		{
			return default(bool);
		}

		public static bool operator !=(HSteamPipe a, HSteamPipe b)
		{
			return default(bool);
		}

		public int CompareTo(HSteamPipe other)
		{
			return default(int);
		}
	}
}
