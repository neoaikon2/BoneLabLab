using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.AI
{
	public class AIBrain : SpawnEvents
	{
		public class SpawnGroupEvent : UnityEvent<AIBrain, bool>
		{
		}
		[Header("References")]
		public BehaviourBaseNav behaviour;

		public PuppetMaster puppetMaster;

		public bool dontClearBaseConfig;

		public Action<AIBrain> onDeathDelegate;

		public Action<AIBrain> onResurrectDelegate;

		public Action<AIBrain> onNPC_DeathDelegate;

		public SpawnGroupEvent OnGroupDeregister;

		[HideInInspector]
		public bool isDead;

		private bool _wasConfigSet;

		private Coroutine arenaEntranceRoutine;

		private float entranceTimer;

		public BehaviourBaseNav.MentalState MentalState => default(BehaviourBaseNav.MentalState);

		public bool IsSoundAggroWhenInSecondaryZone => false;

		public void SpawnGroupIgnore(bool val)
		{
		}

		protected override void Reset()
		{
		}

		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		public override void OnPoolDeInitialize()
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
		private IEnumerator CoArenaEntrance()
		{
			return null;
		}
	}
}
