using System;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_eye_gaze")]
public class OVREyeGaze : MonoBehaviour
{
	public enum EyeId
	{
		Left = 0,
		Right = 1
	}

	public enum EyeTrackingMode
	{
		HeadSpace = 0,
		WorldSpace = 1,
		TrackingSpace = 2
	}

	public EyeId Eye;

	[Range(0f, 1f)]
	public float ConfidenceThreshold;

	public bool ApplyPosition;

	public bool ApplyRotation;

	private OVRPlugin.EyeGazesState _currentEyeGazesState;

	[Tooltip("Reference frame for eye. Reference frame should be set in the forward direction of the eye. It is there to calculate the initial offset of the eye GameObject. If it's null, then world reference frame will be used.")]
	public Transform ReferenceFrame;

	[Tooltip("HeadSpace: Tracking mode will convert the eye pose from tracking space to local space which is relative to the VR camera rig. For example, we can use this setting to correctly show the eye movement of a character which is facing in another direction than the source.\nWorldSpace: Tracking mode will convert the eye pose from tracking space to world space.\nTrackingSpace: Track eye is relative to OVRCameraRig. This is raw pose information from VR tracking space.")]
	public EyeTrackingMode TrackingMode;

	private Quaternion _initialRotationOffset;

	private Transform _viewTransform;

	private const OVRPermissionsRequester.Permission EyeTrackingPermission = OVRPermissionsRequester.Permission.EyeTracking;

	private Action<string> _onPermissionGranted;

	private static int _trackingInstanceCount;

	public bool EyeTrackingEnabled => false;

	public float Confidence { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnPermissionGranted(string permissionId)
	{
	}

	private bool StartEyeTracking()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private Quaternion CalculateEyeRotation(Quaternion eyeRotation)
	{
		return default(Quaternion);
	}

	private void PrepareHeadDirection()
	{
	}
}
