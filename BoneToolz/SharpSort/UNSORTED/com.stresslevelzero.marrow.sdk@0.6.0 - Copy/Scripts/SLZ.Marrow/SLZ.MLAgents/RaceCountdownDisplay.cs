using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class RaceCountdownDisplay : MonoBehaviour
	{
		public GameObject[] displayNumberPrefabs;

		public GameObject[] displayNumbers;

		public float uiScale;

		[Range(1f, 5f)]
		public int totalSeconds;

		private float currentSeconds;

		private int currentDisplayInd;

		public event Action CountdownCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action CountdownTick
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		[ContextMenu("Start Countdown")]
		public void StartCountdown()
		{
		}

		[ContextMenu("Countdown Complete")]
		public void NoCountdown()
		{
		}
		private IEnumerator Countdown()
		{
			return null;
		}
	}
}
