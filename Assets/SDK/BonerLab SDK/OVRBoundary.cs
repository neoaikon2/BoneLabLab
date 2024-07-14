using System;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_boundary")]
public class OVRBoundary
{
	public enum Node
	{
		HandLeft = 3,
		HandRight = 4,
		Head = 9
	}

	public enum BoundaryType
	{
		[Obsolete("Deprecated. This enum value will not be supported in OpenXR", false)]
		OuterBoundary = 1,
		PlayArea = 0x100
	}

	[Obsolete("Deprecated. This struct will not be supported in OpenXR", false)]
	public struct BoundaryTestResult
	{
		public bool IsTriggering;

		public float ClosestDistance;

		public Vector3 ClosestPoint;

		public Vector3 ClosestPointNormal;
	}

	private static int cachedVector3fSize;

	private static OVRNativeBuffer cachedGeometryNativeBuffer;

	private static float[] cachedGeometryManagedBuffer;

	private List<Vector3> cachedGeometryList;

	public bool GetConfigured()
	{
		return false;
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public BoundaryTestResult TestNode(Node node, BoundaryType boundaryType)
	{
		return default(BoundaryTestResult);
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public BoundaryTestResult TestPoint(Vector3 point, BoundaryType boundaryType)
	{
		return default(BoundaryTestResult);
	}

	public Vector3[] GetGeometry(BoundaryType boundaryType)
	{
		return null;
	}

	public Vector3 GetDimensions(BoundaryType boundaryType)
	{
		return default(Vector3);
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public bool GetVisible()
	{
		return false;
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public void SetVisible(bool value)
	{
	}
}
