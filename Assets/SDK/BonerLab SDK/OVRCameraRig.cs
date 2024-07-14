using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_camera_rig")]
public class OVRCameraRig : MonoBehaviour
{
	public bool usePerEyeCameras;

	public bool useFixedUpdateForTracking;

	public bool disableEyeAnchorCameras;

	protected bool _skipUpdate;

	protected readonly string trackingSpaceName;

	protected readonly string trackerAnchorName;

	protected readonly string leftEyeAnchorName;

	protected readonly string centerEyeAnchorName;

	protected readonly string rightEyeAnchorName;

	protected readonly string leftHandAnchorName;

	protected readonly string rightHandAnchorName;

	protected readonly string leftControllerAnchorName;

	protected readonly string rightControllerAnchorName;

	protected readonly string leftHandAnchorDetachedName;

	protected readonly string rightHandAnchorDetachedName;

	protected readonly string leftControllerInHandAnchorName;

	protected readonly string leftHandOnControllerAnchorName;

	protected readonly string rightControllerInHandAnchorName;

	protected readonly string rightHandOnControllerAnchorName;

	protected Camera _centerEyeCamera;

	protected Camera _leftEyeCamera;

	protected Camera _rightEyeCamera;

	protected Matrix4x4 _previousTrackingSpaceTransform;

	public Camera leftEyeCamera => null;

	public Camera rightEyeCamera => null;

	public Transform trackingSpace { get; private set; }

	public Transform leftEyeAnchor { get; private set; }

	public Transform centerEyeAnchor { get; private set; }

	public Transform rightEyeAnchor { get; private set; }

	public Transform leftHandAnchor { get; private set; }

	public Transform rightHandAnchor { get; private set; }

	public Transform leftHandAnchorDetached { get; private set; }

	public Transform rightHandAnchorDetached { get; private set; }

	public Transform leftControllerInHandAnchor { get; private set; }

	public Transform leftHandOnControllerAnchor { get; private set; }

	public Transform rightControllerInHandAnchor { get; private set; }

	public Transform rightHandOnControllerAnchor { get; private set; }

	public Transform leftControllerAnchor { get; private set; }

	public Transform rightControllerAnchor { get; private set; }

	public Transform trackerAnchor { get; private set; }

	public event Action<OVRCameraRig> UpdatedAnchors
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Transform> TrackingSpaceChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void UpdateAnchors(bool updateEyeAnchors, bool updateHandAnchors)
	{
	}

	protected virtual void OnBeforeRenderCallback()
	{
	}

	protected virtual void CheckForTrackingSpaceChangesAndRaiseEvent()
	{
	}

	protected virtual void RaiseUpdatedAnchorsEvent()
	{
	}

	public virtual void EnsureGameObjectIntegrity()
	{
	}

	protected virtual Transform ConfigureAnchor(Transform root, string name)
	{
		return null;
	}

	public virtual Matrix4x4 ComputeTrackReferenceMatrix()
	{
		return default(Matrix4x4);
	}

	protected void CheckForAnchorsInParent()
	{
	}
}
