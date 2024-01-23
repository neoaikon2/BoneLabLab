using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	public class ZoneEncounter : ZoneItem
	{
		public enum SpawnOrder
		{
			PARALLEL = 0
		}

		[Serializable]
		public class SpawnGroup
		{
			[Tooltip("Total spawned at one time")]
			public uint concurrent;

			[Tooltip("Total Amount Spawned")]
			public uint maxSpawn;

			[Tooltip("Initial delay for the group.")]
			public float initialGroupDelay;

			[Tooltip("Time between each spawn")]
			public float spawnInterval;

			public ZoneSpawner[] spawners;

			public bool hostileGroup;

			private int _aliveCount;

			private int _deathCount;

			private int _spawnCount;

			private int _spawnerIndex;

			public int GetDeath()
			{
				return 0;
			}

			public void Setup()
			{
			}

			public void Cleanup()
			{
			}

			private void OnSpawn(GameObject spawnedObject, GameObject playerObject)
			{
			}

			private void OnDespawn(GameObject despawnedObject)
			{
			}

			private void OnDeath()
			{
			}

			public bool IsAllDead()
			{
				return false;
			}

			public bool IsUnderMax()
			{
				return false;
			}

			public bool IsUnderConcurrent()
			{
				return false;
			}

			public bool Spawn()
			{
				return false;
			}

			public string Stats()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CEncounter_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpawnGroup group;

			public ZoneEncounter _003C_003E4__this;

			private WaitForSeconds _003Cwait_003E5__2;

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
			public _003CEncounter_003Ed__20(int _003C_003E1__state)
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

		public SpawnOrder spawnOrder;

		public SpawnGroup[] spawnGroups;

		[Header("Encounter Music")]
		public AudioClip encounterMusic;

		[Range(0f, 1f)]
		public float volume;

		public bool loop;

		[Range(0f, 10f)]
		public float fadeInTime;

		[Range(0f, 10f)]
		public float fadeOutTime;

		private Coroutine[] _spawnCoroutines;

		private bool _complete;

		private bool _encounterActive;

		public UnityEvent OnComplete;

		private void Awake()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public void StartEncounter()
		{
		}

		public void PauseEncounter()
		{
		}

		public void CompleteEncounter()
		{
		}

		[IteratorStateMachine(typeof(_003CEncounter_003Ed__20))]
		public IEnumerator Encounter(SpawnGroup group)
		{
			return null;
		}
	}
}
