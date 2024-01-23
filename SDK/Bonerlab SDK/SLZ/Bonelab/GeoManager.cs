using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Bonelab
{
	public class GeoManager : MonoBehaviour
	{
		public enum GeoState
		{
			CLEARED = 0,
			MOVING = 1,
			UP = 2,
			MOVING_TO_CLEAR = 3
		}

		[CompilerGenerated]
		private sealed class _003CCoDelayedMoveNext_003Ed__26
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float timeDelay;

			public GeoManager _003C_003E4__this;

			public int index;

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
			public _003CCoDelayedMoveNext_003Ed__26(int _003C_003E1__state)
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

		public GeoState geoState;

		public GeoMover activeGeoMover;

		[SerializeField]
		private AudioMixerGroup mixerGroup;

		[SerializeField]
		private AudioClip moveGeoClip;

		[SerializeField]
		private AudioPlayer _loopAudioPlayer;

		public List<GeoMover> geoMoverList;

		[SerializeField]
		private GeoMover deathPitGeoMover;

		[SerializeField]
		private GeoMover deathPitFloorMover;

		public GameObject geoMoverPrefab;

		private int _currMoverIndex;

		public int currGeoIndex;

		public static Action OnMoveUpComplete;

		public Dictionary<string, int> geoDict;

		public Dictionary<string, GeoMover> geoMoverDict;

		public int moverIndex => 0;

		public void Awake()
		{
		}

		[ContextMenu("IncrementAndToggleGeo")]
		public void IncrementAndToggleGeo()
		{
		}

		public void IncrementGeoIndex()
		{
		}

		public void SelectGeo(string geoTitle)
		{
		}

		public void ClearCurrentGeo()
		{
		}

		public void ToggleGeo(int index)
		{
		}

		public void ToggleAudio(bool startPlaying, bool pitchShift = false)
		{
		}

		public void MoveUpComplete(GeoMover geoMover)
		{
		}

		public void MoveDownComplete(GeoMover geoMover)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayedMoveNext_003Ed__26))]
		private IEnumerator CoDelayedMoveNext(float timeDelay, int index)
		{
			return null;
		}
	}
}
