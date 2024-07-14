using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public static class OVRNodeStateProperties
{
	private static List<XRNodeState> nodeStateList;

	public static bool IsHmdPresent()
	{
		return false;
	}

	public static bool GetNodeStatePropertyVector3(XRNode nodeType, NodeStatePropertyType propertyType, OVRPlugin.Node ovrpNodeType, OVRPlugin.Step stepType, out Vector3 retVec)
	{
		retVec = default(Vector3);
		return false;
	}

	public static bool GetNodeStatePropertyQuaternion(XRNode nodeType, NodeStatePropertyType propertyType, OVRPlugin.Node ovrpNodeType, OVRPlugin.Step stepType, out Quaternion retQuat)
	{
		retQuat = default(Quaternion);
		return false;
	}

	private static bool ValidateProperty(XRNode nodeType, ref XRNodeState requestedNodeState)
	{
		return false;
	}

	private static bool GetUnityXRNodeStateVector3(XRNode nodeType, NodeStatePropertyType propertyType, out Vector3 retVec)
	{
		retVec = default(Vector3);
		return false;
	}

	private static bool GetUnityXRNodeStateQuaternion(XRNode nodeType, NodeStatePropertyType propertyType, out Quaternion retQuat)
	{
		retQuat = default(Quaternion);
		return false;
	}
}
