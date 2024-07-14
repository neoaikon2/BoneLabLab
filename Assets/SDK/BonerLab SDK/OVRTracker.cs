using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_tracker")]
public class OVRTracker
{
	public struct Frustum
	{
		public float nearZ;

		public float farZ;

		public Vector2 fov;
	}

	public bool isPresent => false;

	public bool isPositionTracked => false;

	public bool isEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int count => 0;

	public Frustum GetFrustum(int tracker = 0)
	{
		return default(Frustum);
	}

	public OVRPose GetPose(int tracker = 0)
	{
		return default(OVRPose);
	}

	public bool GetPoseValid(int tracker = 0)
	{
		return false;
	}

	public bool GetPresent(int tracker = 0)
	{
		return false;
	}
}
