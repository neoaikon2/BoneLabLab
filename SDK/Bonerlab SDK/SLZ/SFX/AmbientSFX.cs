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
	public class AmbientSFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFade_003Ed__30
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeTarget;

			public AmbientSFX _003C_003E4__this;

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

		public AudioMixerGroup mixerGroup;

		public AudioClip[] longPlay;

		public AudioClip powerUp;

		public AudioClip powerDown;

		[Range(0f, 1f)]
		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		public float volume;

		[Range(0f, 1f)]
		[Tooltip("Volume of power up event sounds")]
		public float powerUpVolume;

		[Range(0.1f, 4f)]
		[Tooltip("Higher number fades faster")]
		public float fadeSpeed;

		[Range(0f, 10f)]
		[Tooltip("Radius of min sphere")]
		public float sourceRadius;

		[Tooltip("Should source loop?")]
		public bool loop;

		[Tooltip("Should source restart when retriggered?")]
		public bool restartLoop;

		[Tooltip("Should source continue to play even if out of range?")]
		public bool playWhileInaudible;

		[Tooltip("Block trigger exits from stopping source?")]
		public bool blockTriggerExit;

		[Tooltip("Is the sound 2d or 3d?")]
		[Range(0f, 1f)]
		public float spatialBlend;

		private float _playheadTime;

		private float _syncTime;

		private float _baseVolume;

		private bool _fadeActive;

		private AudioPlayer _ap;

		public AudioPlayer audioPlayer => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void PowerUp(bool powerUpSound = false)
		{
		}

		public void PowerDown(bool powerDownSound = false)
		{
		}

		public void SetVolume(float attenuation, bool powerSound = false)
		{
		}

		public void SetVolumeDirect(float attenuation)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void PlayNew(Action callback = null)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		[IteratorStateMachine(typeof(_003CFade_003Ed__30))]
		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}
	}
}
