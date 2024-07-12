using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Ambience")]
	public class ZoneAmbience : ZoneLinkItem
	{
		[Tooltip("Ambience to play.")]
		[Header("Ambience")]
		public AudioClip clipMain;

		[Tooltip("Ambience to play.")]
		public DataCardReference<MonoDisc> ambientTrack;

		[Range(0f, 1f)]
		[Tooltip("Recommended range is .05 to .25! You need to leave headroom for gunshots, impacts and music above your ambience, only turn higher if track is mixed quietly.")]
		public float volume;

		[Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
		[Range(0.25f, 10f)]
		public float fadeInTime;

		[Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
		[Range(0.25f, 10f)]
		public float fadeOutTime;

		[Header("Reverb")]
		[FormerlySerializedAs("reverbObj")]
		public AudioReverbData reverbSettings;

		[HideInInspector]
		public static bool zoneAmbiencePasted;

		[ContextMenu("BakeCurrentToDataObj")]
		public void GetAllValues()
		{
		}

		public float GetParamVal(string name, float value)
		{
			return default(float);
		}

		[ContextMenu("SetAllData")]
		public void SetAllValues()
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		private void Play()
		{
		}

		private UniTaskVoid PlayMainAsync(double timecode)
		{
			return default(UniTaskVoid);
		}

		public ZoneAmbience()
			: base()
		{
		}
	}
}
