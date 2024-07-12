using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class Zone3dSound : ZoneLinkItem
	{
		public enum SoundMode
		{
			CONTINUOUS = 0,
			ONE_SHOT = 1,
			PLAY_ON_ENTER = 2
		}

		public SoundMode soundMode;

		public Transform[] targetTran;

		[HideInInspector]
		public AudioClip clip;

		[Tooltip("More than one clip will randomize for PLAY_ON_ENTER mode")]
		public AudioClip[] clips;

		[Range(0f, 1f)]
		public float primaryVolume;

		[Range(0f, 1f)]
		public float secondaryVolume;

		public float pitch;

		[Range(0.1f, 4f)]
		[Tooltip("Higher number fades faster")]
		public float fadeSpeed;

		[Range(0.1f, 10f)]
		[Tooltip("Radius of min sphere")]
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

		public AudioPlayer audioPlayer
		{
			get
			{
				return null;
			}
		}

		public void SetSecondaryVolume(float volume)
		{
		}

		protected override void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		private void PlayNew(Action callback = default(Action))
		{
		}

		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		private float randomizeFloat(float max, float minMultiplier)
		{
			return default(float);
		}

		public void StopSound()
		{
		}

		public void PlaySound()
		{
		}

		public Zone3dSound()
			: base()
		{
		}
	}
}
