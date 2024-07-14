using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	public class Audio2dManager : MonoBehaviour
	{		public AmbAndMusic[] ambAndMusics;

		private int _curAmb;

		private int _curMus;

		private Coroutine _loopPending;

		private bool _isOverride;

		private bool _overridenHasIntro;

		private AudioClip _overridenMusicClip;

		private float _overridenTargetVol;

		private float _overridenFadeInTime;

		private float _overridenFadeOutTime;

		private bool _overridenLoop;

		private AudioClip _overridenMusicIntro;

		private float _overridenLoopTransitionFade;

		private IEnumerator _overrideCallback;

		private double _timecodeMusic;

		private double _timecodeAmbience;

		private float[] tempData;

		private float minFadeTime;

		private Coroutine fadeRoutine;

		public AudioMixer mixer;

		public AudioReverbData prevReverbObj;

		public AudioReverbData reverbObj;

		private void Awake()
		{
		}
		private UniTaskVoid LoadMixers()
		{
			return default(UniTaskVoid);
		}

		public void CueOverrideMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true, bool timedRelease = true)
		{
		}

		public void StopOverrideMusic()
		{
		}
		private IEnumerator OverrideCallback(float releaseTime)
		{
			return null;
		}

		public void CueAmbience(AudioClip ambienceClip, float targetVol = 0.1f, float fadeInTime = 3f, float fadeOutTime = 3f)
		{
		}

		public void CueAmbience(double timecode, AudioClip ambienceClip, float targetVol = 0.1f, float fadeInTime = 3f, float fadeOutTime = 3f)
		{
		}

		public void CueMusic(AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		public void CueMusic(double timecode, AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		private void CueMusicInternal(double timecode, AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		public void CueMusicLoopWithIntro(AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		public void CueMusicLoopWithIntro(double timecode, AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		public void StopMusic(float fadeOutTime = 3f)
		{
		}

		public void StopMusic(double timecode, float fadeOutTime = 3f)
		{
		}

		public bool StopSpecificMusic(AudioClip specificClip, double timecode, float fadeOutTime = 3f)
		{
			return false;
		}

		private void Update()
		{
		}
		private IEnumerator LoopCue(AudioClip loop, float introLength, float tranFade)
		{
			return null;
		}

		public float GetParamVal(string name, float value)
		{
			return 0f;
		}

		public void FadeToNewReverb(AudioReverbData reverbData)
		{
		}
		private IEnumerator CoFadeReverbData(float fadeTime)
		{
			return null;
		}

		private void StopFadeRoutine()
		{
		}
	}
}
