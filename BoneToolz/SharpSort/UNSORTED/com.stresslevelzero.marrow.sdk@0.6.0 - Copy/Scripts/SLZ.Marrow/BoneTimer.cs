using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UltEvents;
using UnityEngine;

public class BoneTimer : MonoBehaviour
{
	public enum TimerMode
	{
		COUNT_UP = 0,
		COUNT_DOWN = 1,
		COUNT_UP_REALTIME = 2,
		REALTIME = 3
	}
	[Header("Time Data")]
	[SerializeField]
	private float timerValue;

	[SerializeField]
	private List<float> sessionTimeList;

	private Coroutine timerRoutine;

	public TimerMode timerMode;

	private bool isSessionOngoing;

	public UltEvent OnStartTimer;

	public UltEvent<float> OnStopTimer;

	public UltEvent<float> OnNewSession;

	private int currSession;

	public float TimerValue => 0f;

	[ContextMenu("StartTimer")]
	public void StartTimerSession()
	{
	}

	[ContextMenu("StopTimer")]
	public void StopTimerSession()
	{
	}

	[ContextMenu("StartNewSession")]
	public void StartNewSession()
	{
	}
	private IEnumerator CoTimerUp()
	{
		return null;
	}
	private IEnumerator CoTimerUpRealtime()
	{
		return null;
	}
	private IEnumerator CoTimerDown()
	{
		return null;
	}
	private IEnumerator CoTimerRealtime()
	{
		return null;
	}
}
