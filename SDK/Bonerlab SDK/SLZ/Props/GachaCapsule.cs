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
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass50_0
		{
			public Crate crate;

			internal void _003CPopFXAsync_003Eb__0(GameObject go)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopFXAsync_003Ed__50
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaCapsule _003C_003E4__this;

			private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

			public Spawnable effect;

			private UniTask<Crate>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDespawnTimmer_003Ed__51
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GachaCapsule _003C_003E4__this;

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
			public _003CDespawnTimmer_003Ed__51(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetPreviewMesh_003Ed__53
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaCapsule _003C_003E4__this;

			private UniTask<SpawnableCrate>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ComponentCache<GachaCapsule> _cache;

		public SphereGrip grip;

		public ObjectDestructable objDestruct;

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

		[SerializeField]
		[Range(0f, 1f)]
		private float amplitudeMin;

		[Range(0f, 1f)]
		[SerializeField]
		private float amplitudeMax;

		[Range(0f, 2000f)]
		[SerializeField]
		private float frequencyMin;

		[SerializeField]
		[Range(0f, 2000f)]
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

		private Hand lastHand;

		public static ComponentCache<GachaCapsule> Cache => null;

		private static PlayerUnlocks u => null;

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

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		public void UnlockItemDest()
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

		[AsyncStateMachine(typeof(_003CPopFXAsync_003Ed__50))]
		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}

		[IteratorStateMachine(typeof(_003CDespawnTimmer_003Ed__51))]
		private IEnumerator DespawnTimmer()
		{
			return null;
		}

		private void ReleasePreviewMesh()
		{
		}

		[AsyncStateMachine(typeof(_003CSetPreviewMesh_003Ed__53))]
		public UniTaskVoid SetPreviewMesh()
		{
			return default(UniTaskVoid);
		}
	}
}
