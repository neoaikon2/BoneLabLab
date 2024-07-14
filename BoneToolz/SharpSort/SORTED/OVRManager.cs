using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_manager")]
public class OVRManager : MonoBehaviour, OVRMixedRealityCaptureConfiguration
{
	public enum XrApi
	{
		Unknown = 0,
		CAPI = 1,
		VRAPI = 2,
		OpenXR = 3
	}

	public enum TrackingOrigin
	{
		EyeLevel = 0,
		FloorLevel = 1,
		Stage = 2
	}

	public enum EyeTextureFormat
	{
		Default = 0,
		R16G16B16A16_FP = 2,
		R11G11B10_FP = 3
	}

	public enum FoveatedRenderingLevel
	{
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4
	}

	[Obsolete("Please use FoveatedRenderingLevel instead")]
	public enum FixedFoveatedRenderingLevel
	{
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4
	}

	[Obsolete("Please use FoveatedRenderingLevel instead")]
	public enum TiledMultiResLevel
	{
		Off = 0,
		LMSLow = 1,
		LMSMedium = 2,
		LMSHigh = 3,
		LMSHighTop = 4
	}

	public enum SystemHeadsetType
	{
		None = 0,
		Oculus_Quest = 8,
		Oculus_Quest_2 = 9,
		Meta_Quest_Pro = 10,
		Meta_Quest_3 = 11,
		Placeholder_12 = 12,
		Placeholder_13 = 13,
		Placeholder_14 = 14,
		Rift_DK1 = 4096,
		Rift_DK2 = 4097,
		Rift_CV1 = 4098,
		Rift_CB = 4099,
		Rift_S = 4100,
		Oculus_Link_Quest = 4101,
		Oculus_Link_Quest_2 = 4102,
		Meta_Link_Quest_Pro = 4103,
		Meta_Link_Quest_3 = 4104,
		PC_Placeholder_4105 = 4105,
		PC_Placeholder_4106 = 4106,
		PC_Placeholder_4107 = 4107
	}

	public enum XRDevice
	{
		Unknown = 0,
		Oculus = 1,
		OpenVR = 2
	}

	public enum ColorSpace
	{
		Unknown = 0,
		Unmanaged = 1,
		Rec_2020 = 2,
		Rec_709 = 3,
		Rift_CV1 = 4,
		Rift_S = 5,
		[InspectorName("Quest 1")]
		Quest = 6,
		[InspectorName("DCI-P3 (Recommended)")]
		P3 = 7,
		Adobe_RGB = 8
	}

	public enum ProcessorPerformanceLevel
	{
		PowerSavings = 0,
		SustainedLow = 1,
		SustainedHigh = 2,
		Boost = 3
	}

	public enum ControllerDrivenHandPosesType
	{
		None = 0,
		ConformingToController = 1,
		Natural = 2
	}

	public interface EventListener
	{
		void OnEvent(OVRPlugin.EventDataBuffer eventData);
	}

	public enum CompositionMethod
	{
		External = 0,
		[Obsolete("Deprecated. Direct composition is no longer supported", false)]
		Direct = 1
	}

	[Obsolete("Deprecated", false)]
	public enum CameraDevice
	{
		WebCamera0 = 0,
		WebCamera1 = 1,
		ZEDCamera = 2
	}

	[Obsolete("Deprecated", false)]
	public enum DepthQuality
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	[Obsolete("Deprecated", false)]
	public enum VirtualGreenScreenType
	{
		Off = 0,
		[Obsolete("Deprecated. This enum value will not be supported in OpenXR", false)]
		OuterBoundary = 1,
		PlayArea = 2
	}

	public enum MrcActivationMode
	{
		Automatic = 0,
		Disabled = 1
	}

	public enum MrcCameraType
	{
		Normal = 0,
		Foreground = 1,
		Background = 2
	}

	public delegate GameObject InstantiateMrcCameraDelegate(GameObject mainCameraGameObject, MrcCameraType cameraType);

	private enum PassthroughInitializationState
	{
		Unspecified = 0,
		Pending = 1,
		Initialized = 2,
		Failed = 3
	}

	public class PassthroughCapabilities
	{
		public bool SupportsPassthrough { get; }

		public bool SupportsColorPassthrough { get; }

		public uint MaxColorLutResolution { get; }

		public PassthroughCapabilities(bool supportsPassthrough, bool supportsColorPassthrough, uint maxColorLutResolution)
		{
		}
	}

	private class Observable<T>
	{
		private T _value;

		public Action<T> OnChanged;

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public Observable()
		{
		}

		public Observable(T defaultValue)
		{
		}

		public Observable(T defaultValue, Action<T> callback)
		{
		}
	}

	protected static OVRProfile _profile;

	protected IEnumerable<Camera> disabledCameras;

	private static bool _isHmdPresentCached;

	private static bool _isHmdPresent;

	private static bool _wasHmdPresent;

	private static bool _hasVrFocusCached;

	private static bool _hasVrFocus;

	private static bool _hadVrFocus;

	private static bool _hadInputFocus;

	[Tooltip("If true, Unity will use the optimal antialiasing level for quality/performance on the current hardware.")]
	[Header("Performance/Quality")]
	public bool useRecommendedMSAALevel;

	[Tooltip("If true, both eyes will see the same image, rendered from the center eye pose, saving performance.")]
	[SerializeField]
	private bool _monoscopic;

	[Tooltip("The sharpen filter of the eye buffer. This amplifies contrast and fine details.")]
	[SerializeField]
	private OVRPlugin.LayerSharpenType _sharpenType;

	[HideInInspector]
	private ColorSpace _colorGamut;

	[Tooltip("Enable Dynamic Resolution. This will allocate render buffers to maxDynamicResolutionScale size and will change the viewport to adapt performance.")]
	[SerializeField]
	public bool enableDynamicResolution;

	[Range(0.7f, 1.3f)]
	[Tooltip("Minimum scaling factor used when dynamic resolution is enabled.")]
	[SerializeField]
	public float minDynamicResolutionScale;

	[Tooltip("Maximum scaling factor used when dynamic resolution is enabled.")]
	[SerializeField]
	[Range(0.7f, 1.3f)]
	public float maxDynamicResolutionScale;

	private const int _pixelStepPerFrame = 32;

	[HideInInspector]
	[Range(0.5f, 2f)]
	[Tooltip("Min RenderScale the app can reach under adaptive resolution mode")]
	[Obsolete("Deprecated. Use minDynamicRenderScale instead.", false)]
	public float minRenderScale;

	[Obsolete("Deprecated. Use maxDynamicRenderScale instead.", false)]
	[Range(0.5f, 2f)]
	[HideInInspector]
	[Tooltip("Max RenderScale the app can reach under adaptive resolution mode")]
	public float maxRenderScale;

	[SerializeField]
	[Tooltip("Set the relative offset rotation of head poses")]
	private Vector3 _headPoseRelativeOffsetRotation;

	[SerializeField]
	[Tooltip("Set the relative offset translation of head poses")]
	private Vector3 _headPoseRelativeOffsetTranslation;

	public int profilerTcpPort;

	[HideInInspector]
	public bool expandMixedRealityCapturePropertySheet;

	[Tooltip("If true, Mixed Reality mode will be enabled. It would be always set to false when the game is launching without editor")]
	[HideInInspector]
	public bool enableMixedReality;

	[HideInInspector]
	public CompositionMethod compositionMethod;

	[Tooltip("Extra hidden layers")]
	[HideInInspector]
	public LayerMask extraHiddenLayers;

	[Tooltip("Extra visible layers")]
	[HideInInspector]
	public LayerMask extraVisibleLayers;

	[HideInInspector]
	[Tooltip("Dynamic Culling Mask")]
	public bool dynamicCullingMask;

	[Tooltip("Backdrop color for Rift (External Compositon)")]
	[HideInInspector]
	public Color externalCompositionBackdropColorRift;

	[HideInInspector]
	[Tooltip("Backdrop color for Quest (External Compositon)")]
	public Color externalCompositionBackdropColorQuest;

	[HideInInspector]
	[Tooltip("The camera device for direct composition")]
	[Obsolete("Deprecated", false)]
	public CameraDevice capturingCameraDevice;

	[Obsolete("Deprecated", false)]
	[HideInInspector]
	[Tooltip("Flip the camera frame horizontally")]
	public bool flipCameraFrameHorizontally;

	[HideInInspector]
	[Tooltip("Flip the camera frame vertically")]
	[Obsolete("Deprecated", false)]
	public bool flipCameraFrameVertically;

	[HideInInspector]
	[Tooltip("Delay the touch controller pose by a short duration (0 to 0.5 second) to match the physical camera latency")]
	[Obsolete("Deprecated", false)]
	public float handPoseStateLatency;

	[HideInInspector]
	[Tooltip("Delay the foreground / background image in the sandwich composition to match the physical camera latency. The maximum duration is sandwichCompositionBufferedFrames / {Game FPS}")]
	[Obsolete("Deprecated", false)]
	public float sandwichCompositionRenderLatency;

	[HideInInspector]
	[Tooltip("The number of frames are buffered in the SandWich composition. The more buffered frames, the more memory it would consume.")]
	[Obsolete("Deprecated", false)]
	public int sandwichCompositionBufferedFrames;

	[HideInInspector]
	[Obsolete("Deprecated", false)]
	[Tooltip("Chroma Key Color")]
	public Color chromaKeyColor;

	[HideInInspector]
	[Tooltip("Chroma Key Similarity")]
	[Obsolete("Deprecated", false)]
	public float chromaKeySimilarity;

	[Obsolete("Deprecated", false)]
	[HideInInspector]
	[Tooltip("Chroma Key Smooth Range")]
	public float chromaKeySmoothRange;

	[Obsolete("Deprecated", false)]
	[HideInInspector]
	[Tooltip("Chroma Key Spill Range")]
	public float chromaKeySpillRange;

	[Obsolete("Deprecated", false)]
	[Tooltip("Use dynamic lighting (Depth sensor required)")]
	[HideInInspector]
	public bool useDynamicLighting;

	[HideInInspector]
	[Tooltip("The quality level of depth image. The lighting could be more smooth and accurate with high quality depth, but it would also be more costly in performance.")]
	[Obsolete("Deprecated", false)]
	public DepthQuality depthQuality;

	[Obsolete("Deprecated", false)]
	[Tooltip("Smooth factor in dynamic lighting. Larger is smoother")]
	[HideInInspector]
	public float dynamicLightingSmoothFactor;

	[HideInInspector]
	[Tooltip("The maximum depth variation across the edges. Make it smaller to smooth the lighting on the edges.")]
	[Obsolete("Deprecated", false)]
	public float dynamicLightingDepthVariationClampingValue;

	[Obsolete("Deprecated", false)]
	[HideInInspector]
	[Tooltip("Type of virutal green screen ")]
	public VirtualGreenScreenType virtualGreenScreenType;

	[HideInInspector]
	[Tooltip("Top Y of virtual green screen")]
	[Obsolete("Deprecated", false)]
	public float virtualGreenScreenTopY;

	[Obsolete("Deprecated", false)]
	[HideInInspector]
	[Tooltip("Bottom Y of virtual green screen")]
	public float virtualGreenScreenBottomY;

	[Tooltip("When using a depth camera (e.g. ZED), whether to use the depth in virtual green screen culling.")]
	[HideInInspector]
	[Obsolete("Deprecated", false)]
	public bool virtualGreenScreenApplyDepthCulling;

	[HideInInspector]
	[Tooltip("The tolerance value (in meter) when using the virtual green screen with a depth camera. Make it bigger if the foreground objects got culled incorrectly.")]
	[Obsolete("Deprecated", false)]
	public float virtualGreenScreenDepthTolerance;

	[HideInInspector]
	[Tooltip("(Quest-only) control if the mixed reality capture mode can be activated automatically through remote network connection.")]
	public MrcActivationMode mrcActivationMode;

	public InstantiateMrcCameraDelegate instantiateMixedRealityCameraGameObject;

	[HideInInspector]
	[Tooltip("Specify if Concurrent Hands and Controllers should be enabled. ")]
	public bool launchMultimodalHandsControllersOnStartup;

	[HideInInspector]
	[Tooltip("Specify if Insight Passthrough should be enabled. Passthrough layers can only be used if passthrough is enabled.")]
	public bool isInsightPassthroughEnabled;

	[SerializeField]
	[HideInInspector]
	internal bool requestBodyTrackingPermissionOnStartup;

	[SerializeField]
	[HideInInspector]
	internal bool requestFaceTrackingPermissionOnStartup;

	[HideInInspector]
	[SerializeField]
	internal bool requestEyeTrackingPermissionOnStartup;

	[SerializeField]
	[HideInInspector]
	internal bool requestScenePermissionOnStartup;

	[SerializeField]
	[HideInInspector]
	internal bool requestRecordAudioPermissionOnStartup;

	public static string OCULUS_UNITY_NAME_STR;

	public static string OPENVR_UNITY_NAME_STR;

	public static XRDevice loadedXRDevice;

	protected static Vector3 OpenVRTouchRotationOffsetEulerLeft;

	protected static Vector3 OpenVRTouchRotationOffsetEulerRight;

	protected static Vector3 OpenVRTouchPositionOffsetLeft;

	protected static Vector3 OpenVRTouchPositionOffsetRight;

	protected static bool m_SpaceWarpEnabled;

	protected static Transform m_AppSpaceTransform;

	protected static DepthTextureMode m_CachedDepthTextureMode;

	[SerializeField]
	[Tooltip("Available only for devices that support local dimming. It improves visual quality with a better display contrast ratio, but at a minor GPU performance cost.")]
	private bool _localDimming;

	[Header("Tracking")]
	[SerializeField]
	[Tooltip("Defines the current tracking origin type.")]
	private TrackingOrigin _trackingOriginType;

	[Tooltip("If true, head tracking will affect the position of each OVRCameraRig's cameras.")]
	public bool usePositionTracking;

	[HideInInspector]
	public bool useRotationTracking;

	[Tooltip("If true, the distance between the user's eyes will affect the position of each OVRCameraRig's cameras.")]
	public bool useIPDInPositionTracking;

	[Tooltip("If true, each scene load will cause the head pose to reset. This function only works on Rift.")]
	public bool resetTrackerOnLoad;

	[Tooltip("If true, the Reset View in the universal menu will cause the pose to be reset in PC VR. This should generally be enabled for applications with a stationary position in the virtual world and will allow the View Reset command to place the person back to a predefined location (such as a cockpit seat). Set this to false if you have a locomotion system because resetting the view would effectively teleport the player to potentially invalid locations.")]
	public bool AllowRecenter;

	[Tooltip("If true, rendered controller latency is reduced by several ms, as the left/right controllers will have their positions updated right before rendering.")]
	public bool LateControllerUpdate;

	[Tooltip("Late latching is a feature that can reduce rendered head/controller latency by a substantial amount. Before enabling, be sure to go over the documentation to ensure that the feature is used correctly. This feature must also be enabled through the Oculus XR Plugin settings.")]
	public bool LateLatching;

	private static ControllerDrivenHandPosesType _readOnlyControllerDrivenHandPosesType;

	[Tooltip("Defines if hand poses can be populated by controller data.")]
	public ControllerDrivenHandPosesType controllerDrivenHandPosesType;

	private static bool _isUserPresentCached;

	private static bool _isUserPresent;

	private static bool _wasUserPresent;

	private static bool prevAudioOutIdIsCached;

	private static bool prevAudioInIdIsCached;

	private static string prevAudioOutId;

	private static string prevAudioInId;

	private static bool wasPositionTracked;

	private static OVRPlugin.EventDataBuffer eventDataBuffer;

	private HashSet<EventListener> eventListeners;

	public static string UnityAlphaOrBetaVersionWarningMessage;

	public static bool OVRManagerinitialized;

	private static List<XRDisplaySubsystem> s_displaySubsystems;

	private static List<XRDisplaySubsystemDescriptor> s_displaySubsystemDescriptors;

	private static List<XRInputSubsystem> s_inputSubsystems;

	private static bool multipleMainCameraWarningPresented;

	private static bool suppressUnableToFindMainCameraMessage;

	private static WeakReference<Camera> lastFoundMainCamera;

	public static bool staticMixedRealityCaptureInitialized;

	public static bool staticPrevEnableMixedRealityCapture;

	public static OVRMixedRealityCaptureSettings staticMrcSettings;

	private static bool suppressDisableMixedRealityBecauseOfNoMainCameraWarning;

	public static Action<bool> OnPassthroughInitializedStateChange;

	private static Observable<PassthroughInitializationState> _passthroughInitializationState;

	private static PassthroughCapabilities _passthroughCapabilities;

	public static OVRManager instance { get; private set; }

	public static OVRDisplay display { get; private set; }

	public static OVRTracker tracker { get; private set; }

	public static OVRBoundary boundary { get; private set; }

	public static OVRRuntimeSettings runtimeSettings { get; private set; }

	public static OVRProfile profile => null;

	public static bool isHmdPresent
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static string audioOutId => null;

	public static string audioInId => null;

	public static bool hasVrFocus
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static bool hasInputFocus => false;

	public bool chromatic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool monoscopic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public OVRPlugin.LayerSharpenType sharpenType
	{
		get
		{
			return default(OVRPlugin.LayerSharpenType);
		}
		set
		{
		}
	}

	public ColorSpace colorGamut
	{
		get
		{
			return default(ColorSpace);
		}
		set
		{
		}
	}

	public ColorSpace nativeColorGamut => default(ColorSpace);

	public Vector3 headPoseRelativeOffsetRotation
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 headPoseRelativeOffsetTranslation
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	[HideInInspector]
	public static bool eyeFovPremultipliedAlphaModeEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EenableMixedReality
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private LayerMask OVRMixedRealityCaptureConfiguration_002EextraHiddenLayers
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	private LayerMask OVRMixedRealityCaptureConfiguration_002EextraVisibleLayers
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EdynamicCullingMask
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private CompositionMethod OVRMixedRealityCaptureConfiguration_002EcompositionMethod
	{
		get
		{
			return default(CompositionMethod);
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EexternalCompositionBackdropColorRift
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EexternalCompositionBackdropColorQuest
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private CameraDevice OVRMixedRealityCaptureConfiguration_002EcapturingCameraDevice
	{
		get
		{
			return default(CameraDevice);
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EflipCameraFrameHorizontally
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EflipCameraFrameVertically
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EhandPoseStateLatency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EsandwichCompositionRenderLatency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private int OVRMixedRealityCaptureConfiguration_002EsandwichCompositionBufferedFrames
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EchromaKeyColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySimilarity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySmoothRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySpillRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EuseDynamicLighting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private DepthQuality OVRMixedRealityCaptureConfiguration_002EdepthQuality
	{
		get
		{
			return default(DepthQuality);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EdynamicLightingSmoothFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EdynamicLightingDepthVariationClampingValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private VirtualGreenScreenType OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenType
	{
		get
		{
			return default(VirtualGreenScreenType);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenTopY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenBottomY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenApplyDepthCulling
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenDepthTolerance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private MrcActivationMode OVRMixedRealityCaptureConfiguration_002EmrcActivationMode
	{
		get
		{
			return default(MrcActivationMode);
		}
		set
		{
		}
	}

	private InstantiateMrcCameraDelegate OVRMixedRealityCaptureConfiguration_002EinstantiateMixedRealityCameraGameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public XrApi xrApi => default(XrApi);

	public ulong xrInstance => 0uL;

	public ulong xrSession => 0uL;

	public int vsyncCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. Please use SystemInfo.batteryLevel", false)]
	public static float batteryLevel => 0f;

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static float batteryTemperature => 0f;

	[Obsolete("Deprecated. Please use SystemInfo.batteryStatus", false)]
	public static int batteryStatus => 0;

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static float volumeLevel => 0f;

	public static ProcessorPerformanceLevel suggestedCpuPerfLevel
	{
		get
		{
			return default(ProcessorPerformanceLevel);
		}
		set
		{
		}
	}

	public static ProcessorPerformanceLevel suggestedGpuPerfLevel
	{
		get
		{
			return default(ProcessorPerformanceLevel);
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. Please use suggestedCpuPerfLevel", false)]
	public static int cpuLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. Please use suggestedGpuPerfLevel", false)]
	public static int gpuLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool isPowerSavingActive => false;

	public static EyeTextureFormat eyeTextureFormat
	{
		get
		{
			return default(EyeTextureFormat);
		}
		set
		{
		}
	}

	public static bool eyeTrackedFoveatedRenderingSupported => false;

	public static bool eyeTrackedFoveatedRenderingEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static FoveatedRenderingLevel foveatedRenderingLevel
	{
		get
		{
			return default(FoveatedRenderingLevel);
		}
		set
		{
		}
	}

	public static bool fixedFoveatedRenderingSupported => false;

	[Obsolete("Please use foveatedRenderingLevel instead", false)]
	public static FixedFoveatedRenderingLevel fixedFoveatedRenderingLevel
	{
		get
		{
			return default(FixedFoveatedRenderingLevel);
		}
		set
		{
		}
	}

	public static bool useDynamicFoveatedRendering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Please use useDynamicFoveatedRendering instead", false)]
	public static bool useDynamicFixedFoveatedRendering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Please use fixedFoveatedRenderingSupported instead", false)]
	public static bool tiledMultiResSupported => false;

	[Obsolete("Please use foveatedRenderingLevel instead", false)]
	public static TiledMultiResLevel tiledMultiResLevel
	{
		get
		{
			return default(TiledMultiResLevel);
		}
		set
		{
		}
	}

	public static bool gpuUtilSupported => false;

	public static float gpuUtilLevel => 0f;

	public static SystemHeadsetType systemHeadsetType => default(SystemHeadsetType);

	public TrackingOrigin trackingOriginType
	{
		get
		{
			return default(TrackingOrigin);
		}
		set
		{
		}
	}

	public bool IsSimultaneousHandsAndControllersSupported => false;

	public bool isSupportedPlatform { get; private set; }

	public bool isUserPresent
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static Version utilitiesVersion => null;

	public static Version pluginVersion => null;

	public static Version sdkVersion => null;

	bool OVRMixedRealityCaptureConfiguration.enableMixedReality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	LayerMask OVRMixedRealityCaptureConfiguration.extraHiddenLayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	LayerMask OVRMixedRealityCaptureConfiguration.extraVisibleLayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.dynamicCullingMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	CompositionMethod OVRMixedRealityCaptureConfiguration.compositionMethod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.externalCompositionBackdropColorRift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.externalCompositionBackdropColorQuest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	CameraDevice OVRMixedRealityCaptureConfiguration.capturingCameraDevice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.flipCameraFrameHorizontally { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.flipCameraFrameVertically { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.handPoseStateLatency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.sandwichCompositionRenderLatency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	int OVRMixedRealityCaptureConfiguration.sandwichCompositionBufferedFrames { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.chromaKeyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySimilarity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySmoothRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySpillRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.useDynamicLighting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	DepthQuality OVRMixedRealityCaptureConfiguration.depthQuality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.dynamicLightingSmoothFactor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.dynamicLightingDepthVariationClampingValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	VirtualGreenScreenType OVRMixedRealityCaptureConfiguration.virtualGreenScreenType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenTopY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenBottomY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.virtualGreenScreenApplyDepthCulling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenDepthTolerance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	MrcActivationMode OVRMixedRealityCaptureConfiguration.mrcActivationMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	InstantiateMrcCameraDelegate OVRMixedRealityCaptureConfiguration.instantiateMixedRealityCameraGameObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public static event Action HMDAcquired
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

	public static event Action HMDLost
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

	public static event Action HMDMounted
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

	public static event Action HMDUnmounted
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

	public static event Action VrFocusAcquired
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

	public static event Action VrFocusLost
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

	public static event Action InputFocusAcquired
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

	public static event Action InputFocusLost
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

	public static event Action AudioOutChanged
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

	public static event Action AudioInChanged
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

	public static event Action TrackingAcquired
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

	public static event Action TrackingLost
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

	public static event Action<float, float> DisplayRefreshRateChanged
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

	public static event Action<ulong, bool, OVRSpace, Guid> SpatialAnchorCreateComplete
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

	public static event Action<ulong, bool, OVRSpace, Guid, OVRPlugin.SpaceComponentType, bool> SpaceSetComponentStatusComplete
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

	public static event Action<ulong> SpaceQueryResults
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

	public static event Action<ulong, bool> SpaceQueryComplete
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

	public static event Action<ulong, OVRSpace, bool, Guid> SpaceSaveComplete
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

	public static event Action<ulong, bool, Guid, OVRPlugin.SpaceStorageLocation> SpaceEraseComplete
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

	public static event Action<ulong, OVRSpatialAnchor.OperationResult> ShareSpacesComplete
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

	public static event Action<ulong, OVRSpatialAnchor.OperationResult> SpaceListSaveComplete
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

	public static event Action<ulong, bool> SceneCaptureComplete
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

	[Obsolete]
	public static event Action HSWDismissed
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

	[Obsolete("Deprecated. Use Dynamic Render Scaling instead.", false)]
	public static bool IsAdaptiveResSupportedByEngine()
	{
		return false;
	}

	protected static void OnPermissionGranted(string permissionId)
	{
	}

	public static void SetColorScaleAndOffset(Vector4 colorScale, Vector4 colorOffset, bool applyToAllLayers)
	{
	}

	public static void SetOpenVRLocalPose(Vector3 leftPos, Vector3 rightPos, Quaternion leftRot, Quaternion rightRot)
	{
	}

	public static OVRPose GetOpenVRControllerOffset(XRNode hand)
	{
		return default(OVRPose);
	}

	public static void SetSpaceWarp(bool enabled)
	{
	}

	public static bool GetSpaceWarp()
	{
		return false;
	}

	public static bool SetDepthSubmission(bool enable)
	{
		return false;
	}

	public void RegisterEventListener(EventListener listener)
	{
	}

	public void DeregisterEventListener(EventListener listener)
	{
	}

	private static bool MixedRealityEnabledFromCmd()
	{
		return false;
	}

	private static bool UseDirectCompositionFromCmd()
	{
		return false;
	}

	private static bool UseExternalCompositionFromCmd()
	{
		return false;
	}

	private static bool CreateMixedRealityCaptureConfigurationFileFromCmd()
	{
		return false;
	}

	private static bool LoadMixedRealityCaptureConfigurationFileFromCmd()
	{
		return false;
	}

	public static bool IsUnityAlphaOrBetaVersion()
	{
		return false;
	}

	private void InitOVRManager()
	{
	}

	private void InitPermissionRequest()
	{
	}

	private void Awake()
	{
	}

	private void SetCurrentXRDevice()
	{
	}

	public static XRDisplaySubsystem GetCurrentDisplaySubsystem()
	{
		return null;
	}

	public static XRDisplaySubsystemDescriptor GetCurrentDisplaySubsystemDescriptor()
	{
		return null;
	}

	public static XRInputSubsystem GetCurrentInputSubsystem()
	{
		return null;
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	private void UpdateHMDEvents()
	{
	}

	public static Camera FindMainCamera()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public void ReturnToLauncher()
	{
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static void PlatformUIConfirmQuit()
	{
	}

	public static void StaticInitializeMixedRealityCapture(OVRMixedRealityCaptureConfiguration configuration)
	{
	}

	public static void StaticUpdateMixedRealityCapture(OVRMixedRealityCaptureConfiguration configuration, GameObject gameObject, TrackingOrigin trackingOrigin)
	{
	}

	public static void StaticShutdownMixedRealityCapture(OVRMixedRealityCaptureConfiguration configuration)
	{
	}

	private static bool PassthroughInitializedOrPending(PassthroughInitializationState state)
	{
		return false;
	}

	private static bool InitializeInsightPassthrough()
	{
		return false;
	}

	private static void ShutdownInsightPassthrough()
	{
	}

	private static void UpdateInsightPassthrough(bool shouldBeEnabled)
	{
	}

	public static bool IsMultimodalHandsControllersSupported()
	{
		return false;
	}

	public static bool IsInsightPassthroughSupported()
	{
		return false;
	}

	public static PassthroughCapabilities GetPassthroughCapabilities()
	{
		return null;
	}

	public static bool IsInsightPassthroughInitialized()
	{
		return false;
	}

	public static bool HasInsightPassthroughInitFailed()
	{
		return false;
	}

	public static bool IsInsightPassthroughInitPending()
	{
		return false;
	}

	public static bool IsPassthroughRecommended()
	{
		return false;
	}

	public static FoveatedRenderingLevel GetFoveatedRenderingLevel()
	{
		return default(FoveatedRenderingLevel);
	}

	public static void SetFoveatedRenderingLevel(FoveatedRenderingLevel level)
	{
	}

	public static bool GetDynamicFoveatedRenderingEnabled()
	{
		return false;
	}

	public static void SetDynamicFoveatedRenderingEnabled(bool enabled)
	{
	}

	public static bool GetEyeTrackedFoveatedRenderingSupported()
	{
		return false;
	}

	public static bool GetEyeTrackedFoveatedRenderingEnabled()
	{
		return false;
	}

	public static void SetEyeTrackedFoveatedRenderingEnabled(bool enabled)
	{
	}

	private static bool IsOpenXRLoaderActive()
	{
		return false;
	}
}
