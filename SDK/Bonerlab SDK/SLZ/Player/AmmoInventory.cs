using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Player
{
	public class AmmoInventory : MonoBehaviour
	{
		private static ComponentCache<AmmoInventory> _cache;

		[CompilerGenerated]
		private static AmmoInventory _003CInstance_003Ek__BackingField;

		[Header("AMMO")]
		public InventoryAmmoReceiver ammoReceiver;

		public AmmoGroup lightAmmoGroup;

		public AmmoGroup mediumAmmoGroup;

		public AmmoGroup heavyAmmoGroup;

		public Action onAmmoUpdate;

		public Action<string, int> onAmmoUpdateCount;

		private Dictionary<string, int> _groupCounts;

		private Dictionary<string, string> _cartridgeToKey;

		private Dictionary<string, int> _AmmoCountsByCartridge;

		private Dictionary<CartridgeData, int> _cartridgeCounts;

		public static ComponentCache<AmmoInventory> Cache => null;

		public static AmmoInventory Instance
		{
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = (AmmoInventory)value;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void RegisterAmmoGroup(AmmoGroup ammoGroup)
		{
		}

		public void ClearAmmo()
		{
		}

		public int GetCartridgeCount(CartridgeData cartridge)
		{
			return 0;
		}

		public int GetCartridgeCount(string groupKey)
		{
			return 0;
		}

		public void AddCartridge(CartridgeData cartridge, int count)
		{
		}

		public void AddCartridge(AmmoGroup ammoGroup, int count)
		{
		}

		public void RemoveCartridge(CartridgeData cartridge, int count)
		{
		}

		public string GetGroupByCartridge(CartridgeData cartridge)
		{
			return null;
		}
	}
}
