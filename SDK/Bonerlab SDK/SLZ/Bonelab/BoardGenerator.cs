using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Props;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class BoardGenerator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003Clineloop_003Ed__41
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoardGenerator _003C_003E4__this;

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
			public _003Clineloop_003Ed__41(int _003C_003E1__state)
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

		[SerializeField]
		private bool isUsingAmmo;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private Transform FirePoint;

		[SerializeField]
		private float RaycastDistance;

		[SerializeField]
		private float breakforce;

		[SerializeField]
		private Material LineMaterial;

		[SerializeField]
		private Spawnable boardSpawnable;

		[SerializeField]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private GameObject laserPointer;

		public AudioMixerGroup outputMixer;

		public AudioClip[] startSFX;

		public AudioClip[] endSFX;

		public AudioClip[] misfireSFX;

		private AudioPlayer ap;

		private bool ButtonDown;

		private bool Valid;

		private Vector3 firstPoint;

		private Vector3 EndPoint;

		private Rigidbody FirstRb;

		private Rigidbody EndRb;

		private float distance;

		public float ammoDistance;

		private Vector3 upDir;

		public LineRenderer line;

		private int playerLayer;

		private int enemyLayer;

		public HashSet<ObjectDestructable> destBoardHash;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void BoardSpawner(int idx, float mass)
		{
		}

		private void OnBoardDestruction(ObjectDestructable destObj)
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

		private void PrimaryButtonDown()
		{
		}

		private void PrimaryButtonUp()
		{
		}

		public void CeaseFire()
		{
		}

		private void Thingy()
		{
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		[IteratorStateMachine(typeof(_003Clineloop_003Ed__41))]
		private IEnumerator lineloop()
		{
			return null;
		}

		private Joint SetJoint(Vector3 position, Rigidbody rigidbody, Rigidbody sourceRB)
		{
			return null;
		}
	}
}
