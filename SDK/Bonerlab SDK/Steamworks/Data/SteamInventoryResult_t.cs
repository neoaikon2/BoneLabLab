using System;

namespace Steamworks.Data
{
	internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		public int Value;

		public static implicit operator SteamInventoryResult_t(int value)
		{
			return default(SteamInventoryResult_t);
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

		public bool Equals(SteamInventoryResult_t p)
		{
			return default(bool);
		}

		public int CompareTo(SteamInventoryResult_t other)
		{
			return default(int);
		}
	}
}
