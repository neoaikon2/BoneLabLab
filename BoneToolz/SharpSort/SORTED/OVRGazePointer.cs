using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_gaze_pointer")]
public class OVRGazePointer : OVRCursor
{
	private Transform gazeIcon;

	[Tooltip("Should the pointer be hidden when not over interactive objects.")]
	public bool hideByDefault;

	[Tooltip("Time after leaving interactive object before pointer fades.")]
	public float showTimeoutPeriod;

	[Tooltip("Time after mouse pointer becoming inactive before pointer unfades.")]
	public float hideTimeoutPeriod;

	[Tooltip("Keep a faint version of the pointer visible while using a mouse")]
	public bool dimOnHideRequest;

	[Tooltip("Angular scale of pointer")]
	public float depthScaleMultiplier;

	public bool matchNormalOnPhysicsColliders;

	public Transform rayTransform;

	private float depth;

	private float hideUntilTime;

	private int positionSetsThisFrame;

	private float lastShowRequestTime;

	private float lastHideRequestTime;

	private OVRProgressIndicator progressIndicator;

	private static OVRGazePointer _instance;

	public bool hidden { get; private set; }

	public float currentScale { get; private set; }

	public static OVRGazePointer instance => null;

	public float visibilityStrength => 0f;

	public float SelectionProgress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void Awake()
	{
	}

	private void Update()
	{
	}

	public override void SetCursorStartDest(Vector3 _, Vector3 pos, Vector3 normal)
	{
	}

	public override void SetCursorRay(Transform ray)
	{
	}

	private void LateUpdate()
	{
	}

	public void RequestHide()
	{
	}

	public void RequestShow()
	{
	}

	private void Hide()
	{
	}

	private void Show()
	{
	}
}
