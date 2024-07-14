using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.SFX
{
	public class AmbientSFX : MonoBehaviour
	{
		public AudioClip[] longPlay;

		public AudioClip powerUp;

		public AudioClip powerDown;

		[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
		[Range(0f, 1f)]
		public float volume;

		[Range(0f, 1f)]
		[Tooltip("Volume of power up event sounds")]
		public float powerUpVolume;

		[Tooltip("Higher number fades faster")]
		[Range(0.1f, 4f)]
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

		[Range(0f, 1f)]
		[Tooltip("Is the sound 2d or 3d?")]
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
		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}
	}
}
