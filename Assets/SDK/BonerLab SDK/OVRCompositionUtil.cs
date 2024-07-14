using System;
using UnityEngine;

internal class OVRCompositionUtil
{
	public static void SafeDestroy(GameObject obj)
	{
	}

	public static void SafeDestroy(ref GameObject obj)
	{
	}

	[Obsolete("GetWorldPosition should be invoked with an explicit camera parameter")]
	public static Vector3 GetWorldPosition(Vector3 trackingSpacePosition)
	{
		return default(Vector3);
	}

	public static Vector3 GetWorldPosition(Camera camera, Vector3 trackingSpacePosition)
	{
		return default(Vector3);
	}

	public static float GetMaximumBoundaryDistance(Camera camera, OVRBoundary.BoundaryType boundaryType)
	{
		return 0f;
	}

	public static Mesh BuildBoundaryMesh(OVRBoundary.BoundaryType boundaryType, float topY, float bottomY)
	{
		return null;
	}
}
