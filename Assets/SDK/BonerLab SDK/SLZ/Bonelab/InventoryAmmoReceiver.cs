using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class InventoryAmmoReceiver : InventoryHandReceiver
	{
		[Range(0f, 10f)]
		public float priority;

		public Transform validateTarget;

		[Header("References")]
		public AudioClip[] grabClips;

		public RigManager rigManager;

		public MagazineData defaultLightMag;

		public CartridgeData defaultLightCart;

		public MagazineData defaultMediumMag;

		public CartridgeData defaultMediumCart;

		public MagazineData defaultHeavyMag;

		public CartridgeData defaultHeavyCart;

		[SerializeField]
		private Transform[] _ammoArtTargets;

		private CartridgeData _selectedCartridgeData;

		private MagazineData _selectedMagazineData;

		private List<MagazineData> _platformStack;

		private List<CartridgeData> _cartridgeStack;

		private AmmoInventory _AmmoInventory;

		private List<Magazine> _activeMagazines;

		private List<Magazine> _magazineArts;

		private int _curMagIdx;

		private Spawnable _nextMagazine;

		private bool _isSwitching;

		private bool _hasMagazineInQueue;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnHandGrab(Hand hand)
		{
		}
		private UniTaskVoid GrabMagAsync(Hand hand, CartridgeData cartridge, int ammoCount)
		{
			return default(UniTaskVoid);
		}

		public override void OnHandDrop(IGrippable host)
		{
		}

		public override float Validate(Hand hand)
		{
			return 0f;
		}

		public void RegisterMagazine(Magazine magazine)
		{
		}

		public void UnregisterMagazine(Magazine magazine)
		{
		}

		public void OnHandItemSlotRemoved(InventorySlot slot)
		{
		}

		private void OnHandItemSlot(InventorySlot slot)
		{
		}

		public void SwitchMagazine(MagazineData magazineData, CartridgeData cartridgeData)
		{
		}
		private UniTaskVoid SwitchMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTaskVoid);
		}
		private UniTask SpawnAndPlaceMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTask);
		}

		private void UpdateAmmoArt()
		{
		}
	}
}
