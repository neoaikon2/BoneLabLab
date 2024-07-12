using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.AI;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class ProfileSpawner : SpawnDecorator
	{
		public Zone zone;

		public bool forceManualSpawns;

		public bool enableAgentLinking;

		[HideInInspector]
		public EnemyProfile currProfile;

		[HideInInspector]
		public bool isFriend;

		public bool LogSpawns;

		private TriggerRefProxy playerProxy;

		public Action<ProfileSpawner, AIBrain, EnemyProfile, bool> onSpawnNPCDelegate;

		public CrateSpawner CrateSpawner
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void SetPlayerProxy(TriggerRefProxy proxy)
		{
		}

		public UniTask ExplicitArenaSpawn(EnemyProfile enemyProfile, bool isFriendly = false)
		{
			return default(UniTask);
		}

		public override void OnSpawn(GameObject go)
		{
		}

		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		public void OnDeath(AIBrain aiBrain)
		{
		}

		public ProfileSpawner()
			: base()
		{
		}
	}
}
