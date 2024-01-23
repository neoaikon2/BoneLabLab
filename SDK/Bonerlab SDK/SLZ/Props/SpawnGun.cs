using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Props.Weapons;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props
{
	public class SpawnGun : Gun
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnCrate_003Ed__77
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Action<GameObject> callback;

			public SpawnGun _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoFireFlash_003Ed__81
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SpawnGun _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private float _003Ctime_003E5__3;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoFireFlash_003Ed__81(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Header("Spawn Options")]
		public LayerMask collisionLayers;

		public float effectiveRange;

		public bool wackySpinWhenUpsideDown;

		public bool isDespawnMode;

		public GameObject laserPointerGameObject;

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

		public float xenCrystalSpinSpeed;

		public Transform fanBladesTransform;

		public Transform xenCrystalTransform;

		public AudioMixerGroup outputMixer;

		public AudioClip[] chargeSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		[ColorUsage(true, true)]
		public Color screenPlacerColor;

		[ColorUsage(true, true)]
		public Color screenRemoveerColor;

		public MeshRenderer[] gunBodyRenderers;

		[ColorUsage(true, true)]
		public Color placerValidColor;

		[ColorUsage(true, true)]
		public Color placerInvalidColor;

		public Transform placerRoot;

		public GameObject placerPreview;

		public GameObject placerPreview2;

		public MeshFilter placerPreviewMesh;

		public MeshFilter placerPreviewMesh2;

		public MeshRenderer placerPreivewRenderer;

		public BoxCollider placerPreviewBoxCollider;

		public GameObject placerPreviewBoundsArt;

		public LineRenderer[] placerPreviewBoundsLines;

		public Transform[] boundPoints;

		public float dampTimePos;

		public float dampTimeRot;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup mixerGroup;

		[SerializeField]
		private AudioClip[] blip;

		public float blipIncrement;

		private float _fanRPS;

		private SpawnableCrate _selectedCrate;

		private SpawnableCrate _lastSelectedCrate;

		private bool _isOptionsActive;

		private UtilityModes _selectedMode;

		private RaycastHit _hitInfo;

		private Hand currentHand;

		private float time;

		private Color startColor;

		private AudioPlayer ap;

		private AudioPlayer ap2;

		private bool canFireGunDown;

		private bool placerValid;

		private float colorLerpTime;

		private float screenColorLerpTime;

		private Color targetColor;

		private Color targetScreenColor;

		private Color boundColor;

		private Vector3 lastKneePos;

		private Vector3 kneeOffsetPos;

		private bool wallMode;

		private Vector3 truePlacePosition;

		private Quaternion truePlaceRotation;

		private Vector3 posVelocity;

		private Vector3 lastHitPoint;

		private float accumulatedDist;

		private static readonly int EmissionColor;

		private static readonly int ColorTint;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		public void SetFanRPM(float rpm)
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnCrate_003Ed__77))]
		private UniTaskVoid SpawnCrate(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Action<GameObject> callback = null)
		{
			return default(UniTaskVoid);
		}

		private void OnSpawnHandAttached(Hand hand)
		{
		}

		private void OnSpawnHandDetached(Hand hand)
		{
		}

		public void Flash()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFireFlash_003Ed__81))]
		private IEnumerator CoFireFlash()
		{
			return null;
		}

		protected void OnSpawnableSelected(SpawnableCrate crate)
		{
		}

		protected void OnModeSelect(UtilityModes mode)
		{
		}

		public override void Fire()
		{
		}

		protected override void OnFire()
		{
		}

		protected override void OnTriggerGripAttached(Hand hand)
		{
		}

		protected override void OnTriggerGripDetached(Hand hand)
		{
		}

		private void SetPreviewMesh()
		{
		}

		public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 vector, Vector3 point)
		{
			return default(Vector3);
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}
	}
}
