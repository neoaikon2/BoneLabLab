using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AIHeadbanger : MonoBehaviour, ISpawnListenable
	{
		public CrateSpawner[] crateSpawners;

		public HashSet<AIBrain> brainsHash;

		public List<AIBrain> livingBrainList;

		public float danceTick;

		private Coroutine _danCo;

		private bool _danceBeat;

		private bool _danceLeft;

		private void Start()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		private void OnDeath(AIBrain brain)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		[ContextMenu("ToggleDanceOn")]
		public void ToggleOn()
		{
		}

		[ContextMenu("ToggleDanceOff")]
		public void ToggleOff()
		{
		}

		public void ToggleDance(bool on)
		{
		}
		public IEnumerator DanceCo()
		{
			return null;
		}
	}
}
