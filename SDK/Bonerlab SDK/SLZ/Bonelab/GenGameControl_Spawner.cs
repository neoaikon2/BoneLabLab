using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GenGameControl_Spawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public WaveProfile wave;

			public GenGameControl_Spawner _003C_003E4__this;

			public Action<GameObject> _003C_003E9__3;

			internal void _003CCoSpawnLoots_003Eb__0(GameObject go)
			{
			}

			internal void _003CCoSpawnLoots_003Eb__1(GameObject go)
			{
			}

			internal void _003CCoSpawnLoots_003Eb__2(GameObject go)
			{
			}

			internal void _003CCoSpawnLoots_003Eb__3(GameObject go)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoSpawnLoots_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WaveProfile wave;

			public GenGameControl_Spawner _003C_003E4__this;

			private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

			private List<ArenaLootItem>.Enumerator _003C_003E7__wrap1;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoSpawnLoots_003Ed__20(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public GenGameControl_Spawner _003C_003E4__this;

			public WaveProfile wave;

			public Action<GameObject> _003C_003E9__3;

			internal void _003CCoSpawnWeaponModeLoots_003Eb__3(GameObject go)
			{
			}

			internal void _003CCoSpawnWeaponModeLoots_003Eb__0(GameObject go)
			{
			}

			internal void _003CCoSpawnWeaponModeLoots_003Eb__1(GameObject go)
			{
			}

			internal void _003CCoSpawnWeaponModeLoots_003Eb__2(GameObject go)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoSpawnWeaponModeLoots_003Ed__21
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenGameControl_Spawner _003C_003E4__this;

			public WaveProfile wave;

			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			private Spawnable[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoSpawnWeaponModeLoots_003Ed__21(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private Arena_GameController arenaGameController;

		[SerializeField]
		private AudioClip _spawnClip;

		public int lightAmmoSpawned;

		public int medAmmoSpawned;

		public int heavyAmmoSpawned;

		[SerializeField]
		private Transform ammoSpawnTrans;

		public List<GameObject> spawnedWeaponObjList;

		public List<GameObject> despawnedWeaponObjList;

		public List<AmmoPickup> ammoPickupList;

		public AmmoPickup spawnedLightPickup;

		public AmmoPickup spawnedMedPickup;

		public AmmoPickup spawnedHeavyPickup;

		[Header("ArenaWeaponMode")]
		private RigManager rigManager;

		[SerializeField]
		private GameObject playerRelSpawnPrefab;

		[SerializeField]
		private PlayerRelativeGunSpawns playerRelGunSpawns;

		public void Awake()
		{
		}

		public void Initialize(Arena_GameController gameController)
		{
		}

		private void Start()
		{
		}

		public void SetupPlayerRelativeGunSpawns()
		{
		}

		public void SpawnWaveLoot(WaveProfile wave)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSpawnLoots_003Ed__20))]
		private IEnumerator CoSpawnLoots(WaveProfile wave)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoSpawnWeaponModeLoots_003Ed__21))]
		private IEnumerator CoSpawnWeaponModeLoots(WaveProfile wave)
		{
			return null;
		}

		public void DespawnLootWeapons(bool despawnAll)
		{
		}

		public void ForceCollectAllAmmo()
		{
		}
	}
}
