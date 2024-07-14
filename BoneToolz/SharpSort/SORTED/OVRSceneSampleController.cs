using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_sample_controller")]
public class OVRSceneSampleController : MonoBehaviour
{
	public KeyCode quitKey;

	public Texture fadeInTexture;

	public float speedRotationIncrement;

	private OVRPlayerController playerController;

	private OVRCameraRig cameraController;

	public string layerName;

	private bool visionMode;

	private OVRGridCube gridCube;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateVisionMode()
	{
	}

	private void UpdateSpeedAndRotationScaleMultiplier()
	{
	}

	private void UpdateRecenterPose()
	{
	}
}
