using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Music")]
	public class ZoneMusic : ZoneLinkItem
	{
		[FormerlySerializedAs("clipToCue")]
		[Header("ZoneMusic")]
		[Tooltip("Track to play.")]
		public AudioClip clipMain;

		[Tooltip("Track to play.")]
		public DataCardReference<MonoDisc> track;

		[Range(0f, 1f)]
		[Tooltip("Recommended to keep volume below .3! You need to leave headroom for gunshots and impacts above your music, only turn higher if track is mixed quietly.")]
		public float volume;

		[Header("Music Actions")]
		[Tooltip("Play track when entering zone. Fades in for fadeInTime.")]
		public bool playOnEnter;

		[Tooltip("Stop current track when entering zone. Fades out for fadeOutTime.")]
		public bool stopOnEnter;

		[Tooltip("Stop current track when exiting zone. Fades out for fadeOutTime.")]
		public bool stopOnExit;

		[Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
		[Range(0.1f, 10f)]
		public float fadeInTime;

		[Range(0.1f, 10f)]
		[Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
		public float fadeOutTime;

		[FormerlySerializedAs("onlyPlayOnce")]
		[Tooltip("Select to only trigger music actions the first time this zone is triggered. Defaulted to true because I love it. - Brandon")]
		public bool onlyTriggerOnce;

		[Header("Looping options")]
		[Tooltip("Select to loop track until something else plays or a ZoneMusic with StopOnEnter/Exit is triggered. Defaulted to false because it's better to leave them wanting more - Brandon")]
		public bool loop;

		[Tooltip("Optional intro track that will only play a single time before clip main is played. Useful if you want to have an attention grabbing intro that blends into a main body that cleanly loops.")]
		public AudioClip clipIntro;

		[Tooltip("Optional intro track that will only play a single time before clip main is played. Useful if you want to have an attention grabbing intro that blends into a main body that cleanly loops.")]
		public DataCardReference<MonoDisc> introTrack;

		private bool _hasPlayedOnce;

		[HideInInspector]
		public static bool zoneMusicPasted;

		private void Play()
		{
		}

		private UniTaskVoid PlayMainAsync(double timecode)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid PlayIntroMainAsync(double timecode)
		{
			return default(UniTaskVoid);
		}

		public void PlayMusic(float fadeTime)
		{
		}

		public void StopMusic(float fadeTime)
		{
		}

		private void Stop()
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		public ZoneMusic()
			: base()
		{
		}
	}
}
