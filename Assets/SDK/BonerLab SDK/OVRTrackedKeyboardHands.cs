using UnityEngine;

public class OVRTrackedKeyboardHands : MonoBehaviour
{
	private struct HandBoneMapping
	{
		public Transform LeftHandTransform;

		public Transform LeftPresenceTransform;

		public Transform RightHandTransform;

		public Transform RightPresenceTransform;

		public OVRSkeleton.BoneId BoneName;

		public string HandPresenceLeftBoneName;

		public string HandPresenceRightBoneName;
	}

	public struct TrackedKeyboardHandsVisibilityChangedEvent
	{
		public bool leftVisible;

		public bool rightVisible;
	}

	public GameObject LeftHandPresence;

	public GameObject RightHandPresence;

	private bool handPresenceInitialized_;

	private Transform leftHandRoot_;

	private Transform rightHandRoot_;

	public OVRTrackedKeyboard KeyboardTracker;

	private OVRCameraRig cameraRig_;

	private OVRHand leftHand_;

	private OVRSkeleton leftHandSkeleton_;

	private OVRSkeletonRenderer leftHandSkeletonRenderer_;

	private GameObject leftHandSkeletonRendererGO_;

	private SkinnedMeshRenderer leftHandSkinnedMeshRenderer_;

	private OVRMeshRenderer leftHandMeshRenderer_;

	private OVRHand rightHand_;

	private OVRSkeleton rightHandSkeleton_;

	private OVRSkeletonRenderer rightHandSkeletonRenderer_;

	private GameObject rightHandSkeletonRendererGO_;

	private OVRMeshRenderer rightHandMeshRenderer_;

	private SkinnedMeshRenderer rightHandSkinnedMeshRenderer_;

	private static readonly float handInnerAlphaThreshold_;

	private static readonly float handOuterAlphaThreshold_;

	private static readonly float maximumPassthroughHandsDistance_;

	private static readonly float minimumModelHandsDistance_;

	private TrackedKeyboardHandsVisibilityChangedEvent? lastVisibilityEvent_;

	private readonly HandBoneMapping[] boneMappings_;

	public Material HandsMaterial;

	private const float XSCALE = 0.73f;

	private const float YSCALE = 0.8f;

	private const float FORWARD_OFFSET = -0.02f;

	private int keyboardPositionID_;

	private int keyboardRotationID_;

	private int keyboardScaleID_;

	public bool RightHandOverKeyboard { get; private set; }

	public bool LeftHandOverKeyboard { get; private set; }

	private bool AreControllersActive => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private bool ShouldEnablePassthrough(float distance)
	{
		return false;
	}

	private bool ShouldEnableModel(float distance)
	{
		return false;
	}

	private float GetHandDistanceToKeyboard(OVRSkeleton handSkeleton)
	{
		return 0f;
	}

	private float ComputeOpacity(float distance, float innerThreshold, float outerThreshold)
	{
		return 0f;
	}

	private void SetHandModelsEnabled(bool enableLeftModel, bool enableRightModel)
	{
	}

	private void RetargetHandTrackingToHandPresence()
	{
	}

	private void StopHandPresence()
	{
	}

	private void DisableHandObjects()
	{
	}

	public void TrackedKeyboardActiveUpdated(OVRTrackedKeyboard.TrackedKeyboardSetActiveEvent e)
	{
	}

	public void TrackedKeyboardVisibilityChanged(OVRTrackedKeyboard.TrackedKeyboardVisibilityChangedEvent e)
	{
	}
}
