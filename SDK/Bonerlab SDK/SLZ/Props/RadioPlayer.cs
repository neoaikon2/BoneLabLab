using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Props
{
	public class RadioPlayer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlayRadioAudio_003Ed__19
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RadioPlayer _003C_003E4__this;

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
			public _003CPlayRadioAudio_003Ed__19(int _003C_003E1__state)
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

		private static ComponentCache<RadioPlayer> _cache;

		public RadioSong overrideClip;

		private int cur_station;

		private int cur_track;

		[HideInInspector]
		public RadioStation[] stations;

		public RadioStation? selectedStation;

		public RadioManager radioManager;

		public AudioSource audioPlayer;

		public float desyncBufferTime;

		public WaitForSecondsRealtime checkTime;

		public bool playAnnouncement;

		private float _lastTimeScale;

		public static ComponentCache<RadioPlayer> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void PlayNextStation()
		{
		}

		public void BackupAudioPlay()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayRadioAudio_003Ed__19))]
		private IEnumerator PlayRadioAudio()
		{
			return null;
		}

		public void PLAYANNOUNCEMENT()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void CHECKRADIOSTATION()
		{
		}
	}
}
