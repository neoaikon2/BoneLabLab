using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class BowlingResetMechanism : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CScoreAndResetCoroutine_003Ed__30
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BowlingResetMechanism _003C_003E4__this;

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
			public _003CScoreAndResetCoroutine_003Ed__30(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CPinResetCycle_003Ed__37
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BowlingResetMechanism _003C_003E4__this;

			private ConfigurableJoint[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CPinResetCycle_003Ed__37(int _003C_003E1__state)
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

		public GameObject[] pins;

		private ConfigurableJoint[] joints;

		private ConfigurableJoint[] closeJoints;

		public Vector3 jointDriveSettings;

		public float cycleTime;

		public float maxResetTime;

		public float scoreTimmer;

		public float posEpsilon;

		public float rotEpsilon;

		private IEnumerator pinCycle;

		private JointDrive minDrive;

		private JointDrive maxDrive;

		public Collider[] pinColliders;

		public PhysicMaterial normalFriction;

		public PhysicMaterial noFriction;

		public AudioMixerGroup outputMixer;

		public AudioClip pullSFX;

		public AudioClip dropSFX;

		private AudioPlayer ap;

		public SpawnableCrateReference[] whiteListCrates;

		private Dictionary<string, int> whiteListObjects;

		private Dictionary<int, AssetPoolee> objectsInTrigger;

		private List<AssetPoolee> objectsToSweep;

		private Vector3[] pinOriginalPos;

		private bool isScoring;

		private bool isPlayerInTrigger;

		private bool isBallInTrigger;

		public UnityEvent BowlingAchUnlock;

		public void Start()
		{
		}

		public void PINAWOKEN()
		{
		}

		[IteratorStateMachine(typeof(_003CScoreAndResetCoroutine_003Ed__30))]
		private IEnumerator ScoreAndResetCoroutine()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private int CheckScore()
		{
			return 0;
		}

		private bool PinDownCheck(GameObject pin)
		{
			return false;
		}

		private void CheckPinReset()
		{
		}

		public void RESETPINS()
		{
		}

		[IteratorStateMachine(typeof(_003CPinResetCycle_003Ed__37))]
		private IEnumerator PinResetCycle()
		{
			return null;
		}
	}
}
