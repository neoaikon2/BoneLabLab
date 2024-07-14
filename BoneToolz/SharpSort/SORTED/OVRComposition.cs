using UnityEngine;

public abstract class OVRComposition
{
	public bool cameraInTrackingSpace;

	public OVRCameraRig cameraRig;

	protected bool usingLastAttachedNodePose;

	protected OVRPose lastAttachedNodePose;

	protected OVRComposition(GameObject parentObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration)
	{
	}

	public abstract OVRManager.CompositionMethod CompositionMethod();

	public abstract void Update(GameObject gameObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration, OVRManager.TrackingOrigin trackingOrigin);

	public abstract void Cleanup();

	public virtual void RecenterPose()
	{
	}

	public void RefreshCameraRig(GameObject parentObject, Camera mainCamera)
	{
	}

	public OVRPose ComputeCameraWorldSpacePose(OVRPlugin.CameraExtrinsics extrinsics, Camera mainCamera)
	{
		return default(OVRPose);
	}

	public OVRPose ComputeCameraTrackingSpacePose(OVRPlugin.CameraExtrinsics extrinsics)
	{
		return default(OVRPose);
	}
}
