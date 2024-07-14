using System;
using UnityEngine;

public class OVRRuntimeSettings : ScriptableObject
{
	private static OVRRuntimeSettings _instance;

	public OVRManager.ColorSpace colorSpace;

	[SerializeField]
	private bool requestsVisualFaceTracking;

	[SerializeField]
	private bool requestsAudioFaceTracking;

	[SerializeField]
	private bool hasSentConsentEvent;

	[SerializeField]
	private bool hasSetTelemetryEnabled;

	[SerializeField]
	private bool telemetryEnabled;

	[SerializeField]
	private string telemetryProjectGuid;

	internal Action<bool> OnTelemetrySet;

	[SerializeField]
	private OVRPlugin.BodyTrackingFidelity2 bodyTrackingFidelity;

	[SerializeField]
	private OVRPlugin.BodyJointSet bodyTrackingJointSet;

	public static OVRRuntimeSettings Instance => null;

	public bool RequestsVisualFaceTracking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool RequestsAudioFaceTracking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasSetTelemetryEnabled => false;

	internal bool TelemetryEnabled => false;

	internal string TelemetryProjectGuid => null;

	public OVRPlugin.BodyTrackingFidelity2 BodyTrackingFidelity
	{
		get
		{
			return default(OVRPlugin.BodyTrackingFidelity2);
		}
		set
		{
		}
	}

	public OVRPlugin.BodyJointSet BodyTrackingJointSet
	{
		get
		{
			return default(OVRPlugin.BodyJointSet);
		}
		set
		{
		}
	}

	public static OVRRuntimeSettings GetRuntimeSettings()
	{
		return null;
	}
}
