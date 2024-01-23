using System;

namespace Steamworks.Data
{
	public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId>
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

		public bool Equals(InventoryItemId p)
		{
			return default(bool);
		}

		public static bool operator ==(InventoryItemId a, InventoryItemId b)
		{
			return default(bool);
		}

		public static bool operator !=(InventoryItemId a, InventoryItemId b)
		{
			return default(bool);
		}

		public int CompareTo(InventoryItemId other)
		{
			return default(int);
		}
	}
}
