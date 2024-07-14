using System.Collections.Generic;
using UnityEngine;

public class OVRExternalComposition : OVRComposition
{
	private GameObject previousMainCameraObject;

	public GameObject foregroundCameraGameObject;

	public Camera foregroundCamera;

	public GameObject backgroundCameraGameObject;

	public Camera backgroundCamera;

	private readonly object audioDataLock;

	private List<float> cachedAudioData;

	private int cachedChannels;

	public override OVRManager.CompositionMethod CompositionMethod()
	{
		return default(OVRManager.CompositionMethod);
	}

	public OVRExternalComposition(GameObject parentObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration)
		: base(null, null, null)
	{
	}

	private void RefreshCameraObjects(GameObject parentObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration)
	{
	}

	public override void Update(GameObject gameObject, Camera mainCamera, OVRMixedRealityCaptureConfiguration configuration, OVRManager.TrackingOrigin trackingOrigin)
	{
	}

	public override void Cleanup()
	{
	}

	public void CacheAudioData(float[] data, int channels)
	{
	}

	public void GetAndResetAudioData(ref float[] audioData, out int audioFrames, out int channels)
	{
		audioFrames = default(int);
		channels = default(int);
	}
}
