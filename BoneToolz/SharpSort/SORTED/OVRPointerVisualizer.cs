using UnityEngine;

public class OVRPointerVisualizer : MonoBehaviour
{
	[Tooltip("Object which points with Z axis. E.g. CentreEyeAnchor from OVRCameraRig")]
	public Transform rayTransform;

	[Header("Visual Elements")]
	[Tooltip("Line Renderer used to draw selection ray.")]
	public LineRenderer linePointer;

	[Tooltip("Visually, how far out should the ray be drawn.")]
	public float rayDrawDistance;

	private void Update()
	{
	}
}
