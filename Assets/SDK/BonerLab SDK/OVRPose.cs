using System;
using UnityEngine;

[Serializable]
public struct OVRPose
{
	public Vector3 position;

	public Quaternion orientation;

	public static OVRPose identity => default(OVRPose);

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(OVRPose x, OVRPose y)
	{
		return false;
	}

	public static bool operator !=(OVRPose x, OVRPose y)
	{
		return false;
	}

	public static OVRPose operator *(OVRPose lhs, OVRPose rhs)
	{
		return default(OVRPose);
	}

	public OVRPose Inverse()
	{
		return default(OVRPose);
	}

	public OVRPose flipZ()
	{
		return default(OVRPose);
	}

	public OVRPlugin.Posef ToPosef_Legacy()
	{
		return default(OVRPlugin.Posef);
	}

	public OVRPlugin.Posef ToPosef()
	{
		return default(OVRPlugin.Posef);
	}

	public OVRPose Rotate180AlongX()
	{
		return default(OVRPose);
	}
}
