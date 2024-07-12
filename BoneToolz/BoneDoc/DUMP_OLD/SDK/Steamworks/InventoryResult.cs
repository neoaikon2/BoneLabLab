using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public struct InventoryResult : IDisposable
	{
		internal SteamInventoryResult_t _id;

		internal bool Expired { set; }

		public int ItemCount
		{
			get
			{
				return default(int);
			}
		}

		internal InventoryResult(SteamInventoryResult_t id, bool expired)
		{
			this._id = default(SteamInventoryResult_t);
		}

		public InventoryItem[] GetItems(bool includeProperties = false)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
