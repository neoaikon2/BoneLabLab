using System;
using System.Collections.Generic;
using Steamworks.Data;

namespace Steamworks
{
	public struct InventoryItem : IEquatable<InventoryItem>
	{
		internal InventoryItemId _id;

		internal InventoryDefId _def;

		internal SteamItemFlags _flags;

		internal ushort _quantity;

		internal Dictionary<string, string> _properties;

		internal static InventoryItem From(SteamItemDetails_t details)
		{
			return default(InventoryItem);
		}

		internal static Dictionary<string, string> GetProperties(SteamInventoryResult_t result, int index)
		{
			return null;
		}

		public override bool Equals(object p)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(InventoryItem p)
		{
			return default(bool);
		}
	}
}
