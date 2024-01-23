using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Props
{
	public class RadioAnnouncement : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003COverrideCoroutine_003Ed__17
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RadioAnnouncement _003C_003E4__this;

			public RadioSong overrideSong;

			private float _003Ctime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003COverrideCoroutine_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private static ComponentCache<RadioAnnouncement> _cache;

		public RadioManager radioManager;

		public AudioSource baseAudioPlayer;

		public AudioSource announcementAudioPlayer;

		public bool playAnnouncement;

		public RadioSong overrideClip;

		public AnimationCurve duckCurve;

		[Range(0f, 4f)]
		public float duckTime;

		private IEnumerator playOverride;

		private float cashedBaseVolume;

		public static ComponentCache<RadioAnnouncement> Cache => null;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void PLAYANNOUNCEMENT()
		{
		}

		public void RemotePlayAnnouncement(RadioSong overrideSong)
		{
		}

		[IteratorStateMachine(typeof(_003COverrideCoroutine_003Ed__17))]
		private IEnumerator OverrideCoroutine(RadioSong overrideSong)
		{
			return null;
		}
	}
}
