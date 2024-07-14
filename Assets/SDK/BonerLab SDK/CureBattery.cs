using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class CureBattery : MonoBehaviour
{
	[SerializeField]
	private Grip[] _grips;

	[SerializeField]
	private bool wasGrabbed;

	public GameObject lightBeam;

	public CureMachinePowerable cureMachine;

	public float delayTime;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
	private IEnumerator CoBatteryIndicator()
	{
		return null;
	}

	private void OnGrab(Hand hand)
	{
	}
}
