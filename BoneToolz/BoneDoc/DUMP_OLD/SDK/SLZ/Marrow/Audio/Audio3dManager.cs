using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	public class Audio3dManager : MonoBehaviour
	{
		private static float audio_GlobalVolume;

		private static float audio_MusicVolume;

		private static float audio_SFXVolume;

		public static AudioMixerGroup softInteraction { get; private set; }

		public static AudioMixerGroup ambience { get; private set; }

		public static AudioMixerGroup inHead { get; private set; }

		public static AudioMixerGroup ui { get; private set; }

		public static AudioMixerGroup gunShot { get; private set; }

		public static AudioMixerGroup impact { get; private set; }

		public static AudioMixerGroup bulletImpact { get; private set; }

		public static AudioMixerGroup diegeticMusic { get; private set; }

		public static AudioMixerGroup footsteps { get; private set; }

		public static AudioMixerGroup hardInteraction { get; private set; }

		public static AudioMixerGroup shells { get; private set; }

		public static AudioMixerGroup npcVocals { get; private set; }

		public static AudioMixerGroup nonDiegeticMusic { get; private set; }

		public static float audio_Master
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static float audio_Music
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static float audio_SFX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private UniTaskVoid LoadMixers()
		{
			return default(UniTaskVoid);
		}

		public static void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtPoint(AudioClip clip, AudioClip clipHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtLocalPoint(AudioClip[] clips, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtLocalPoint(AudioClip clip, AudioClip clipHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void PlayAtLocalPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
		}

		public static void Play2dOneShot(AudioClip clip, AudioMixerGroup mixerGroup, float? volume = default(float?), float? pitch = default(float?))
		{
		}

		public static void Play2dOneShot(AudioClip[] clips, AudioMixerGroup mixerGroup, float? volume = default(float?), float? pitch = default(float?))
		{
		}

		private static UniTask<AudioPlayer> PlayAtPointAsync(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float? volume = default(float?), float? pitch = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
			return default(UniTask<AudioPlayer>);
		}

		private static UniTask<AudioPlayer> PlayAtLocalPointAsync(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float? volume = default(float?), float? pitch = default(float?), float? minDistance = default(float?), float? spatialBlend = default(float?))
		{
			return default(UniTask<AudioPlayer>);
		}

		private static UniTask<AudioPlayer> Play2dOneShotAsync(AudioClip clip, AudioMixerGroup mixerGroup, float? volume = default(float?), float? pitch = default(float?))
		{
			return default(UniTask<AudioPlayer>);
		}

		public static void SpawnAudioPlayer(Vector3 position = default(Vector3), Action<GameObject> callback = default(Action<GameObject>))
		{
		}

		public void SetLowPassFilter(float lpf)
		{
		}

		private static void SETMIXERS()
		{
		}

		public Audio3dManager()
			: base()
		{
		}
	}
}
