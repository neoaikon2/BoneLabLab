using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnForce : SpawnDecorator
	{
		[Tooltip("If true force will be applied once awakened from hibernation, or use ApplyForce() on a trigger to explicitly add forces anytime after entity is awakened")]
		public bool applyForceOnSpawn;

		public Vector3 spawnVelocity;

		public Vector3 spawnAngularVelocity;

		public float minSpawnAngularVelocity;

		public float maxSpawnAngularVelocity;

		public float additionalDelay;

		private bool isReady;

		public bool drawVelocity;

		private MarrowEntity entity;

		public override void OnSpawn(GameObject go)
		{
		}
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}

		[ContextMenu("ApplyForce")]
		public void ApplyForce()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
