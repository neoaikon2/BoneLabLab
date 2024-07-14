using SLZ.Data;
using UnityEngine;

namespace SLZ.Marrow.Audio
{
	public class FootstepSFX : MonoBehaviour
	{
		public float volumeMult;

		public AudioClip[] walkConcrete;

		public AudioClip[] runConcrete;

		public AudioVarianceData walkOverride;

		public AudioVarianceData runOverride;

		private AudioSource source;

		private void Awake()
		{
		}

		public void PlayStep(float velocitySqr)
		{
		}
	}
}
