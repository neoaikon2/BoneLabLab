using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Combat;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Props.Weapons
{
	public class Magazine : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__25
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public Magazine _003C_003E4__this;

			public CartridgeData cartridgeData;

			public int count;

			private Spawnable _003Cspawnable_003E5__2;

			private UniTask<AssetPoolee>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<Magazine> _cache;

		[SerializeField]
		public MagazineState magazineState;

		[Header("References")]
		public AmmoPlug magazinePlug;

		public Grip grip;

		public Transform insertPointTransform;

		public InteractableHost interactableHost;

		public GameObject firstCartridgeTarget;

		public GameObject secondCartridgeTarget;

		private FirearmCartridge _firstCartridgeArt;

		private FirearmCartridge _secondCartridgeArt;

		private bool _isArtHidden;

		private bool _isMagazineClaimed;

		private AmmoInventory _lastAmmoInventory;

		public SimpleTransform ammoPouchOffset;

		[HideInInspector]
		public bool isMagazineInserted;

		public bool ignoreSecondBulletSpawn;

		public static ComponentCache<Magazine> Cache => null;

		protected void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		public bool IsClaimed()
		{
			return false;
		}

		public void Claim()
		{
		}

		public void Initialize(CartridgeData cartridgeData, int count)
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__25))]
		public UniTask InitializeAsync(CartridgeData cartridgeData, int count)
		{
			return default(UniTask);
		}

		private FirearmCartridge ApplyBulletArt(GameObject go, Transform parent)
		{
			return null;
		}

		private void OnAmmoChange(int ammount)
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		public void OnEject()
		{
		}

		public void OnInsert()
		{
		}

		private void HideBulletArt()
		{
		}

		private void ShowBulletArt()
		{
		}

		public void CheckBulletArt()
		{
		}
	}
}
