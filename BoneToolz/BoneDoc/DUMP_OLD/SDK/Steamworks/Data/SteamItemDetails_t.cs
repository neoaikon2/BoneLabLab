using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct SteamItemDetails_t
	{
		internal InventoryItemId ItemId;

		internal InventoryDefId Definition;

		internal ushort Quantity;

		internal ushort Flags;
	}
}
