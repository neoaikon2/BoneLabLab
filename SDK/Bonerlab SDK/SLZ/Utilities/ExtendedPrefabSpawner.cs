using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class ExtendedPrefabSpawner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSpawnLoop_003Ed__25
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtendedPrefabSpawner _003C_003E4__this;

			public float length;

			private float _003Ctime_003E5__2;

			private float _003ClastSpawn_003E5__3;

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
			public _003CSpawnLoop_003Ed__25(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CAddForceTorqueWait_003Ed__27
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtendedPrefabSpawner _003C_003E4__this;

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
			public _003CAddForceTorqueWait_003Ed__27(int _003C_003E1__state)
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

		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable[] spawnables;

		public bool spawnOnStart;

		public bool useSpawnEffect;

		public Vector3 spawnForce;

		public Vector3 spawnTorque;

		public Vector3 randomPositionVector;

		public Vector3 randomRotationVector;

		public bool randomForce;

		public Vector3 spawnForceLow;

		public Vector3 spawnForceHigh;

		public bool randomTorque;

		public Vector3 spawnTorqueLow;

		public Vector3 spawnTorqueHigh;

		public float frequencey;

		public bool useCoolDown;

		public bool useRestCoolDown;

		public UnityEvent spawnEvent;

		private float lastSpawnTime;

		private Rigidbody rb;

		private IEnumerator spawnLoop;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartSpawnLoop(float length = 10f)
		{
		}

		[ContextMenu("StartSpawnLoopContinuous")]
		public void StartSpawnLoopContinuous()
		{
		}

		[ContextMenu("StopSpawnLoop")]
		public void StartSpawnLoop()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnLoop_003Ed__25))]
		private IEnumerator SpawnLoop(float length)
		{
			return null;
		}

		public void SpawnPrefab()
		{
		}

		[IteratorStateMachine(typeof(_003CAddForceTorqueWait_003Ed__27))]
		private IEnumerator AddForceTorqueWait()
		{
			return null;
		}
	}
}
