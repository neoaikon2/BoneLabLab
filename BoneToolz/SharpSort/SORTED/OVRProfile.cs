using System;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_profile")]
public class OVRProfile : UnityEngine.Object
{
	[Obsolete]
	public enum State
	{
		NOT_TRIGGERED = 0,
		LOADING = 1,
		READY = 2,
		ERROR = 3
	}

	[Obsolete]
	public string id => null;

	[Obsolete]
	public string userName => null;

	[Obsolete]
	public string locale => null;

	public float ipd => 0f;

	public float eyeHeight => 0f;

	public float eyeDepth => 0f;

	public float neckHeight => 0f;

	[Obsolete]
	public State state => default(State);
}
