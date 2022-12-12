using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.SaveData;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class GachaCapsule : MonoBehaviour
	{
		private static ComponentCache<GachaCapsule> _cache;

		public SphereGrip grip;

		public GenericCrateReference selectedCrate;

		public Transform previewMeshPosition;

		public Transform previewMeshSpin;

		public Transform previewMeshRock;

		public MeshFilter previewBounds;

		public MeshFilter previewMesh;

		public Transform previewPoint;

		public float previewMeshScaleTune;

		public float previewMeshSpinSpeed;

		public float previewMeshRockSpeed;

		public float previewMeshRockAmp;

		public AnimationCurve hapticsCurve;

		[Range(0f, 1f)]
		[SerializeField]
		private float amplitudeMin;

		[Range(0f, 1f)]
		[SerializeField]
		private float amplitudeMax;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMin;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMax;

		[SerializeField]
		private float separationMin;

		[SerializeField]
		private float separationMax;

		[SerializeField]
		private float lengthMin;

		[SerializeField]
		private float lengthMax;

		public float unlockDistance;

		public bool isAvatarGacha;

		public UnityEvent gachaPopEvent;

		[SerializeField]
		private Spawnable vfxSpawnable;

		public Transform vfxPoint;

		public ParticleSystem arrowParticleSystem;

		private float time;

		private float lastHapticTime;

		private bool used;

		private InteractableHost host;

		[HideInInspector]
		public SpawnableCrate previewMeshCrate;

		public static ComponentCache<GachaCapsule> Cache
		{
			get
			{
				return null;
			}
		}

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void UnlockItem()
		{
		}

		private void SendGachaToPullCord(PullCordDevice pcd)
		{
		}

		public void POPFX(Spawnable effect)
		{
		}

		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}

		private IEnumerator DespawnTimmer()
		{
			return null;
		}

		private void ReleasePreviewMesh()
		{
		}

		public UniTaskVoid SetPreviewMesh()
		{
			return default(UniTaskVoid);
		}

		public GachaCapsule()
			: base()
		{
		}
	}
}
