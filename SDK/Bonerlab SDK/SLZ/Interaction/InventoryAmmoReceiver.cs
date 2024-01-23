using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Player;
using SLZ.Props.Weapons;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InventoryAmmoReceiver : InventoryHandReceiver
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwitchMagazineAsync_003Ed__36
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Spawnable spawnable;

			public InventoryAmmoReceiver _003C_003E4__this;

			public CartridgeData cartridgeData;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnAndPlaceMagazineAsync_003Ed__37
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public InventoryAmmoReceiver _003C_003E4__this;

			public Spawnable spawnable;

			public CartridgeData cartridgeData;

			private Transform[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private Transform _003CartTarget_003E5__4;

			private Magazine _003Cmagazine_003E5__5;

			private UniTask<SLZ.Marrow.Pool.AssetPoolee>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<InventoryAmmoReceiver> _cache;

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

		public new static ComponentCache<InventoryAmmoReceiver> Cache => null;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void OnHandGrab(Hand hand)
		{
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

		[AsyncStateMachine(typeof(_003CSwitchMagazineAsync_003Ed__36))]
		private UniTaskVoid SwitchMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnAndPlaceMagazineAsync_003Ed__37))]
		private UniTask SpawnAndPlaceMagazineAsync(Spawnable spawnable, CartridgeData cartridgeData)
		{
			return default(UniTask);
		}
	}
}
