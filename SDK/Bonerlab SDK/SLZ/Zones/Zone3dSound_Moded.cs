using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Zones
{
	public class Zone3dSound_Moded : ZoneItem
	{
		public enum SoundMode
		{
			CONTINUOUS = 0,
			ONE_SHOT = 1,
			PLAY_ON_ENTER = 2
		}

		[CompilerGenerated]
		private sealed class _003CFade_003Ed__30
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Zone3dSound_Moded _003C_003E4__this;

			public float fadeTarget;

			public float fadeTime;

			private WaitForSecondsRealtime _003Cwait_003E5__2;

			private float _003CfadeTargetClamped_003E5__3;

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
			public _003CFade_003Ed__30(int _003C_003E1__state)
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

		public SoundMode soundMode;

		public Transform[] targetTran;

		[HideInInspector]
		public AudioClip clip;

		[Tooltip("More than one clip will randomize for PLAY_ON_ENTER mode")]
		public AudioClip[] clips;

		public AudioMixerGroup mixerGroup;

		[Range(0f, 1f)]
		public float primaryVolume;

		[Range(0f, 1f)]
		public float secondaryVolume;

		public float pitch;

		[Range(0.1f, 4f)]
		[Tooltip("Higher number fades faster")]
		public float fadeSpeed;

		[Tooltip("Radius of min sphere")]
		[Range(0.1f, 10f)]
		public float sourceRadius;

		private bool loop;

		private bool hasPlayed;

		private bool _fadeActive;

		private bool _inPrimary;

		private AudioPlayer _ap;

		private float _curVol;

		[Tooltip("0 = no delays, any other value, will cause wait to happen randomly between value and 50% of value")]
		public float waitTime;

		private float _nextFirable;

		private bool _useRandomClip;

		private int _randomClipIndex;

		private int _randomTransformIndex;

		public AudioPlayer audioPlayer => null;

		public void SetSecondaryVolume(float volume)
		{
		}

		public override void OnSecondaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		private void PlayNew(Action callback = null)
		{
		}

		[IteratorStateMachine(typeof(_003CFade_003Ed__30))]
		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		private float randomizeFloat(float max, float minMultiplier)
		{
			return 0f;
		}

		public void StopSound()
		{
		}

		public void PlaySound()
		{
		}
	}
}
