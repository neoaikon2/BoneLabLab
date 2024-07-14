using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_HandgunBox : BonelabInternalGameControl
	{
		public TextMeshProUGUI txt_Clock;

		public TextMeshProUGUI txt_Meridiem;

		private int sys_minutes;

		private DateTime time;

		public TextMeshProUGUI[] txt_Timer;

		public TextMeshProUGUI[] txt_Count;

		private bool startedTime;

		private float timeElapsed;

		private float timeSpeed;

		public TextMeshProUGUI[] txt_Timer_BEST;

		public TextMeshProUGUI[] txt_Timer_PREV;

		private float time_Best;

		private float time_Prev;

		public GameObject victoryBanner;

		private WaitForSecondsRealtime timecount;

		public GameObject obj_jumpToTimeTrial;

		public override void Awake()
		{
		}

		private new void Start()
		{
		}

		public void STARTTIMER()
		{
		}

		public void STOPTIMER()
		{
		}

		public void COMPLETETRIAL()
		{
		}

		private void FixedUpdate()
		{
		}
		private IEnumerator Timer()
		{
			return null;
		}

		public void ACHIEVEMENT_TIME_TEST()
		{
		}

		private int UpdateDeathCount()
		{
			return 0;
		}

		private void UpdateText()
		{
		}

		private void UpdateTimer()
		{
		}

		private void DisplayBestPrev()
		{
		}
	}
}
