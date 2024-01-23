using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamInventory : SteamSharedClass<SteamInventory>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<InventoryResult> OnInventoryUpdated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnDefinitionsUpdated;

		private static Dictionary<int, InventoryDef> _defMap;

		internal static ISteamInventory Internal
		{
			get
			{
				return null;
			}
		}

		internal static InventoryItem[] Items { set; get; }

		public static InventoryDef[] Definitions { get; internal set; }

		internal override void InitializeInterface(bool server)
		{
		}

		internal static void InstallEvents(bool server)
		{
		}

		private static void InventoryUpdated(SteamInventoryFullUpdate_t x)
		{
		}

		private static void LoadDefinitions()
		{
		}

		internal static InventoryDef[] GetDefinitions()
		{
			return null;
		}

		public SteamInventory()
			: base()
		{
		}
	}
}
