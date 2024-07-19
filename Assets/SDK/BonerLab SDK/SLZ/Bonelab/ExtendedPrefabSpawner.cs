using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ExtendedPrefabSpawner : MonoBehaviour
	{
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

		private CancellationTokenSource spawnLoop;

		private MarrowEntity entity;

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
		private UniTaskVoid SpawnLoop(float length, CancellationTokenSource cts)
		{
			return default(UniTaskVoid);
		}

		public void SpawnPrefab()
		{
		}
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}

		private void ApplyForce()
		{
		}
	}
}
