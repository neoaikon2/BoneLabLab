using UnityEngine;

internal static class OVRMixedReality
{
	public static bool useFakeExternalCamera;

	public static Vector3 fakeCameraFloorLevelPosition;

	public static Vector3 fakeCameraEyeLevelPosition;

	public static Quaternion fakeCameraRotation;

	public static float fakeCameraFov;

	public static float fakeCameraAspect;

	public static OVRComposition currentComposition;

	public static void Update(GameObject parentObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration, OVRManager.TrackingOrigin trackingOrigin)
	{
	}

	public static void Cleanup()
	{
	}

	public static void RecenterPose()
	{
	}
}
