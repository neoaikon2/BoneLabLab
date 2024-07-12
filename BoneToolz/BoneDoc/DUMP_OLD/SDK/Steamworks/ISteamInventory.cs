using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamInventory : SteamInterface
	{
		internal ISteamInventory(bool IsGameServer)
			: base()
		{
		}

		internal static extern IntPtr SteamAPI_SteamInventory_v003();

		public override IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		internal static extern IntPtr SteamAPI_SteamGameServerInventory_v003();

		public override IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}

		private static extern bool _GetResultItems(IntPtr self, SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, uint punOutItemsArraySize);

		internal bool GetResultItems(SteamInventoryResult_t resultHandle, [In][Out] SteamItemDetails_t[] pOutItemsArray, uint punOutItemsArraySize)
		{
			return default(bool);
		}

		private static extern bool _GetResultItemProperty(IntPtr self, SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, IntPtr pchValueBuffer, uint punValueBufferSizeOut);

		internal bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, [Out] string pchValueBuffer, uint punValueBufferSizeOut)
		{
			return default(bool);
		}

		private static extern void _DestroyResult(IntPtr self, SteamInventoryResult_t resultHandle);

		internal void DestroyResult(SteamInventoryResult_t resultHandle)
		{
		}

		private static extern bool _GetItemDefinitionIDs(IntPtr self, [In][Out] InventoryDefId[] pItemDefIDs, uint punItemDefIDsArraySize);

		internal bool GetItemDefinitionIDs([In][Out] InventoryDefId[] pItemDefIDs, uint punItemDefIDsArraySize)
		{
			return default(bool);
		}
	}
}
