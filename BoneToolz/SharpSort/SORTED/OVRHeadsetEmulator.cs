using UnityEngine;

public class OVRHeadsetEmulator : MonoBehaviour
{
	public enum OpMode
	{
		Off = 0,
		EditorOnly = 1,
		AlwaysOn = 2
	}

	public OpMode opMode;

	public bool resetHmdPoseOnRelease;

	public bool resetHmdPoseByMiddleMouseButton;

	public KeyCode[] activateKeys;

	public KeyCode[] pitchKeys;

	private OVRManager manager;

	private const float MOUSE_SCALE_X = -2f;

	private const float MOUSE_SCALE_X_PITCH = -2f;

	private const float MOUSE_SCALE_Y = 2f;

	private const float MOUSE_SCALE_HEIGHT = 1f;

	private const float MAX_ROLL = 85f;

	private bool lastFrameEmulationActivated;

	private Vector3 recordedHeadPoseRelativeOffsetTranslation;

	private Vector3 recordedHeadPoseRelativeOffsetRotation;

	private bool hasSentEvent;

	private bool emulatorHasInitialized;

	private CursorLockMode previousCursorLockMode;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool IsEmulationActivated()
	{
		return false;
	}

	private bool IsTweakingPitch()
	{
		return false;
	}
}
