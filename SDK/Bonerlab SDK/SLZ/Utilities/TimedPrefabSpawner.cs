using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class TimedPrefabSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnLoop_003Ed__8
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimedPrefabSpawner _003C_003E4__this;

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
			public _003CSpawnLoop_003Ed__8(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("Spawnable")]
		private Spawnable spawnable;

		[Tooltip("Spawn Interval")]
		[SerializeField]
		private float spawnInterval;

		[SerializeField]
		[Tooltip("Ignore Colliders")]
		private Collider[] ignoreColliders;

		private IEnumerator coroutine;

		private bool doSpawnLoop;

		private void Awake()
		{
		}

		public void ACTIVATESPAWNER()
		{
		}

		public void DEACTIVATESPAWNER()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnLoop_003Ed__8))]
		private IEnumerator SpawnLoop()
		{
			return null;
		}

		public void SpawnPrefab()
		{
		}
	}
}
