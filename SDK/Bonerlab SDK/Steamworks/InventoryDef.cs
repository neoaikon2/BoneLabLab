using System;
using Steamworks.Data;

namespace Steamworks
{
	public class InventoryDef : IEquatable<InventoryDef>
	{
		internal InventoryDefId _id;

		public int Id
		{
			get
			{
				return default(int);
			}
		}

		public InventoryDef(InventoryDefId defId)
			: base()
		{
		}

		public static bool operator ==(InventoryDef a, InventoryDef b)
		{
			return default(bool);
		}

		public static bool operator !=(InventoryDef a, InventoryDef b)
		{
			return default(bool);
		}

		public override bool Equals(object p)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(InventoryDef p)
		{
			return default(bool);
		}
	}
}
