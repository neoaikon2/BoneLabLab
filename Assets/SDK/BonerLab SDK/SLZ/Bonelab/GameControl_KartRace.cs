using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.SFX;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_KartRace : BonelabAvatarLevelGameControl
	{
		[Header("WORLD SETTINGS")]
		public AudioClip raceMusic;

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

		private bool raceStarted;

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

		private Coroutine timerRoutine;

		public override void DoLevelComplete()
		{
		}

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		public void FinishLineTrigger()
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
	}
}
