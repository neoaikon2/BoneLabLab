using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

public class SwingJointManager : ZoneLinkItem
{
	public SwingJointInverter[] swingObjs;

	public float delay;

	public bool reset;

	private bool start;

	private bool _deathReset;

	private void Awake()
	{
	}
	
	[ContextMenu("Start Stuff")]
	private void StartStuff()
	{
	}
	private IEnumerator FullFrame()
	{
		return null;
	}

	public void DeathReset()
	{
	}
	public IEnumerator CoEnableSwingers()
	{
		return null;
	}
}
