using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	[RequireComponent(typeof(Encounter))]
	public class EncounterMonitor : MonoBehaviour
	{
		public Encounter encounter;

		public uint maxConcurrent;

		public uint aliveTotal;

		public uint deadTotal;

		public uint totalSpawned;

		public uint totalSpawnGoal;

		public uint enemiesRemaining;

		private Action<GameObject> _onCrateDespawned;

		private Action<AIBrain> _onDeath;

		private Action<AIBrain> _onResurrect;

		public Dictionary<AIBrain, NPC_Display_Data> brainLookup;

		public Dictionary<SpawnGroup, List<NPC_Display_Data>> groupLookup;

		public NPC_Display_Data selectedNPC;

		public Texture defaultIcon;

		public Texture deadIcon;

		public Texture despawnIcon;

		private string defaultIconPath;

		private string deadIconPath;

		private string despawnIconPath;

		[ContextMenu("GetEncounterData")]
		public void GetEncounterData()
		{
		}

		private void OnEnable()
		{
		}

		public void Start()
		{
		}

		public void OnSpawn(GameObject go, SpawnGroup group)
		{
		}

		private void RegisterSpawnedBrain(AIBrain brain, SpawnGroup spawnGroup)
		{
		}

		private void OnDeath(AIBrain brain)
		{
		}

		private void OnDespawn(GameObject go)
		{
		}

		private void OnResurrect(AIBrain brain)
		{
		}

		private void OnCompleteGroup(SpawnGroup group)
		{
		}

		private void OnGroupCleanup(SpawnGroup group)
		{
		}

		private void OnReset()
		{
		}
	}
}
