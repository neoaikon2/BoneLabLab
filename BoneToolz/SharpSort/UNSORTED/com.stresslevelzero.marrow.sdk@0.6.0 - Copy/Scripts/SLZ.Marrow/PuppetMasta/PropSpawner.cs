using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace PuppetMasta
{
	public class PropSpawner : MonoBehaviour
	{
		[HideInInspector]
		public Rigidbody propRb;

		public Rigidbody attachRb;

		public Collider[] ignoreColliders;

		public Vector3 localPosOffset;

		public Vector3 localRotOffset;

		public Vector3 anchorFix;

		public Spawnable headSpawnable;

		public Spawnable altHeadSpawnable;

		[SerializeField]
		private GameObject gO;

		public bool isAltObj;

		private ConfigurableJoint _faceJoint;

		private Collider[] _cols;

		private Poolee _propPoolee;

		private Poolee _poolee;

		[HideInInspector]
		public bool _hasBeenSpawnedOnce;

		public bool spawnOnEnable;

		public bool despawnDetachedProp;

		private float breakDistance;

		private float linearLimit;

		private Vector3 cbPos;

		private Vector3 anchorPos;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void OnSpawn(GameObject gameObject)
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public void OnPropDespawn(GameObject go)
		{
		}

		private void FixedUpdate()
		{
		}

		private void IgnoreCollisions(Collider[] cols, bool ignore = true)
		{
		}
		private UniTaskVoid SpawnHatJoint()
		{
			return default(UniTaskVoid);
		}

		private void SetupFaceJoint(GameObject go)
		{
		}
	}
}
