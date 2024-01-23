using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class DoorPortalController : MonoBehaviour
	{
		[Serializable]
		public class DoorControlGroup
		{
			public HubDoorController[] doorControls;
		}

		[CompilerGenerated]
		private sealed class _003CDoorSequence_003Ed__45
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DoorPortalController _003C_003E4__this;

			private Vector3 _003CstartPos_003E5__2;

			private Vector3 _003CendPos_003E5__3;

			private float _003CyoinkTime_003E5__4;

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
			public _003CDoorSequence_003Ed__45(int _003C_003E1__state)
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

		public Seat seat;

		public Rigidbody rb;

		public GameObject[] modules;

		public DoorControlGroup[] doorControlGroups;

		public float seatingLength;

		public float yoinkLength;

		public Spawnable vfxFadeOutSpawnable;

		public LevelCrateReference loadScreenLevel;

		public AnimationCurve lerpSpeedCurve;

		public AnimationCurve lerpDistanceCurve;

		public AnimationCurve lerpHeightCurve;

		public AnimationCurve frameCurve;

		public GameObject targetRot;

		public AudioMixerGroup outputMixer;

		public AudioClip[] doorSFX;

		public AudioClip portalSFX;

		private AudioPlayer ap1;

		private AudioPlayer ap2;

		public Transform hingLeft;

		public Transform hingeRight;

		private RigManager rM;

		private IEnumerator sequence;

		private GameObject[] stencils;

		private GameObject[] blockers;

		private GameObject[] targets;

		private GameObject fx;

		private int moduleIndex;

		private Renderer fxRenderer;

		private float sequenceStartTime;

		private GameObject target;

		private LevelCrate level;

		private float animTime;

		private int triggerLayer;

		private bool isLoading;

		private bool isSeated;

		private bool portalSound;

		private Vector3 debugGizmo1;

		private Vector3 debugGizmo2;

		private Vector3 debugGizmo3;

		private Vector3 debugGizmo4;

		private Vector3 debugGizmo5;

		private Vector3 debugGizmo6;

		private void Start()
		{
		}

		public void SETUPLOAD(LevelCrate levelIn, int index)
		{
		}

		[IteratorStateMachine(typeof(_003CDoorSequence_003Ed__45))]
		private IEnumerator DoorSequence()
		{
			return null;
		}

		public Vector3 FindNearestPointOnLineAndOffset(Vector3 origin, Vector3 vector, Vector3 point, float offset)
		{
			return default(Vector3);
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
