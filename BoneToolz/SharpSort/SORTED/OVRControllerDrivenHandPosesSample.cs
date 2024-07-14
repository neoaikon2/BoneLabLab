using UnityEngine;
using UnityEngine.UI;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_controller_driven_hand_poses_sample")]
[DisallowMultipleComponent]
public class OVRControllerDrivenHandPosesSample : MonoBehaviour
{
	[SerializeField]
	private Button buttonOff;

	[SerializeField]
	private Button buttonConforming;

	[SerializeField]
	private Button buttonNatural;

	[SerializeField]
	private LineRenderer leftLinePointer;

	[SerializeField]
	private LineRenderer rightLinePointer;

	public OVRCameraRig cameraRig;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateLineRenderer()
	{
	}

	private void UpdateLineRendererForHand(bool isLeft)
	{
	}

	public void SetControllerDrivenHandPosesTypeToNone()
	{
	}

	public void SetControllerDrivenHandPosesTypeToControllerConforming()
	{
	}

	public void SetControllerDrivenHandPosesTypeToNatural()
	{
	}
}
