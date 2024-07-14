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
	[Serializable]
	public class ManagedAudioPlayer
	{
		private AudioPlayer _ap;

		private ulong _Id;

		private bool _apIncoming;

		private AudioClip _clip;

		private AudioMixerGroup _mixerGroup;

		private Transform _parent;

		private Vector3 _localPosition;

		private float _timecode;

		private float _volume;

		private float _pitch;

		private float _minDistance;

		private float _spatialBlend;

		private bool _looping;

		public float volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isPlaying => false;

		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public AudioClip clip => null;

		private void PlayAtPointInternal(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}
		private UniTask<AudioPlayer> SpawnAudio()
		{
			return default(UniTask<AudioPlayer>);
		}

		private void LoopAtPointInternal(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}
		private UniTask<AudioPlayer> SpawnAudioLoop()
		{
			return default(UniTask<AudioPlayer>);
		}

		private void PlayAtLocalPointInternal(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}
		private UniTask<AudioPlayer> SpawnLocalAudio()
		{
			return default(UniTask<AudioPlayer>);
		}

		private void LoopAtLocalPointInternal(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}
		private UniTask<AudioPlayer> SpawnLocalAudioLoop()
		{
			return default(UniTask<AudioPlayer>);
		}

		public void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void PlayAtPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void LoopAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void PlayAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void PlayAtLocalPoint(AudioClip[] clips, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void PlayAtLocalPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void LoopAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		public void Stop()
		{
		}
	}
}
