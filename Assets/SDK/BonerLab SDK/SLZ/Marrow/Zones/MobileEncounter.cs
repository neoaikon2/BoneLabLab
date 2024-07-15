using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class MobileEncounter : MonoBehaviour
	{
		public enum SpawnOrder
		{
			PARALLEL = 0,
			SERIES = 1
		}
		public SpawnOrder spawnOrder;

		public SpawnGroup[] spawnGroups;

		public Action<SpawnGroup> onGroupComplete;

		public UltEvent OnComplete;

		private CancellationTokenSource[] _spawnCTSs;

		private int completeCount;

		private bool _complete;

		private bool _isEncounterActive;

		private bool _isEncounterPaused;

		private bool isWarmed;

		public Action<GameObject, SpawnGroup> OnGroupMemberSpawned;

		public Action AllGroupsKilled;

		protected virtual void GroupMemberSpawned(GameObject go, SpawnGroup group)
		{
		}

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		protected void OnDestroy()
		{
		}

		public virtual void StartEncounter()
		{
		}

		public virtual void StartEncounter(MarrowEntity activatorEntity)
		{
		}

		protected virtual void StartGroupEncounter(int groupID)
		{
		}

		public virtual void StopEncounter()
		{
		}

		public void KillAll()
		{
		}

		protected virtual void PauseEncounter()
		{
		}

		public void CheckCompletion(SpawnGroup group)
		{
		}

		public void MentalAllEncounter(MarrowEntity entity)
		{
		}

		public void TerminateEncounter()
		{
		}

		public void CompleteEncounter()
		{
		}
		protected UniTaskVoid EncounterLoop(SpawnGroup group, CancellationToken ct)
		{
			return default(UniTaskVoid);
		}
	}
}
