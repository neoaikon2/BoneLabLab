using UnityEngine;
using UnityEngine.EventSystems;

public class OVRVirtualKeyboardSampleInputHandler : MonoBehaviour
{
	private const float RAY_MAX_DISTANCE = 100f;

	private const float THUMBSTICK_DEADZONE = 0.2f;

	private const float COLLISION_BOUNDS_ADDED_BLEED_PERCENT = 0.1f;

	private const float LINEPOINTER_THINNING_THRESHOLD = 0.015f;

	public OVRVirtualKeyboard OVRVirtualKeyboard;

	[SerializeField]
	private OVRRaycaster raycaster;

	[SerializeField]
	private OVRInputModule inputModule;

	[SerializeField]
	private LineRenderer leftLinePointer;

	[SerializeField]
	private LineRenderer rightLinePointer;

	private OVRInput.Controller? interactionDevice_;

	private float linePointerInitialWidth_;

	public float AnalogStickX => 0f;

	public float AnalogStickY => 0f;

	public Vector3 InputRayPosition => default(Vector3);

	public Quaternion InputRayRotation => default(Quaternion);

	private static float ApplyDeadzone(float value)
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateLineRenderer()
	{
	}

	private void UpdateLineRendererFromSource(OVRVirtualKeyboard.InputSource source)
	{
	}

	private void UpdateInteractionAnchor()
	{
	}
}
