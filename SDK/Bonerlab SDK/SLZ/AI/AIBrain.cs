using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.AI
{
	public class AIBrain : SpawnEvents
	{
		[CompilerGenerated]
		private sealed class _003CCoArenaEntrance_003Ed__34
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AIBrain _003C_003E4__this;

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
			public _003CCoArenaEntrance_003Ed__34(int _003C_003E1__state)
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

		private static ComponentCache<AIBrain> _cache;

		[Header("References")]
		public BehaviourBaseNav behaviour;

		public PuppetMaster puppetMaster;

		public EnemyTurret turret;

		public bool dontClearBaseConfig;

		public Action onDeathDelegate;

		public Action onResurrectDelegate;

		public Action<AIBrain> onNPC_DeathDelegate;

		public bool autoDespawn;

		[HideInInspector]
		public bool isDead;

		private Rigidbody[] _rigidbodies;

		private bool _wasConfigSet;

		private Coroutine arenaEntranceRoutine;

		private float entranceTimer;

		public static ComponentCache<AIBrain> Cache => null;

		public BehaviourBaseNav.MentalState MentalState => default(BehaviourBaseNav.MentalState);

		public bool IsSoundAggroWhenInSecondaryZone => false;

		private void Reset()
		{
		}

		protected void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnDespawn(GameObject spawnedObject)
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		public void SetBaseConfig(BaseEnemyConfig config)
		{
		}

		public void SetVelocity(Vector3 velocity)
		{
		}

		public void SetAngularVelocity(Vector3 angularVelocity)
		{
		}

		public void SetAngularVelocity(float minAngularSpeed, float maxAngularSpeed)
		{
		}

		private void OnDeath()
		{
		}

		private void OnResurrection()
		{
		}

		public void StartArenaEntranceTimer(float time = 120f)
		{
		}

		public void StopArenaEntranceTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCoArenaEntrance_003Ed__34))]
		private IEnumerator CoArenaEntrance()
		{
			return null;
		}
	}
}
