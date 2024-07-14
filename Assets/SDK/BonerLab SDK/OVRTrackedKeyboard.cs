using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class OVRTrackedKeyboard : MonoBehaviour
{
	public enum TrackedKeyboardState
	{
		Uninitialized = 0,
		NoTrackableKeyboard = 1,
		Offline = 2,
		StartedNotTracked = 3,
		Stale = 4,
		Valid = 5,
		Error = 6,
		ErrorExtensionFailed = 7
	}

	public enum KeyboardPresentation
	{
		PreferOpaque = 0,
		PreferMR = 1
	}

	public struct TrackedKeyboardVisibilityChangedEvent
	{
		public readonly string ActiveKeyboardName;

		public readonly TrackedKeyboardState State;

		public readonly bool TrackingTimeout;

		public TrackedKeyboardVisibilityChangedEvent(string keyboardModel, TrackedKeyboardState state, bool timeout)
		{
			ActiveKeyboardName = null;
			State = default(TrackedKeyboardState);
			TrackingTimeout = false;
		}
	}

	public struct TrackedKeyboardSetActiveEvent
	{
		public readonly bool IsEnabled;

		public TrackedKeyboardSetActiveEvent(bool isEnabled)
		{
			IsEnabled = false;
		}
	}
	private static readonly float underlayScaleMultX_;

	private static readonly float underlayScaleConstY_;

	private static readonly float underlayScaleMultZ_;

	private static readonly Vector3 underlayOffset_;

	private static readonly float boundingBoxAboveKeyboardY_;

	private static readonly float initialHorizontalDistanceKeyboard_;

	private static readonly float initialVerticalDistanceKeyboard_;

	[Tooltip("If true, will continually try to track and show keyboard. If false, no keyboard will be shown.")]
	[SerializeField]
	[Header("Settings")]
	private bool trackingEnabled;

	[Tooltip("If true, system keyboard must be paired and connected to track.")]
	[SerializeField]
	private bool connectionRequired;

	[SerializeField]
	[Tooltip("If true, keyboard will be displayed even if it is not currently connected or visible.")]
	private bool showUntracked;

	[SerializeField]
	[Tooltip("Which type of keyboard you wish to use.")]
	private OVRPlugin.TrackedKeyboardQueryFlags keyboardQueryFlags;

	[SerializeField]
	[Tooltip("Opaque will render a solid model of the keyboard with passthrough hands. MR will render the entire keyboard and hands in a passthrough window cutout. These are both suggestions and may not always be available.")]
	private KeyboardPresentation presentation;

	[Tooltip("Changes the Texture Quality setting of the currently used texture. Affects visualization quality only A value of -1 means no filtering. Bilinear is 0 (Unity Default) up to Aniso 16x which is 9.")]
	[SerializeField]
	public OVRTextureQualityFiltering textureFiltering;

	[SerializeField]
	[Tooltip("Changes the MipMap Bias of the currently used texture. Affects visualization quality only.")]
	[Range(-1f, 1f)]
	public float mipmapBias;

	[Tooltip("How large of a passthrough area to show surrounding the keyboard when using MR presentation")]
	public float PassthroughBorderMultiplier;

	[Tooltip("The shader used for rendering the keyboard model")]
	public Shader keyboardModelShader;

	[Tooltip("The shader used for rendering transparent parts of the keyboard model")]
	public Shader keyboardModelAlphaBlendShader;

	private OVRPlugin.TrackedKeyboardPresentationStyles currentKeyboardPresentationStyles;

	private OVROverlay projectedPassthroughOpaque_;

	private MeshRenderer[] activeKeyboardRenderers_;

	private GameObject activeKeyboardMesh_;

	private MeshRenderer activeKeyboardMeshRenderer_;

	private GameObject passthroughQuad_;

	private Texture2D dynamicQualityTexture_;

	private Vector3 untrackedPosition_;

	[Header("Internal")]
	public Shader PassthroughShader;

	[SerializeField]
	private Transform projectedPassthroughRoot;

	[SerializeField]
	private MeshFilter projectedPassthroughMesh;

	[FormerlySerializedAs("ProjectedPassthroughKeyLabel")]
	public OVRPassthroughLayer ProjectedPassthroughMR;

	public Action<TrackedKeyboardSetActiveEvent> TrackedKeyboardActiveChanged;

	public Action<TrackedKeyboardVisibilityChangedEvent> TrackedKeyboardVisibilityChanged;

	public Transform ActiveKeyboardTransform;

	[HideInInspector]
	public bool HandsOverKeyboard;

	private OVRCameraRig cameraRig_;

	private Coroutine updateKeyboardRoutine_;

	private BoxCollider keyboardBoundingBox_;

	private float staleTimeoutCounter_;

	private const float STALE_TIMEOUT = 10f;

	private float reacquisitionTimer_;

	private float sendFilteredPoseEventTimer_;

	private int skippedPoseCount_;

	private const float FILTERED_POSE_TIMEOUT = 15f;

	private Vector3? EWAPosition;

	private Quaternion? EWARotation;

	private float HAND_HEIGHT_TUNING;

	[HideInInspector]
	public bool UseHeuristicRollback;

	public float CurrentKeyboardAngleFromUp { get; private set; }

	public TrackedKeyboardState TrackingState { get; private set; }

	public OVRKeyboard.TrackedKeyboardInfo ActiveKeyboardInfo { get; private set; }

	public OVRKeyboard.TrackedKeyboardInfo SystemKeyboardInfo { get; private set; }

	public KeyboardPresentation Presentation
	{
		get
		{
			return default(KeyboardPresentation);
		}
		set
		{
		}
	}

	public bool TrackingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ConnectionRequired
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowUntracked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool RemoteKeyboard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public OVRPlugin.TrackedKeyboardQueryFlags KeyboardQueryFlags
	{
		get
		{
			return default(OVRPlugin.TrackedKeyboardQueryFlags);
		}
		set
		{
		}
	}

	public OVROverlay PassthroughOverlay
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}
	private IEnumerator Start()
	{
		return null;
	}
	private IEnumerator InitializeHandPresenceData()
	{
		return null;
	}

	private void RegisterPassthroughMeshToSDK()
	{
	}

	public float GetDistanceToKeyboard(Vector3 point)
	{
		return 0f;
	}

	public void LaunchLocalKeyboardSelectionDialog()
	{
	}

	public void LaunchRemoteKeyboardSelectionDialog()
	{
	}

	private bool KeyboardTrackerIsRunning()
	{
		return false;
	}
	private IEnumerator UpdateTrackingStateCoroutine()
	{
		return null;
	}
	private IEnumerator StartKeyboardTrackingCoroutine()
	{
		return null;
	}

	private void StopKeyboardTrackingInternal()
	{
	}
	private IEnumerator UpdateKeyboardPose()
	{
		return null;
	}

	private void UpdateSkippedPoseTimer()
	{
	}

	private void LoadKeyboardMesh()
	{
	}

	private void UpdateTextureQuality()
	{
	}

	private void UpdatePresentation(bool isVisible)
	{
	}

	private GameObject LoadRuntimeKeyboardMesh()
	{
		return null;
	}

	public void UpdateKeyboardVisibility()
	{
	}

	private void SetKeyboardState(TrackedKeyboardState state)
	{
	}

	private bool GetKeyboardVisibility()
	{
		return false;
	}

	private void InitializeKeyboardInfo()
	{
	}

	private void LaunchOverlayIntent(string dataUri)
	{
	}

	public void Dispose()
	{
	}

	private void DispatchVisibilityEvent(bool timeOut)
	{
	}
}
