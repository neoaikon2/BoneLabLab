using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_display")]
public class OVRDisplay
{
	public struct EyeFov
	{
		public float UpFov;

		public float DownFov;

		public float LeftFov;

		public float RightFov;
	}

	public struct EyeRenderDesc
	{
		public Vector2 resolution;

		public Vector2 fov;

		public EyeFov fullFov;
	}

	public struct LatencyData
	{
		public float render;

		public float timeWarp;

		public float postPresent;

		public float renderError;

		public float timeWarpError;
	}

	protected bool needsConfigureTexture;

	protected EyeRenderDesc[] eyeDescs;

	protected bool recenterRequested;

	protected int recenterRequestedFrameCount;

	protected int localTrackingSpaceRecenterCount;

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public Vector3 acceleration => default(Vector3);

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public Vector3 angularAcceleration => default(Vector3);

	public Vector3 velocity => default(Vector3);

	public Vector3 angularVelocity => default(Vector3);

	public LatencyData latency => default(LatencyData);

	public float appFramerate => 0f;

	public int recommendedMSAALevel => 0;

	public float[] displayFrequenciesAvailable => null;

	public float displayFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public event Action RecenteredPose
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

	public void Update()
	{
	}

	public void RecenterPose()
	{
	}

	public EyeRenderDesc GetEyeRenderDesc(XRNode eye)
	{
		return default(EyeRenderDesc);
	}

	protected void UpdateTextures()
	{
	}

	protected void ConfigureEyeDesc(XRNode eye)
	{
	}
}
