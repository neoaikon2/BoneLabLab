using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;

namespace SLZ.SFX
{
	public class GravGunSFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CUpdateGravHold_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GravGunSFX _003C_003E4__this;

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
			public _003CUpdateGravHold_003Ed__24(int _003C_003E1__state)
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

		public AudioClip[] gravFire;

		public AudioClip grab;

		public AudioClip release;

		public AudioClip[] gravLocked;

		public AudioClip[] gravDrop;

		public AudioClip holdLoop;

		private float _targetVolume;

		private AudioPlayer _ap;

		private WaitForSecondsRealtime _wait;

		private Coroutine updateGravHoldCoroutine;

		public float publicPitchModifier;

		private float pitchModifier;

		private bool isGravPull;

		private void OnEnable()
		{
		}

		public void Grab()
		{
		}

		public void GravLocked()
		{
		}

		public void GravFire()
		{
		}

		public void GravDrop()
		{
		}

		public void GravPull()
		{
		}

		public void GravRelax()
		{
		}

		public void Release()
		{
		}

		public void SetPitchModifier(float pitch)
		{
		}

		public void StopSound()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateGravHold_003Ed__24))]
		private IEnumerator UpdateGravHold()
		{
			return null;
		}
	}
}
