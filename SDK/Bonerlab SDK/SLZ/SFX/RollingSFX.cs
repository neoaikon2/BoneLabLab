using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.SFX
{
	public class RollingSFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateSound_003Ed__19
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RollingSFX _003C_003E4__this;

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
			public _003CUpdateSound_003Ed__19(int _003C_003E1__state)
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

		public Rigidbody[] wheels;

		public AudioMixerGroup outputMixer;

		public GameObject sourceObj;

		public float maxAngularV;

		public float realtimeUpdateFrequency;

		public float wheelRadius;

		public float minSpeed;

		public float maxSpeed;

		private AudioPlayer _ap;

		private bool _hasAp;

		public AudioClip spinningNotColliding;

		public AudioClip rollingWithCollision;

		private bool wheelColliding;

		private WaitForSecondsRealtime _wfsRealtime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter()
		{
		}

		private void OnCollisionExit()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateSound_003Ed__19))]
		private IEnumerator UpdateSound()
		{
			return null;
		}
	}
}
