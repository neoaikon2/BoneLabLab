using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BoneTimerDisplay : MonoBehaviour
{
	public BoneTimer boneTimer;

	[SerializeField]
	protected TimeSpan tsTimerValue;

	[SerializeField]
	private bool showMilliseconds;

	private string tsTimerString;

	private float lastDisplayTime;

	private float minDisplayTime;

	public List<TMP_Text> timerTexts;

	private Coroutine updateRoutine;

	private void Start()
	{
	}
	private IEnumerator CoUpdateDisplay()
	{
		return null;
	}

	private void UpdateTimeDisplay(float timerValue)
	{
	}
}
