using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using SLZ.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class BasicSeatTrigger : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CYoinkCoroutine_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BasicSeatTrigger _003C_003E4__this;

			private float _003CyoinkTime_003E5__2;

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
			public _003CYoinkCoroutine_003Ed__24(int _003C_003E1__state)
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

		public RigManager rM;

		public Seat seat;

		public Rigidbody rb;

		public ConfigurableJoint jnt;

		public Transform statTransform;

		public Transform endTransform;

		public float seatingLength;

		public float yoinkLength;

		public AnimationCurve lerpSpeedCurve;

		public AudioMixerGroup outputMixer;

		public AudioClip[] startSFX;

		public AudioClip[] endSFX;

		public LayerMask castLayers;

		public float initialGravityPulse;

		public float initialRandomTorque;

		public float velocityMultiplier;

		private bool isSeated;

		private bool endSound;

		private AudioPlayer ap1;

		private AudioPlayer ap2;

		private IEnumerator yoinkCoroutine;

		private List<Rigidbody> rigidbodies;

		public void EnterSeat()
		{
		}

		public void Yoink()
		{
		}

		[IteratorStateMachine(typeof(_003CYoinkCoroutine_003Ed__24))]
		private IEnumerator YoinkCoroutine()
		{
			return null;
		}

		private void GatherRBs()
		{
		}

		private void NullRBGravity()
		{
		}

		private void UpdateRBVelocity(float velocity)
		{
		}
	}
}
