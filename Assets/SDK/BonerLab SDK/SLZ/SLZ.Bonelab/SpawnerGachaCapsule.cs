using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnerGachaCapsule : SpawnEvents
	{
		public Rigidbody rb;

		public Spawnable spawnable;

		public SpawnFragmentArray[] spawnFragments;

		public float explosiveForceOnDestruct;

		public ChopperSequenceController_LongRun optionalChopperContoller;

		public Transform optionalSpawnDirection;

		private bool despawning;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}
		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}
	}
}
