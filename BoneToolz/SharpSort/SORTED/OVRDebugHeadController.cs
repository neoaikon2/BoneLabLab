using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_debug_head_controller")]
public class OVRDebugHeadController : MonoBehaviour
{
	[SerializeField]
	public bool AllowPitchLook;

	[SerializeField]
	public bool AllowYawLook;

	[SerializeField]
	public bool InvertPitch;

	[SerializeField]
	public float GamePad_PitchDegreesPerSec;

	[SerializeField]
	public float GamePad_YawDegreesPerSec;

	[SerializeField]
	public bool AllowMovement;

	[SerializeField]
	public float ForwardSpeed;

	[SerializeField]
	public float StrafeSpeed;

	protected OVRCameraRig CameraRig;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
