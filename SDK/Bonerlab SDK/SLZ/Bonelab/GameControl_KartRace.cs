using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.SFX;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class GameControl_KartRace : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003CStartTimer_003Ed__46
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_KartRace _003C_003E4__this;

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
			public _003CStartTimer_003Ed__46(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__52
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_KartRace _003C_003E4__this;

			public AvatarCrate avatarCrate;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public RigManager rm;

		private MusicAmbience2dSFX mA2d;

		public AvatarCrateReference avatarOverride;

		[Header("WORLD SETTINGS")]
		public Transform sunLight;

		public ZoneMusic zoneMusic;

		public AudioClip raceMusic;

		public AudioClip exploreMusic;

		public GameObject coreKey;

		private float _elapsedLapTime;

		private float _elapsedSumOfLapTimesTotal;

		[Header("LAPS")]
		public int totalLaps;

		public TextMeshPro[] txt_CurrentLap;

		public TextMeshPro[] txt_CurrentLapTime;

		public TextMeshPro[] txt_lapTimes;

		public TextMeshPro[] txt_totalTime;

		public float[] lapTimes;

		private int _lapIndex;

		private float _sumOfLaps_Current;

		[Header("CHECKPOINTS")]
		public bool[] trackCheckPoint;

		public GameObject trigger_StartRace;

		public GameObject trigger_NewLap;

		private bool finishedRace;

		[Header("BESTS")]
		private float _sumOfLaps_SessionBest;

		private float _sumOfLaps_PersonalBest;

		public TextMeshPro[] txt_totalTime_SessionBest;

		public TextMeshPro[] txt_totalTime_PersonalBest;

		[Header("AFFIRMATIONS")]
		public GameObject aff_Start;

		public GameObject aff_Finish;

		public ParticleSystem confettiFinish;

		public ParticleSystem confettiLap;

		public ParticleSystem confettiStart;

		private SimpleSFX confettiFinish_sfx;

		private SimpleSFX confettiLap_sfx;

		private SimpleSFX confettiStart_sfx;

		public GameObject[] LoadButtons;

		public GameObject[] LoadButtonsForComplete;

		[SerializeField]
		private GenericCrateReference unlockCrate;

		[FormerlySerializedAs("avatarGatcha")]
		[SerializeField]
		private GameObject avatarGacha;

		private Coroutine timerRoutine;

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		public void STARTRACE()
		{
		}

		public void NEWLAP()
		{
		}

		public void RESETRACE()
		{
		}

		public void ENDRACE()
		{
		}

		public void TRACKCHECKPOINT(int checkpoint)
		{
		}

		[IteratorStateMachine(typeof(_003CStartTimer_003Ed__46))]
		private IEnumerator StartTimer()
		{
			return null;
		}

		public void WIPE_PB()
		{
		}

		private void UI_DisplayLaps()
		{
		}

		private void UI_DisplayLapTime()
		{
		}

		private void UI_DisplayBests()
		{
		}

		public void SwitchAvatar()
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__52))]
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}

		public override void DoLevelComplete()
		{
		}

		private void ButtonsSetup()
		{
		}

		public void ObjectiveCompleteSetup()
		{
		}
	}
}
