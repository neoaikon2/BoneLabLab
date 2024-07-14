using UnityEngine;

public class OVRMixedRealityCaptureTest : MonoBehaviour
{
	private enum CameraMode
	{
		Normal = 0,
		OverrideFov = 1,
		ThirdPerson = 2
	}

	private bool inited;

	private CameraMode currentMode;

	public Camera defaultExternalCamera;

	private OVRPlugin.Fovf defaultFov;

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	private void UpdateDefaultExternalCamera()
	{
	}

	private void Update()
	{
	}
}
