using System;
using UnityEngine;

namespace SLZ.Marrow.Audio
{
	[Serializable]
	public class AmbAndMusic
	{
		public AudioSource ambMus;

		public AudioClip clip;

		public bool isFading;

		public float fadeTarget;

		public float fadePerSec;

		public void UpdateFade()
		{
		}

		public void FadeOut(float fadeOutTime)
		{
		}

		public void FadeIn(AudioClip ambClip, float fadeTar, float fadeInTime)
		{
		}

		public void AttenuateCurrent(float fadeTar, float fadeInTime)
		{
		}
	}
}
