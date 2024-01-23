using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Utilities
{
	public class AudioPlayer : SpawnEvents
	{
		private static ComponentCache<AudioPlayer> _cache;

		[SerializeField]
		private AudioSource _source;

		private bool _hasStartedPlaying;

		private AudioMixerGroup _defaultMixerGroup;

		private float _defaultVolume;

		private bool _defaultLoop;

		private float _defaultPitch;

		private float _defaultMinDistance;

		private float _defaultSpatialBlend;

		private float _defaultDopplerLevel;

		private const float _lowPitchRange = 0.88f;

		private const float _highPitchRange = 1.12f;

		public static ComponentCache<AudioPlayer> Cache => null;

		public AudioSource source => null;

		protected void Awake()
		{
		}

		protected override void OnDespawn(GameObject go)
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public static void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null)
		{
		}

		public static void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null)
		{
		}

		public void Play(AudioClip clip, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		public void Play(AudioClip[] clips, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		public void Attenuate(float? volume = null, float? pitch = null, float? minDistance = null)
		{
		}

		public void Stop()
		{
		}

		public void SetSpatialBlend(float blend)
		{
		}
	}
}
