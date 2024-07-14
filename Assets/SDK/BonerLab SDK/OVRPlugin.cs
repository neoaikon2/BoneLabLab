using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

public static class OVRPlugin
{
	private class GUID
	{
		public int a;

		public short b;

		public short c;

		public byte d0;

		public byte d1;

		public byte d2;

		public byte d3;

		public byte d4;

		public byte d5;

		public byte d6;

		public byte d7;
	}

	public enum Bool
	{
		False = 0,
		True = 1
	}

	public enum Result
	{
		Success = 0,
		Success_EventUnavailable = 1,
		Success_Pending = 2,
		Failure = -1000,
		Failure_InvalidParameter = -1001,
		Failure_NotInitialized = -1002,
		Failure_InvalidOperation = -1003,
		Failure_Unsupported = -1004,
		Failure_NotYetImplemented = -1005,
		Failure_OperationFailed = -1006,
		Failure_InsufficientSize = -1007,
		Failure_DataIsInvalid = -1008,
		Failure_DeprecatedOperation = -1009,
		Failure_ErrorLimitReached = -1010,
		Failure_ErrorInitializationFailed = -1011,
		Failure_RuntimeUnavailable = -1012,
		Failure_HandleInvalid = -1013,
		Failure_SpaceCloudStorageDisabled = -2000,
		Failure_SpaceMappingInsufficient = -2001,
		Failure_SpaceLocalizationFailed = -2002,
		Failure_SpaceNetworkTimeout = -2003,
		Failure_SpaceNetworkRequestFailed = -2004
	}

	public enum LogLevel
	{
		Debug = 0,
		Info = 1,
		Error = 2
	}

	public delegate void LogCallback2DelegateType(LogLevel logLevel, IntPtr message, int size);

	public enum CameraStatus
	{
		CameraStatus_None = 0,
		CameraStatus_Connected = 1,
		CameraStatus_Calibrating = 2,
		CameraStatus_CalibrationFailed = 3,
		CameraStatus_Calibrated = 4,
		CameraStatus_ThirdPerson = 5,
		CameraStatus_EnumSize = int.MaxValue
	}

	public enum CameraAnchorType
	{
		CameraAnchorType_PreDefined = 0,
		CameraAnchorType_Custom = 1,
		CameraAnchorType_Count = 2,
		CameraAnchorType_EnumSize = int.MaxValue
	}

	public enum XrApi
	{
		Unknown = 0,
		CAPI = 1,
		VRAPI = 2,
		OpenXR = 3,
		EnumSize = int.MaxValue
	}

	public enum Eye
	{
		None = -1,
		Left = 0,
		Right = 1,
		Count = 2
	}

	public enum Tracker
	{
		None = -1,
		Zero = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Count = 4
	}

	public enum Node
	{
		None = -1,
		EyeLeft = 0,
		EyeRight = 1,
		EyeCenter = 2,
		HandLeft = 3,
		HandRight = 4,
		TrackerZero = 5,
		TrackerOne = 6,
		TrackerTwo = 7,
		TrackerThree = 8,
		Head = 9,
		DeviceObjectZero = 10,
		TrackedKeyboard = 11,
		ControllerLeft = 12,
		ControllerRight = 13,
		Count = 14
	}

	public enum Controller
	{
		None = 0,
		LTouch = 1,
		RTouch = 2,
		Touch = 3,
		Remote = 4,
		Gamepad = 16,
		LHand = 32,
		RHand = 64,
		Hands = 96,
		Active = int.MinValue,
		All = -1
	}

	public enum InteractionProfile
	{
		None = 0,
		Touch = 1,
		TouchPro = 2,
		TouchPlus = 4
	}

	public enum Handedness
	{
		Unsupported = 0,
		LeftHanded = 1,
		RightHanded = 2
	}

	public enum TrackingOrigin
	{
		EyeLevel = 0,
		FloorLevel = 1,
		Stage = 2,
		View = 4,
		Count = 5
	}

	public enum RecenterFlags
	{
		Default = 0,
		IgnoreAll = int.MinValue,
		Count = -2147483647
	}

	public enum BatteryStatus
	{
		Charging = 0,
		Discharging = 1,
		Full = 2,
		NotCharging = 3,
		Unknown = 4
	}

	public enum EyeTextureFormat
	{
		Default = 0,
		R8G8B8A8_sRGB = 0,
		R8G8B8A8 = 1,
		R16G16B16A16_FP = 2,
		R11G11B10_FP = 3,
		B8G8R8A8_sRGB = 4,
		B8G8R8A8 = 5,
		R5G6B5 = 11,
		EnumSize = int.MaxValue
	}

	public enum PlatformUI
	{
		None = -1,
		ConfirmQuit = 1,
		GlobalMenuTutorial = 2
	}

	public enum SystemRegion
	{
		Unspecified = 0,
		Japan = 1,
		China = 2
	}

	public enum SystemHeadset
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

	public enum OverlayShape
	{
		Quad = 0,
		Cylinder = 1,
		Cubemap = 2,
		OffcenterCubemap = 4,
		Equirect = 5,
		ReconstructionPassthrough = 7,
		SurfaceProjectedPassthrough = 8,
		Fisheye = 9,
		KeyboardHandsPassthrough = 10,
		KeyboardMaskedHandsPassthrough = 11
	}

	public enum LayerSuperSamplingType
	{
		None = 0,
		Normal = 4096,
		Quality = 256
	}

	public enum LayerSharpenType
	{
		None = 0,
		Normal = 0x2000,
		Quality = 0x10000
	}

	public enum Step
	{
		Render = -1,
		Physics = 0
	}

	public enum CameraDevice
	{
		None = 0,
		WebCamera0 = 100,
		WebCamera1 = 101,
		ZEDCamera = 300
	}

	public enum CameraDeviceDepthSensingMode
	{
		Standard = 0,
		Fill = 1
	}

	public enum CameraDeviceDepthQuality
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	public enum FoveatedRenderingLevel
	{
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4,
		EnumSize = int.MaxValue
	}

	[Obsolete("Please use FoveatedRenderingLevel instead", false)]
	public enum FixedFoveatedRenderingLevel
	{
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		HighTop = 4,
		EnumSize = int.MaxValue
	}

	[Obsolete("Please use FixedFoveatedRenderingLevel instead", false)]
	public enum TiledMultiResLevel
	{
		Off = 0,
		LMSLow = 1,
		LMSMedium = 2,
		LMSHigh = 3,
		LMSHighTop = 4,
		EnumSize = int.MaxValue
	}

	public enum PerfMetrics
	{
		App_CpuTime_Float = 0,
		App_GpuTime_Float = 1,
		Compositor_CpuTime_Float = 3,
		Compositor_GpuTime_Float = 4,
		Compositor_DroppedFrameCount_Int = 5,
		System_GpuUtilPercentage_Float = 7,
		System_CpuUtilAveragePercentage_Float = 8,
		System_CpuUtilWorstPercentage_Float = 9,
		Device_CpuClockFrequencyInMHz_Float = 10,
		Device_GpuClockFrequencyInMHz_Float = 11,
		Device_CpuClockLevel_Int = 12,
		Device_GpuClockLevel_Int = 13,
		Compositor_SpaceWarp_Mode_Int = 14,
		Device_CpuCore0UtilPercentage_Float = 32,
		Device_CpuCore1UtilPercentage_Float = 33,
		Device_CpuCore2UtilPercentage_Float = 34,
		Device_CpuCore3UtilPercentage_Float = 35,
		Device_CpuCore4UtilPercentage_Float = 36,
		Device_CpuCore5UtilPercentage_Float = 37,
		Device_CpuCore6UtilPercentage_Float = 38,
		Device_CpuCore7UtilPercentage_Float = 39,
		Count = 40,
		EnumSize = int.MaxValue
	}

	public enum ProcessorPerformanceLevel
	{
		PowerSavings = 0,
		SustainedLow = 1,
		SustainedHigh = 2,
		Boost = 3,
		EnumSize = int.MaxValue
	}

	public enum FeatureType
	{
		HandTracking = 0,
		KeyboardTracking = 1,
		EyeTracking = 2,
		FaceTracking = 3,
		BodyTracking = 4,
		Passthrough = 5,
		GazeBasedFoveatedRendering = 6,
		Count = 7,
		EnumSize = int.MaxValue
	}

	public struct CameraDeviceIntrinsicsParameters
	{
		private float fx;

		private float fy;

		private float cx;

		private float cy;

		private double disto0;

		private double disto1;

		private double disto2;

		private double disto3;

		private double disto4;

		private float v_fov;

		private float h_fov;

		private float d_fov;

		private int w;

		private int h;
	}

	private enum OverlayFlag
	{
		None = 0,
		OnTop = 1,
		HeadLocked = 2,
		NoDepth = 4,
		ExpensiveSuperSample = 8,
		EfficientSuperSample = 16,
		EfficientSharpen = 32,
		BicubicFiltering = 64,
		ExpensiveSharpen = 128,
		SecureContent = 256,
		ShapeFlag_Quad = 0,
		ShapeFlag_Cylinder = 16,
		ShapeFlag_Cubemap = 32,
		ShapeFlag_OffcenterCubemap = 64,
		ShapeFlagRangeMask = 240,
		Hidden = 512,
		AutoFiltering = 1024
	}

	public struct Vector2f
	{
		public float x;

		public float y;
	}

	public struct Vector3f
	{
		public float x;

		public float y;

		public float z;

		public static readonly Vector3f zero;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Vector4f
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public static readonly Vector4f zero;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Vector4s
	{
		public short x;

		public short y;

		public short z;

		public short w;

		public static readonly Vector4s zero;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Quatf
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public static readonly Quatf identity;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Posef
	{
		public Quatf Orientation;

		public Vector3f Position;

		public static readonly Posef identity;

		public override string ToString()
		{
			return null;
		}
	}

	public struct TextureRectMatrixf
	{
		public Rect leftRect;

		public Rect rightRect;

		public Vector4 leftScaleBias;

		public Vector4 rightScaleBias;

		public static readonly TextureRectMatrixf zero;

		public override string ToString()
		{
			return null;
		}
	}

	public struct PoseStatef
	{
		public Posef Pose;

		public Vector3f Velocity;

		[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
		public Vector3f Acceleration;

		public Vector3f AngularVelocity;

		[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
		public Vector3f AngularAcceleration;

		public double Time;

		public static readonly PoseStatef identity;
	}

	public enum HapticsLocation
	{
		None = 0,
		Hand = 1,
		Thumb = 2,
		Index = 4
	}

	public struct ControllerState6
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public byte LBatteryPercentRemaining;

		public byte RBatteryPercentRemaining;

		public byte LRecenterCount;

		public byte RRecenterCount;

		public float LThumbRestForce;

		public float RThumbRestForce;

		public float LStylusForce;

		public float RStylusForce;

		public float LIndexTriggerCurl;

		public float RIndexTriggerCurl;

		public float LIndexTriggerSlide;

		public float RIndexTriggerSlide;

		public float LIndexTriggerForce;

		public float RIndexTriggerForce;

		public ControllerState6(ControllerState5 cs)
		{
			ConnectedControllers = 0u;
			Buttons = 0u;
			Touches = 0u;
			NearTouches = 0u;
			LIndexTrigger = 0f;
			RIndexTrigger = 0f;
			LHandTrigger = 0f;
			RHandTrigger = 0f;
			LThumbstick = default(Vector2f);
			RThumbstick = default(Vector2f);
			LTouchpad = default(Vector2f);
			RTouchpad = default(Vector2f);
			LBatteryPercentRemaining = 0;
			RBatteryPercentRemaining = 0;
			LRecenterCount = 0;
			RRecenterCount = 0;
			LThumbRestForce = 0f;
			RThumbRestForce = 0f;
			LStylusForce = 0f;
			RStylusForce = 0f;
			LIndexTriggerCurl = 0f;
			RIndexTriggerCurl = 0f;
			LIndexTriggerSlide = 0f;
			RIndexTriggerSlide = 0f;
			LIndexTriggerForce = 0f;
			RIndexTriggerForce = 0f;
		}
	}

	public struct ControllerState5
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public byte LBatteryPercentRemaining;

		public byte RBatteryPercentRemaining;

		public byte LRecenterCount;

		public byte RRecenterCount;

		public float LThumbRestForce;

		public float RThumbRestForce;

		public float LStylusForce;

		public float RStylusForce;

		public float LIndexTriggerCurl;

		public float RIndexTriggerCurl;

		public float LIndexTriggerSlide;

		public float RIndexTriggerSlide;

		public ControllerState5(ControllerState4 cs)
		{
			ConnectedControllers = 0u;
			Buttons = 0u;
			Touches = 0u;
			NearTouches = 0u;
			LIndexTrigger = 0f;
			RIndexTrigger = 0f;
			LHandTrigger = 0f;
			RHandTrigger = 0f;
			LThumbstick = default(Vector2f);
			RThumbstick = default(Vector2f);
			LTouchpad = default(Vector2f);
			RTouchpad = default(Vector2f);
			LBatteryPercentRemaining = 0;
			RBatteryPercentRemaining = 0;
			LRecenterCount = 0;
			RRecenterCount = 0;
			LThumbRestForce = 0f;
			RThumbRestForce = 0f;
			LStylusForce = 0f;
			RStylusForce = 0f;
			LIndexTriggerCurl = 0f;
			RIndexTriggerCurl = 0f;
			LIndexTriggerSlide = 0f;
			RIndexTriggerSlide = 0f;
		}
	}

	public struct ControllerState4
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public byte LBatteryPercentRemaining;

		public byte RBatteryPercentRemaining;

		public byte LRecenterCount;

		public byte RRecenterCount;

		public byte Reserved_27;

		public byte Reserved_26;

		public byte Reserved_25;

		public byte Reserved_24;

		public byte Reserved_23;

		public byte Reserved_22;

		public byte Reserved_21;

		public byte Reserved_20;

		public byte Reserved_19;

		public byte Reserved_18;

		public byte Reserved_17;

		public byte Reserved_16;

		public byte Reserved_15;

		public byte Reserved_14;

		public byte Reserved_13;

		public byte Reserved_12;

		public byte Reserved_11;

		public byte Reserved_10;

		public byte Reserved_09;

		public byte Reserved_08;

		public byte Reserved_07;

		public byte Reserved_06;

		public byte Reserved_05;

		public byte Reserved_04;

		public byte Reserved_03;

		public byte Reserved_02;

		public byte Reserved_01;

		public byte Reserved_00;

		public ControllerState4(ControllerState2 cs)
		{
			ConnectedControllers = 0u;
			Buttons = 0u;
			Touches = 0u;
			NearTouches = 0u;
			LIndexTrigger = 0f;
			RIndexTrigger = 0f;
			LHandTrigger = 0f;
			RHandTrigger = 0f;
			LThumbstick = default(Vector2f);
			RThumbstick = default(Vector2f);
			LTouchpad = default(Vector2f);
			RTouchpad = default(Vector2f);
			LBatteryPercentRemaining = 0;
			RBatteryPercentRemaining = 0;
			LRecenterCount = 0;
			RRecenterCount = 0;
			Reserved_27 = 0;
			Reserved_26 = 0;
			Reserved_25 = 0;
			Reserved_24 = 0;
			Reserved_23 = 0;
			Reserved_22 = 0;
			Reserved_21 = 0;
			Reserved_20 = 0;
			Reserved_19 = 0;
			Reserved_18 = 0;
			Reserved_17 = 0;
			Reserved_16 = 0;
			Reserved_15 = 0;
			Reserved_14 = 0;
			Reserved_13 = 0;
			Reserved_12 = 0;
			Reserved_11 = 0;
			Reserved_10 = 0;
			Reserved_09 = 0;
			Reserved_08 = 0;
			Reserved_07 = 0;
			Reserved_06 = 0;
			Reserved_05 = 0;
			Reserved_04 = 0;
			Reserved_03 = 0;
			Reserved_02 = 0;
			Reserved_01 = 0;
			Reserved_00 = 0;
		}
	}

	public struct ControllerState2
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;

		public Vector2f LTouchpad;

		public Vector2f RTouchpad;

		public ControllerState2(ControllerState cs)
		{
			ConnectedControllers = 0u;
			Buttons = 0u;
			Touches = 0u;
			NearTouches = 0u;
			LIndexTrigger = 0f;
			RIndexTrigger = 0f;
			LHandTrigger = 0f;
			RHandTrigger = 0f;
			LThumbstick = default(Vector2f);
			RThumbstick = default(Vector2f);
			LTouchpad = default(Vector2f);
			RTouchpad = default(Vector2f);
		}
	}

	public struct ControllerState
	{
		public uint ConnectedControllers;

		public uint Buttons;

		public uint Touches;

		public uint NearTouches;

		public float LIndexTrigger;

		public float RIndexTrigger;

		public float LHandTrigger;

		public float RHandTrigger;

		public Vector2f LThumbstick;

		public Vector2f RThumbstick;
	}

	public struct HapticsBuffer
	{
		public IntPtr Samples;

		public int SamplesCount;
	}

	public struct HapticsState
	{
		public int SamplesAvailable;

		public int SamplesQueued;
	}

	public struct HapticsDesc
	{
		public int SampleRateHz;

		public int SampleSizeInBytes;

		public int MinimumSafeSamplesQueued;

		public int MinimumBufferSamplesCount;

		public int OptimalBufferSamplesCount;

		public int MaximumBufferSamplesCount;
	}

	public struct HapticsAmplitudeEnvelopeVibration
	{
		public float Duration;

		public uint AmplitudeCount;

		public IntPtr Amplitudes;
	}

	public struct HapticsPcmVibration
	{
		public uint BufferSize;

		public IntPtr Buffer;

		public float SampleRateHz;

		public Bool Append;

		public IntPtr SamplesConsumed;
	}

	public enum HapticsConstants
	{
		MaxSamples = 4000
	}

	public struct AppPerfFrameStats
	{
		public int HmdVsyncIndex;

		public int AppFrameIndex;

		public int AppDroppedFrameCount;

		public float AppMotionToPhotonLatency;

		public float AppQueueAheadTime;

		public float AppCpuElapsedTime;

		public float AppGpuElapsedTime;

		public int CompositorFrameIndex;

		public int CompositorDroppedFrameCount;

		public float CompositorLatency;

		public float CompositorCpuElapsedTime;

		public float CompositorGpuElapsedTime;

		public float CompositorCpuStartToGpuEndElapsedTime;

		public float CompositorGpuEndToVsyncElapsedTime;
	}

	public struct AppPerfStats
	{
		public AppPerfFrameStats[] FrameStats;

		public int FrameStatsCount;

		public Bool AnyFrameStatsDropped;

		public float AdaptiveGpuPerformanceScale;
	}

	public struct Sizei : IEquatable<Sizei>
	{
		public int w;

		public int h;

		public static readonly Sizei zero;

		public bool Equals(Sizei other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public struct Sizef
	{
		public float w;

		public float h;

		public static readonly Sizef zero;
	}

	public struct Size3f
	{
		public float w;

		public float h;

		public float d;

		public static readonly Size3f zero;
	}

	public struct Vector2i
	{
		public int x;

		public int y;
	}

	public struct Recti
	{
		public Vector2i Pos;

		public Sizei Size;
	}

	public struct RectiPair
	{
		public Recti Rect0;

		public Recti Rect1;

		public Recti this[int i]
		{
			get
			{
				return default(Recti);
			}
			set
			{
			}
		}
	}

	public struct Rectf
	{
		public Vector2f Pos;

		public Sizef Size;
	}

	public struct RectfPair
	{
		public Rectf Rect0;

		public Rectf Rect1;

		public Rectf this[int i]
		{
			get
			{
				return default(Rectf);
			}
			set
			{
			}
		}
	}

	public struct Boundsf
	{
		public Vector3f Pos;

		public Size3f Size;
	}

	public struct Frustumf
	{
		public float zNear;

		public float zFar;

		public float fovX;

		public float fovY;
	}

	public struct Frustumf2
	{
		public float zNear;

		public float zFar;

		public Fovf Fov;
	}

	public enum BoundaryType
	{
		[Obsolete("Deprecated. This enum value will not be supported in OpenXR", false)]
		OuterBoundary = 1,
		PlayArea = 0x100
	}

	[Obsolete("Deprecated. This struct will not be supported in OpenXR", false)]
	public struct BoundaryTestResult
	{
		public Bool IsTriggering;

		public float ClosestDistance;

		public Vector3f ClosestPoint;

		public Vector3f ClosestPointNormal;
	}

	public struct BoundaryGeometry
	{
		public BoundaryType BoundaryType;

		public Vector3f[] Points;

		public int PointsCount;
	}

	public struct Colorf
	{
		public float r;

		public float g;

		public float b;

		public float a;

		public override string ToString()
		{
			return null;
		}
	}

	public struct Fovf
	{
		public float UpTan;

		public float DownTan;

		public float LeftTan;

		public float RightTan;
	}

	public struct FovfPair
	{
		public Fovf Fov0;

		public Fovf Fov1;

		public Fovf this[int i]
		{
			get
			{
				return default(Fovf);
			}
			set
			{
			}
		}
	}

	public struct CameraIntrinsics
	{
		public Bool IsValid;

		public double LastChangedTimeSeconds;

		public Fovf FOVPort;

		public float VirtualNearPlaneDistanceMeters;

		public float VirtualFarPlaneDistanceMeters;

		public Sizei ImageSensorPixelResolution;
	}

	public struct CameraExtrinsics
	{
		public Bool IsValid;

		public double LastChangedTimeSeconds;

		public CameraStatus CameraStatusData;

		public Node AttachedToNode;

		public Posef RelativePose;
	}

	public enum LayerLayout
	{
		Stereo = 0,
		Mono = 1,
		DoubleWide = 2,
		Array = 3,
		EnumSize = 15
	}

	public enum LayerFlags
	{
		Static = 1,
		LoadingScreen = 2,
		SymmetricFov = 4,
		TextureOriginAtBottomLeft = 8,
		ChromaticAberrationCorrection = 0x10,
		NoAllocation = 0x20,
		ProtectedContent = 0x40,
		AndroidSurfaceSwapChain = 0x80,
		BicubicFiltering = 0x4000
	}

	public struct LayerDesc
	{
		public OverlayShape Shape;

		public LayerLayout Layout;

		public Sizei TextureSize;

		public int MipLevels;

		public int SampleCount;

		public EyeTextureFormat Format;

		public int LayerFlags;

		public FovfPair Fov;

		public RectfPair VisibleRect;

		public Sizei MaxViewportSize;

		public EyeTextureFormat DepthFormat;

		public EyeTextureFormat MotionVectorFormat;

		public EyeTextureFormat MotionVectorDepthFormat;

		public Sizei MotionVectorTextureSize;

		public override string ToString()
		{
			return null;
		}
	}

	public enum BlendFactor
	{
		Zero = 0,
		One = 1,
		SrcAlpha = 2,
		OneMinusSrcAlpha = 3,
		DstAlpha = 4,
		OneMinusDstAlpha = 5
	}

	public struct LayerSubmit
	{
		private int LayerId;

		private int TextureStage;

		private RectiPair ViewportRect;

		private Posef Pose;

		private int LayerSubmitFlags;
	}

	public enum TrackingConfidence
	{
		Low = 0,
		High = 1065353216
	}

	public enum Hand
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	[Flags]
	public enum HandStatus
	{
		HandTracked = 1,
		InputStateValid = 2,
		SystemGestureInProgress = 0x40,
		DominantHand = 0x80,
		MenuPressed = 0x100
	}

	public enum BoneId
	{
		Invalid = -1,
		Hand_Start = 0,
		Hand_WristRoot = 0,
		Hand_ForearmStub = 1,
		Hand_Thumb0 = 2,
		Hand_Thumb1 = 3,
		Hand_Thumb2 = 4,
		Hand_Thumb3 = 5,
		Hand_Index1 = 6,
		Hand_Index2 = 7,
		Hand_Index3 = 8,
		Hand_Middle1 = 9,
		Hand_Middle2 = 10,
		Hand_Middle3 = 11,
		Hand_Ring1 = 12,
		Hand_Ring2 = 13,
		Hand_Ring3 = 14,
		Hand_Pinky0 = 15,
		Hand_Pinky1 = 16,
		Hand_Pinky2 = 17,
		Hand_Pinky3 = 18,
		Hand_MaxSkinnable = 19,
		Hand_ThumbTip = 19,
		Hand_IndexTip = 20,
		Hand_MiddleTip = 21,
		Hand_RingTip = 22,
		Hand_PinkyTip = 23,
		Hand_End = 24,
		Body_Start = 0,
		Body_Root = 0,
		Body_Hips = 1,
		Body_SpineLower = 2,
		Body_SpineMiddle = 3,
		Body_SpineUpper = 4,
		Body_Chest = 5,
		Body_Neck = 6,
		Body_Head = 7,
		Body_LeftShoulder = 8,
		Body_LeftScapula = 9,
		Body_LeftArmUpper = 10,
		Body_LeftArmLower = 11,
		Body_LeftHandWristTwist = 12,
		Body_RightShoulder = 13,
		Body_RightScapula = 14,
		Body_RightArmUpper = 15,
		Body_RightArmLower = 16,
		Body_RightHandWristTwist = 17,
		Body_LeftHandPalm = 18,
		Body_LeftHandWrist = 19,
		Body_LeftHandThumbMetacarpal = 20,
		Body_LeftHandThumbProximal = 21,
		Body_LeftHandThumbDistal = 22,
		Body_LeftHandThumbTip = 23,
		Body_LeftHandIndexMetacarpal = 24,
		Body_LeftHandIndexProximal = 25,
		Body_LeftHandIndexIntermediate = 26,
		Body_LeftHandIndexDistal = 27,
		Body_LeftHandIndexTip = 28,
		Body_LeftHandMiddleMetacarpal = 29,
		Body_LeftHandMiddleProximal = 30,
		Body_LeftHandMiddleIntermediate = 31,
		Body_LeftHandMiddleDistal = 32,
		Body_LeftHandMiddleTip = 33,
		Body_LeftHandRingMetacarpal = 34,
		Body_LeftHandRingProximal = 35,
		Body_LeftHandRingIntermediate = 36,
		Body_LeftHandRingDistal = 37,
		Body_LeftHandRingTip = 38,
		Body_LeftHandLittleMetacarpal = 39,
		Body_LeftHandLittleProximal = 40,
		Body_LeftHandLittleIntermediate = 41,
		Body_LeftHandLittleDistal = 42,
		Body_LeftHandLittleTip = 43,
		Body_RightHandPalm = 44,
		Body_RightHandWrist = 45,
		Body_RightHandThumbMetacarpal = 46,
		Body_RightHandThumbProximal = 47,
		Body_RightHandThumbDistal = 48,
		Body_RightHandThumbTip = 49,
		Body_RightHandIndexMetacarpal = 50,
		Body_RightHandIndexProximal = 51,
		Body_RightHandIndexIntermediate = 52,
		Body_RightHandIndexDistal = 53,
		Body_RightHandIndexTip = 54,
		Body_RightHandMiddleMetacarpal = 55,
		Body_RightHandMiddleProximal = 56,
		Body_RightHandMiddleIntermediate = 57,
		Body_RightHandMiddleDistal = 58,
		Body_RightHandMiddleTip = 59,
		Body_RightHandRingMetacarpal = 60,
		Body_RightHandRingProximal = 61,
		Body_RightHandRingIntermediate = 62,
		Body_RightHandRingDistal = 63,
		Body_RightHandRingTip = 64,
		Body_RightHandLittleMetacarpal = 65,
		Body_RightHandLittleProximal = 66,
		Body_RightHandLittleIntermediate = 67,
		Body_RightHandLittleDistal = 68,
		Body_RightHandLittleTip = 69,
		Body_End = 70,
		FullBody_Start = 0,
		FullBody_Root = 0,
		FullBody_Hips = 1,
		FullBody_SpineLower = 2,
		FullBody_SpineMiddle = 3,
		FullBody_SpineUpper = 4,
		FullBody_Chest = 5,
		FullBody_Neck = 6,
		FullBody_Head = 7,
		FullBody_LeftShoulder = 8,
		FullBody_LeftScapula = 9,
		FullBody_LeftArmUpper = 10,
		FullBody_LeftArmLower = 11,
		FullBody_LeftHandWristTwist = 12,
		FullBody_RightShoulder = 13,
		FullBody_RightScapula = 14,
		FullBody_RightArmUpper = 15,
		FullBody_RightArmLower = 16,
		FullBody_RightHandWristTwist = 17,
		FullBody_LeftHandPalm = 18,
		FullBody_LeftHandWrist = 19,
		FullBody_LeftHandThumbMetacarpal = 20,
		FullBody_LeftHandThumbProximal = 21,
		FullBody_LeftHandThumbDistal = 22,
		FullBody_LeftHandThumbTip = 23,
		FullBody_LeftHandIndexMetacarpal = 24,
		FullBody_LeftHandIndexProximal = 25,
		FullBody_LeftHandIndexIntermediate = 26,
		FullBody_LeftHandIndexDistal = 27,
		FullBody_LeftHandIndexTip = 28,
		FullBody_LeftHandMiddleMetacarpal = 29,
		FullBody_LeftHandMiddleProximal = 30,
		FullBody_LeftHandMiddleIntermediate = 31,
		FullBody_LeftHandMiddleDistal = 32,
		FullBody_LeftHandMiddleTip = 33,
		FullBody_LeftHandRingMetacarpal = 34,
		FullBody_LeftHandRingProximal = 35,
		FullBody_LeftHandRingIntermediate = 36,
		FullBody_LeftHandRingDistal = 37,
		FullBody_LeftHandRingTip = 38,
		FullBody_LeftHandLittleMetacarpal = 39,
		FullBody_LeftHandLittleProximal = 40,
		FullBody_LeftHandLittleIntermediate = 41,
		FullBody_LeftHandLittleDistal = 42,
		FullBody_LeftHandLittleTip = 43,
		FullBody_RightHandPalm = 44,
		FullBody_RightHandWrist = 45,
		FullBody_RightHandThumbMetacarpal = 46,
		FullBody_RightHandThumbProximal = 47,
		FullBody_RightHandThumbDistal = 48,
		FullBody_RightHandThumbTip = 49,
		FullBody_RightHandIndexMetacarpal = 50,
		FullBody_RightHandIndexProximal = 51,
		FullBody_RightHandIndexIntermediate = 52,
		FullBody_RightHandIndexDistal = 53,
		FullBody_RightHandIndexTip = 54,
		FullBody_RightHandMiddleMetacarpal = 55,
		FullBody_RightHandMiddleProximal = 56,
		FullBody_RightHandMiddleIntermediate = 57,
		FullBody_RightHandMiddleDistal = 58,
		FullBody_RightHandMiddleTip = 59,
		FullBody_RightHandRingMetacarpal = 60,
		FullBody_RightHandRingProximal = 61,
		FullBody_RightHandRingIntermediate = 62,
		FullBody_RightHandRingDistal = 63,
		FullBody_RightHandRingTip = 64,
		FullBody_RightHandLittleMetacarpal = 65,
		FullBody_RightHandLittleProximal = 66,
		FullBody_RightHandLittleIntermediate = 67,
		FullBody_RightHandLittleDistal = 68,
		FullBody_RightHandLittleTip = 69,
		FullBody_LeftUpperLeg = 70,
		FullBody_LeftLowerLeg = 71,
		FullBody_LeftFootAnkleTwist = 72,
		FullBody_LeftFootAnkle = 73,
		FullBody_LeftFootSubtalar = 74,
		FullBody_LeftFootTransverse = 75,
		FullBody_LeftFootBall = 76,
		FullBody_RightUpperLeg = 77,
		FullBody_RightLowerLeg = 78,
		FullBody_RightFootAnkleTwist = 79,
		FullBody_RightFootAnkle = 80,
		FullBody_RightFootSubtalar = 81,
		FullBody_RightFootTransverse = 82,
		FullBody_RightFootBall = 83,
		FullBody_End = 84,
		FullBody_Invalid = 85,
		Max = 84
	}

	public enum HandFinger
	{
		Thumb = 0,
		Index = 1,
		Middle = 2,
		Ring = 3,
		Pinky = 4,
		Max = 5
	}

	[Flags]
	public enum HandFingerPinch
	{
		Thumb = 1,
		Index = 2,
		Middle = 4,
		Ring = 8,
		Pinky = 0x10
	}

	public struct HandState
	{
		public HandStatus Status;

		public Posef RootPose;

		public Quatf[] BoneRotations;

		public HandFingerPinch Pinches;

		public float[] PinchStrength;

		public Posef PointerPose;

		public float HandScale;

		public TrackingConfidence HandConfidence;

		public TrackingConfidence[] FingerConfidences;

		public double RequestedTimeStamp;

		public double SampleTimeStamp;
	}

	private struct HandStateInternal
	{
		public HandStatus Status;

		public Posef RootPose;

		public Quatf BoneRotations_0;

		public Quatf BoneRotations_1;

		public Quatf BoneRotations_2;

		public Quatf BoneRotations_3;

		public Quatf BoneRotations_4;

		public Quatf BoneRotations_5;

		public Quatf BoneRotations_6;

		public Quatf BoneRotations_7;

		public Quatf BoneRotations_8;

		public Quatf BoneRotations_9;

		public Quatf BoneRotations_10;

		public Quatf BoneRotations_11;

		public Quatf BoneRotations_12;

		public Quatf BoneRotations_13;

		public Quatf BoneRotations_14;

		public Quatf BoneRotations_15;

		public Quatf BoneRotations_16;

		public Quatf BoneRotations_17;

		public Quatf BoneRotations_18;

		public Quatf BoneRotations_19;

		public Quatf BoneRotations_20;

		public Quatf BoneRotations_21;

		public Quatf BoneRotations_22;

		public Quatf BoneRotations_23;

		public HandFingerPinch Pinches;

		public float PinchStrength_0;

		public float PinchStrength_1;

		public float PinchStrength_2;

		public float PinchStrength_3;

		public float PinchStrength_4;

		public Posef PointerPose;

		public float HandScale;

		public TrackingConfidence HandConfidence;

		public TrackingConfidence FingerConfidences_0;

		public TrackingConfidence FingerConfidences_1;

		public TrackingConfidence FingerConfidences_2;

		public TrackingConfidence FingerConfidences_3;

		public TrackingConfidence FingerConfidences_4;

		public double RequestedTimeStamp;

		public double SampleTimeStamp;
	}

	public struct BoneCapsule
	{
		public short BoneIndex;

		public Vector3f StartPoint;

		public Vector3f EndPoint;

		public float Radius;
	}

	public struct Bone
	{
		public BoneId Id;

		public short ParentBoneIndex;

		public Posef Pose;
	}

	public enum SkeletonConstants
	{
		MaxHandBones = 24,
		MaxBodyBones = 70,
		MaxBones = 84,
		MaxBoneCapsules = 19
	}

	public enum SkeletonType
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1,
		Body = 2,
		FullBody = 3
	}

	public struct Skeleton
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone[] Bones;

		public BoneCapsule[] BoneCapsules;
	}

	public struct Skeleton2
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone[] Bones;

		public BoneCapsule[] BoneCapsules;
	}

	private struct Skeleton2Internal
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone Bones_0;

		public Bone Bones_1;

		public Bone Bones_2;

		public Bone Bones_3;

		public Bone Bones_4;

		public Bone Bones_5;

		public Bone Bones_6;

		public Bone Bones_7;

		public Bone Bones_8;

		public Bone Bones_9;

		public Bone Bones_10;

		public Bone Bones_11;

		public Bone Bones_12;

		public Bone Bones_13;

		public Bone Bones_14;

		public Bone Bones_15;

		public Bone Bones_16;

		public Bone Bones_17;

		public Bone Bones_18;

		public Bone Bones_19;

		public Bone Bones_20;

		public Bone Bones_21;

		public Bone Bones_22;

		public Bone Bones_23;

		public Bone Bones_24;

		public Bone Bones_25;

		public Bone Bones_26;

		public Bone Bones_27;

		public Bone Bones_28;

		public Bone Bones_29;

		public Bone Bones_30;

		public Bone Bones_31;

		public Bone Bones_32;

		public Bone Bones_33;

		public Bone Bones_34;

		public Bone Bones_35;

		public Bone Bones_36;

		public Bone Bones_37;

		public Bone Bones_38;

		public Bone Bones_39;

		public Bone Bones_40;

		public Bone Bones_41;

		public Bone Bones_42;

		public Bone Bones_43;

		public Bone Bones_44;

		public Bone Bones_45;

		public Bone Bones_46;

		public Bone Bones_47;

		public Bone Bones_48;

		public Bone Bones_49;

		public Bone Bones_50;

		public Bone Bones_51;

		public Bone Bones_52;

		public Bone Bones_53;

		public Bone Bones_54;

		public Bone Bones_55;

		public Bone Bones_56;

		public Bone Bones_57;

		public Bone Bones_58;

		public Bone Bones_59;

		public Bone Bones_60;

		public Bone Bones_61;

		public Bone Bones_62;

		public Bone Bones_63;

		public Bone Bones_64;

		public Bone Bones_65;

		public Bone Bones_66;

		public Bone Bones_67;

		public Bone Bones_68;

		public Bone Bones_69;

		public BoneCapsule BoneCapsules_0;

		public BoneCapsule BoneCapsules_1;

		public BoneCapsule BoneCapsules_2;

		public BoneCapsule BoneCapsules_3;

		public BoneCapsule BoneCapsules_4;

		public BoneCapsule BoneCapsules_5;

		public BoneCapsule BoneCapsules_6;

		public BoneCapsule BoneCapsules_7;

		public BoneCapsule BoneCapsules_8;

		public BoneCapsule BoneCapsules_9;

		public BoneCapsule BoneCapsules_10;

		public BoneCapsule BoneCapsules_11;

		public BoneCapsule BoneCapsules_12;

		public BoneCapsule BoneCapsules_13;

		public BoneCapsule BoneCapsules_14;

		public BoneCapsule BoneCapsules_15;

		public BoneCapsule BoneCapsules_16;

		public BoneCapsule BoneCapsules_17;

		public BoneCapsule BoneCapsules_18;
	}

	private struct Skeleton3Internal
	{
		public SkeletonType Type;

		public uint NumBones;

		public uint NumBoneCapsules;

		public Bone Bones_0;

		public Bone Bones_1;

		public Bone Bones_2;

		public Bone Bones_3;

		public Bone Bones_4;

		public Bone Bones_5;

		public Bone Bones_6;

		public Bone Bones_7;

		public Bone Bones_8;

		public Bone Bones_9;

		public Bone Bones_10;

		public Bone Bones_11;

		public Bone Bones_12;

		public Bone Bones_13;

		public Bone Bones_14;

		public Bone Bones_15;

		public Bone Bones_16;

		public Bone Bones_17;

		public Bone Bones_18;

		public Bone Bones_19;

		public Bone Bones_20;

		public Bone Bones_21;

		public Bone Bones_22;

		public Bone Bones_23;

		public Bone Bones_24;

		public Bone Bones_25;

		public Bone Bones_26;

		public Bone Bones_27;

		public Bone Bones_28;

		public Bone Bones_29;

		public Bone Bones_30;

		public Bone Bones_31;

		public Bone Bones_32;

		public Bone Bones_33;

		public Bone Bones_34;

		public Bone Bones_35;

		public Bone Bones_36;

		public Bone Bones_37;

		public Bone Bones_38;

		public Bone Bones_39;

		public Bone Bones_40;

		public Bone Bones_41;

		public Bone Bones_42;

		public Bone Bones_43;

		public Bone Bones_44;

		public Bone Bones_45;

		public Bone Bones_46;

		public Bone Bones_47;

		public Bone Bones_48;

		public Bone Bones_49;

		public Bone Bones_50;

		public Bone Bones_51;

		public Bone Bones_52;

		public Bone Bones_53;

		public Bone Bones_54;

		public Bone Bones_55;

		public Bone Bones_56;

		public Bone Bones_57;

		public Bone Bones_58;

		public Bone Bones_59;

		public Bone Bones_60;

		public Bone Bones_61;

		public Bone Bones_62;

		public Bone Bones_63;

		public Bone Bones_64;

		public Bone Bones_65;

		public Bone Bones_66;

		public Bone Bones_67;

		public Bone Bones_68;

		public Bone Bones_69;

		public Bone Bones_70;

		public Bone Bones_71;

		public Bone Bones_72;

		public Bone Bones_73;

		public Bone Bones_74;

		public Bone Bones_75;

		public Bone Bones_76;

		public Bone Bones_77;

		public Bone Bones_78;

		public Bone Bones_79;

		public Bone Bones_80;

		public Bone Bones_81;

		public Bone Bones_82;

		public Bone Bones_83;

		public BoneCapsule BoneCapsules_0;

		public BoneCapsule BoneCapsules_1;

		public BoneCapsule BoneCapsules_2;

		public BoneCapsule BoneCapsules_3;

		public BoneCapsule BoneCapsules_4;

		public BoneCapsule BoneCapsules_5;

		public BoneCapsule BoneCapsules_6;

		public BoneCapsule BoneCapsules_7;

		public BoneCapsule BoneCapsules_8;

		public BoneCapsule BoneCapsules_9;

		public BoneCapsule BoneCapsules_10;

		public BoneCapsule BoneCapsules_11;

		public BoneCapsule BoneCapsules_12;

		public BoneCapsule BoneCapsules_13;

		public BoneCapsule BoneCapsules_14;

		public BoneCapsule BoneCapsules_15;

		public BoneCapsule BoneCapsules_16;

		public BoneCapsule BoneCapsules_17;

		public BoneCapsule BoneCapsules_18;
	}

	public enum MeshConstants
	{
		MaxVertices = 3000,
		MaxIndices = 18000
	}

	public enum MeshType
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	public class Mesh
	{
		public MeshType Type;

		public uint NumVertices;

		public uint NumIndices;

		public Vector3f[] VertexPositions;

		public short[] Indices;

		public Vector3f[] VertexNormals;

		public Vector2f[] VertexUV0;

		public Vector4s[] BlendIndices;

		public Vector4f[] BlendWeights;
	}

	[Flags]
	public enum SpaceLocationFlags : ulong
	{
		OrientationValid = 1uL,
		PositionValid = 2uL,
		OrientationTracked = 4uL,
		PositionTracked = 8uL
	}

	public struct SpaceLocationf
	{
		public SpaceLocationFlags locationFlags;

		public Posef pose;
	}

	public enum BodyJointSet
	{
		[InspectorName(null)]
		None = -1,
		UpperBody = 0,
		FullBody = 1
	}

	public enum BodyTrackingFidelity2
	{
		Low = 1,
		High = 2
	}

	public enum BodyTrackingCalibrationState
	{
		Valid = 1,
		Calibrating = 2,
		Invalid = 3
	}

	public struct BodyTrackingCalibrationInfo
	{
		public float BodyHeight;
	}

	public struct BodyJointLocation
	{
		public SpaceLocationFlags LocationFlags;

		public Posef Pose;

		public static readonly BodyJointLocation invalid;

		public bool OrientationValid => false;

		public bool PositionValid => false;

		public bool OrientationTracked => false;

		public bool PositionTracked => false;
	}

	public struct BodyState
	{
		public BodyJointLocation[] JointLocations;

		public float Confidence;

		public uint SkeletonChangedCount;

		public double Time;

		public BodyJointSet JointSet;

		public BodyTrackingCalibrationState CalibrationStatus;

		public BodyTrackingFidelity2 Fidelity;
	}

	private struct BodyStateInternal
	{
		public Bool IsActive;

		public float Confidence;

		public uint SkeletonChangedCount;

		public double Time;

		public BodyJointLocation JointLocation_0;

		public BodyJointLocation JointLocation_1;

		public BodyJointLocation JointLocation_2;

		public BodyJointLocation JointLocation_3;

		public BodyJointLocation JointLocation_4;

		public BodyJointLocation JointLocation_5;

		public BodyJointLocation JointLocation_6;

		public BodyJointLocation JointLocation_7;

		public BodyJointLocation JointLocation_8;

		public BodyJointLocation JointLocation_9;

		public BodyJointLocation JointLocation_10;

		public BodyJointLocation JointLocation_11;

		public BodyJointLocation JointLocation_12;

		public BodyJointLocation JointLocation_13;

		public BodyJointLocation JointLocation_14;

		public BodyJointLocation JointLocation_15;

		public BodyJointLocation JointLocation_16;

		public BodyJointLocation JointLocation_17;

		public BodyJointLocation JointLocation_18;

		public BodyJointLocation JointLocation_19;

		public BodyJointLocation JointLocation_20;

		public BodyJointLocation JointLocation_21;

		public BodyJointLocation JointLocation_22;

		public BodyJointLocation JointLocation_23;

		public BodyJointLocation JointLocation_24;

		public BodyJointLocation JointLocation_25;

		public BodyJointLocation JointLocation_26;

		public BodyJointLocation JointLocation_27;

		public BodyJointLocation JointLocation_28;

		public BodyJointLocation JointLocation_29;

		public BodyJointLocation JointLocation_30;

		public BodyJointLocation JointLocation_31;

		public BodyJointLocation JointLocation_32;

		public BodyJointLocation JointLocation_33;

		public BodyJointLocation JointLocation_34;

		public BodyJointLocation JointLocation_35;

		public BodyJointLocation JointLocation_36;

		public BodyJointLocation JointLocation_37;

		public BodyJointLocation JointLocation_38;

		public BodyJointLocation JointLocation_39;

		public BodyJointLocation JointLocation_40;

		public BodyJointLocation JointLocation_41;

		public BodyJointLocation JointLocation_42;

		public BodyJointLocation JointLocation_43;

		public BodyJointLocation JointLocation_44;

		public BodyJointLocation JointLocation_45;

		public BodyJointLocation JointLocation_46;

		public BodyJointLocation JointLocation_47;

		public BodyJointLocation JointLocation_48;

		public BodyJointLocation JointLocation_49;

		public BodyJointLocation JointLocation_50;

		public BodyJointLocation JointLocation_51;

		public BodyJointLocation JointLocation_52;

		public BodyJointLocation JointLocation_53;

		public BodyJointLocation JointLocation_54;

		public BodyJointLocation JointLocation_55;

		public BodyJointLocation JointLocation_56;

		public BodyJointLocation JointLocation_57;

		public BodyJointLocation JointLocation_58;

		public BodyJointLocation JointLocation_59;

		public BodyJointLocation JointLocation_60;

		public BodyJointLocation JointLocation_61;

		public BodyJointLocation JointLocation_62;

		public BodyJointLocation JointLocation_63;

		public BodyJointLocation JointLocation_64;

		public BodyJointLocation JointLocation_65;

		public BodyJointLocation JointLocation_66;

		public BodyJointLocation JointLocation_67;

		public BodyJointLocation JointLocation_68;

		public BodyJointLocation JointLocation_69;
	}

	private struct BodyState4Internal
	{
		public Bool IsActive;

		public float Confidence;

		public uint SkeletonChangedCount;

		public double Time;

		public BodyJointLocation JointLocation_0;

		public BodyJointLocation JointLocation_1;

		public BodyJointLocation JointLocation_2;

		public BodyJointLocation JointLocation_3;

		public BodyJointLocation JointLocation_4;

		public BodyJointLocation JointLocation_5;

		public BodyJointLocation JointLocation_6;

		public BodyJointLocation JointLocation_7;

		public BodyJointLocation JointLocation_8;

		public BodyJointLocation JointLocation_9;

		public BodyJointLocation JointLocation_10;

		public BodyJointLocation JointLocation_11;

		public BodyJointLocation JointLocation_12;

		public BodyJointLocation JointLocation_13;

		public BodyJointLocation JointLocation_14;

		public BodyJointLocation JointLocation_15;

		public BodyJointLocation JointLocation_16;

		public BodyJointLocation JointLocation_17;

		public BodyJointLocation JointLocation_18;

		public BodyJointLocation JointLocation_19;

		public BodyJointLocation JointLocation_20;

		public BodyJointLocation JointLocation_21;

		public BodyJointLocation JointLocation_22;

		public BodyJointLocation JointLocation_23;

		public BodyJointLocation JointLocation_24;

		public BodyJointLocation JointLocation_25;

		public BodyJointLocation JointLocation_26;

		public BodyJointLocation JointLocation_27;

		public BodyJointLocation JointLocation_28;

		public BodyJointLocation JointLocation_29;

		public BodyJointLocation JointLocation_30;

		public BodyJointLocation JointLocation_31;

		public BodyJointLocation JointLocation_32;

		public BodyJointLocation JointLocation_33;

		public BodyJointLocation JointLocation_34;

		public BodyJointLocation JointLocation_35;

		public BodyJointLocation JointLocation_36;

		public BodyJointLocation JointLocation_37;

		public BodyJointLocation JointLocation_38;

		public BodyJointLocation JointLocation_39;

		public BodyJointLocation JointLocation_40;

		public BodyJointLocation JointLocation_41;

		public BodyJointLocation JointLocation_42;

		public BodyJointLocation JointLocation_43;

		public BodyJointLocation JointLocation_44;

		public BodyJointLocation JointLocation_45;

		public BodyJointLocation JointLocation_46;

		public BodyJointLocation JointLocation_47;

		public BodyJointLocation JointLocation_48;

		public BodyJointLocation JointLocation_49;

		public BodyJointLocation JointLocation_50;

		public BodyJointLocation JointLocation_51;

		public BodyJointLocation JointLocation_52;

		public BodyJointLocation JointLocation_53;

		public BodyJointLocation JointLocation_54;

		public BodyJointLocation JointLocation_55;

		public BodyJointLocation JointLocation_56;

		public BodyJointLocation JointLocation_57;

		public BodyJointLocation JointLocation_58;

		public BodyJointLocation JointLocation_59;

		public BodyJointLocation JointLocation_60;

		public BodyJointLocation JointLocation_61;

		public BodyJointLocation JointLocation_62;

		public BodyJointLocation JointLocation_63;

		public BodyJointLocation JointLocation_64;

		public BodyJointLocation JointLocation_65;

		public BodyJointLocation JointLocation_66;

		public BodyJointLocation JointLocation_67;

		public BodyJointLocation JointLocation_68;

		public BodyJointLocation JointLocation_69;

		public BodyJointLocation JointLocation_70;

		public BodyJointLocation JointLocation_71;

		public BodyJointLocation JointLocation_72;

		public BodyJointLocation JointLocation_73;

		public BodyJointLocation JointLocation_74;

		public BodyJointLocation JointLocation_75;

		public BodyJointLocation JointLocation_76;

		public BodyJointLocation JointLocation_77;

		public BodyJointLocation JointLocation_78;

		public BodyJointLocation JointLocation_79;

		public BodyJointLocation JointLocation_80;

		public BodyJointLocation JointLocation_81;

		public BodyJointLocation JointLocation_82;

		public BodyJointLocation JointLocation_83;

		public BodyTrackingCalibrationState CalibrationStatus;

		public BodyTrackingFidelity2 Fidelity;
	}

	public struct KeyboardState
	{
		public Bool IsActive;

		public Bool OrientationValid;

		public Bool PositionValid;

		public Bool OrientationTracked;

		public Bool PositionTracked;

		public PoseStatef PoseState;

		public Vector4f ContrastParameters;
	}

	public enum KeyboardDescriptionConstants
	{
		NameMaxLength = 0x80
	}

	public enum TrackedKeyboardPresentationStyles
	{
		Unknown = 0,
		Opaque = 1,
		MR = 2
	}

	public enum TrackedKeyboardFlags
	{
		Exists = 1,
		Local = 2,
		Remote = 4,
		Connected = 8
	}

	public enum TrackedKeyboardQueryFlags
	{
		Local = 2,
		Remote = 4
	}

	public struct KeyboardDescription
	{
		public byte[] Name;

		public ulong TrackedKeyboardId;

		public Vector3f Dimensions;

		public TrackedKeyboardFlags KeyboardFlags;

		public TrackedKeyboardPresentationStyles SupportedPresentationStyles;
	}

	public struct FaceExpressionStatus
	{
		public bool IsValid;

		public bool IsEyeFollowingBlendshapesValid;
	}

	public struct FaceState
	{
		public float[] ExpressionWeights;

		public float[] ExpressionWeightConfidences;

		public FaceExpressionStatus Status;

		public FaceTrackingDataSource DataSource;

		public double Time;
	}

	private struct FaceExpressionStatusInternal
	{
		public Bool IsValid;

		public Bool IsEyeFollowingBlendshapesValid;

		public FaceExpressionStatus ToFaceExpressionStatus()
		{
			return default(FaceExpressionStatus);
		}
	}

	private struct FaceStateInternal
	{
		public float ExpressionWeights_0;

		public float ExpressionWeights_1;

		public float ExpressionWeights_2;

		public float ExpressionWeights_3;

		public float ExpressionWeights_4;

		public float ExpressionWeights_5;

		public float ExpressionWeights_6;

		public float ExpressionWeights_7;

		public float ExpressionWeights_8;

		public float ExpressionWeights_9;

		public float ExpressionWeights_10;

		public float ExpressionWeights_11;

		public float ExpressionWeights_12;

		public float ExpressionWeights_13;

		public float ExpressionWeights_14;

		public float ExpressionWeights_15;

		public float ExpressionWeights_16;

		public float ExpressionWeights_17;

		public float ExpressionWeights_18;

		public float ExpressionWeights_19;

		public float ExpressionWeights_20;

		public float ExpressionWeights_21;

		public float ExpressionWeights_22;

		public float ExpressionWeights_23;

		public float ExpressionWeights_24;

		public float ExpressionWeights_25;

		public float ExpressionWeights_26;

		public float ExpressionWeights_27;

		public float ExpressionWeights_28;

		public float ExpressionWeights_29;

		public float ExpressionWeights_30;

		public float ExpressionWeights_31;

		public float ExpressionWeights_32;

		public float ExpressionWeights_33;

		public float ExpressionWeights_34;

		public float ExpressionWeights_35;

		public float ExpressionWeights_36;

		public float ExpressionWeights_37;

		public float ExpressionWeights_38;

		public float ExpressionWeights_39;

		public float ExpressionWeights_40;

		public float ExpressionWeights_41;

		public float ExpressionWeights_42;

		public float ExpressionWeights_43;

		public float ExpressionWeights_44;

		public float ExpressionWeights_45;

		public float ExpressionWeights_46;

		public float ExpressionWeights_47;

		public float ExpressionWeights_48;

		public float ExpressionWeights_49;

		public float ExpressionWeights_50;

		public float ExpressionWeights_51;

		public float ExpressionWeights_52;

		public float ExpressionWeights_53;

		public float ExpressionWeights_54;

		public float ExpressionWeights_55;

		public float ExpressionWeights_56;

		public float ExpressionWeights_57;

		public float ExpressionWeights_58;

		public float ExpressionWeights_59;

		public float ExpressionWeights_60;

		public float ExpressionWeights_61;

		public float ExpressionWeights_62;

		public float ExpressionWeightConfidences_0;

		public float ExpressionWeightConfidences_1;

		public FaceExpressionStatusInternal Status;

		public double Time;
	}

	private struct FaceState2Internal
	{
		public float ExpressionWeights_0;

		public float ExpressionWeights_1;

		public float ExpressionWeights_2;

		public float ExpressionWeights_3;

		public float ExpressionWeights_4;

		public float ExpressionWeights_5;

		public float ExpressionWeights_6;

		public float ExpressionWeights_7;

		public float ExpressionWeights_8;

		public float ExpressionWeights_9;

		public float ExpressionWeights_10;

		public float ExpressionWeights_11;

		public float ExpressionWeights_12;

		public float ExpressionWeights_13;

		public float ExpressionWeights_14;

		public float ExpressionWeights_15;

		public float ExpressionWeights_16;

		public float ExpressionWeights_17;

		public float ExpressionWeights_18;

		public float ExpressionWeights_19;

		public float ExpressionWeights_20;

		public float ExpressionWeights_21;

		public float ExpressionWeights_22;

		public float ExpressionWeights_23;

		public float ExpressionWeights_24;

		public float ExpressionWeights_25;

		public float ExpressionWeights_26;

		public float ExpressionWeights_27;

		public float ExpressionWeights_28;

		public float ExpressionWeights_29;

		public float ExpressionWeights_30;

		public float ExpressionWeights_31;

		public float ExpressionWeights_32;

		public float ExpressionWeights_33;

		public float ExpressionWeights_34;

		public float ExpressionWeights_35;

		public float ExpressionWeights_36;

		public float ExpressionWeights_37;

		public float ExpressionWeights_38;

		public float ExpressionWeights_39;

		public float ExpressionWeights_40;

		public float ExpressionWeights_41;

		public float ExpressionWeights_42;

		public float ExpressionWeights_43;

		public float ExpressionWeights_44;

		public float ExpressionWeights_45;

		public float ExpressionWeights_46;

		public float ExpressionWeights_47;

		public float ExpressionWeights_48;

		public float ExpressionWeights_49;

		public float ExpressionWeights_50;

		public float ExpressionWeights_51;

		public float ExpressionWeights_52;

		public float ExpressionWeights_53;

		public float ExpressionWeights_54;

		public float ExpressionWeights_55;

		public float ExpressionWeights_56;

		public float ExpressionWeights_57;

		public float ExpressionWeights_58;

		public float ExpressionWeights_59;

		public float ExpressionWeights_60;

		public float ExpressionWeights_61;

		public float ExpressionWeights_62;

		public float ExpressionWeights_63;

		public float ExpressionWeights_64;

		public float ExpressionWeights_65;

		public float ExpressionWeights_66;

		public float ExpressionWeights_67;

		public float ExpressionWeights_68;

		public float ExpressionWeights_69;

		public float ExpressionWeightConfidences_0;

		public float ExpressionWeightConfidences_1;

		public FaceExpressionStatusInternal Status;

		public FaceTrackingDataSource DataSource;

		public double Time;
	}

	public enum FaceRegionConfidence
	{
		Lower = 0,
		Upper = 1,
		Max = 2
	}

	public enum FaceExpression
	{
		Invalid = -1,
		Brow_Lowerer_L = 0,
		Brow_Lowerer_R = 1,
		Cheek_Puff_L = 2,
		Cheek_Puff_R = 3,
		Cheek_Raiser_L = 4,
		Cheek_Raiser_R = 5,
		Cheek_Suck_L = 6,
		Cheek_Suck_R = 7,
		Chin_Raiser_B = 8,
		Chin_Raiser_T = 9,
		Dimpler_L = 10,
		Dimpler_R = 11,
		Eyes_Closed_L = 12,
		Eyes_Closed_R = 13,
		Eyes_Look_Down_L = 14,
		Eyes_Look_Down_R = 15,
		Eyes_Look_Left_L = 16,
		Eyes_Look_Left_R = 17,
		Eyes_Look_Right_L = 18,
		Eyes_Look_Right_R = 19,
		Eyes_Look_Up_L = 20,
		Eyes_Look_Up_R = 21,
		Inner_Brow_Raiser_L = 22,
		Inner_Brow_Raiser_R = 23,
		Jaw_Drop = 24,
		Jaw_Sideways_Left = 25,
		Jaw_Sideways_Right = 26,
		Jaw_Thrust = 27,
		Lid_Tightener_L = 28,
		Lid_Tightener_R = 29,
		Lip_Corner_Depressor_L = 30,
		Lip_Corner_Depressor_R = 31,
		Lip_Corner_Puller_L = 32,
		Lip_Corner_Puller_R = 33,
		Lip_Funneler_LB = 34,
		Lip_Funneler_LT = 35,
		Lip_Funneler_RB = 36,
		Lip_Funneler_RT = 37,
		Lip_Pressor_L = 38,
		Lip_Pressor_R = 39,
		Lip_Pucker_L = 40,
		Lip_Pucker_R = 41,
		Lip_Stretcher_L = 42,
		Lip_Stretcher_R = 43,
		Lip_Suck_LB = 44,
		Lip_Suck_LT = 45,
		Lip_Suck_RB = 46,
		Lip_Suck_RT = 47,
		Lip_Tightener_L = 48,
		Lip_Tightener_R = 49,
		Lips_Toward = 50,
		Lower_Lip_Depressor_L = 51,
		Lower_Lip_Depressor_R = 52,
		Mouth_Left = 53,
		Mouth_Right = 54,
		Nose_Wrinkler_L = 55,
		Nose_Wrinkler_R = 56,
		Outer_Brow_Raiser_L = 57,
		Outer_Brow_Raiser_R = 58,
		Upper_Lid_Raiser_L = 59,
		Upper_Lid_Raiser_R = 60,
		Upper_Lip_Raiser_L = 61,
		Upper_Lip_Raiser_R = 62,
		Max = 63
	}

	public enum FaceExpression2
	{
		Invalid = -1,
		Brow_Lowerer_L = 0,
		Brow_Lowerer_R = 1,
		Cheek_Puff_L = 2,
		Cheek_Puff_R = 3,
		Cheek_Raiser_L = 4,
		Cheek_Raiser_R = 5,
		Cheek_Suck_L = 6,
		Cheek_Suck_R = 7,
		Chin_Raiser_B = 8,
		Chin_Raiser_T = 9,
		Dimpler_L = 10,
		Dimpler_R = 11,
		Eyes_Closed_L = 12,
		Eyes_Closed_R = 13,
		Eyes_Look_Down_L = 14,
		Eyes_Look_Down_R = 15,
		Eyes_Look_Left_L = 16,
		Eyes_Look_Left_R = 17,
		Eyes_Look_Right_L = 18,
		Eyes_Look_Right_R = 19,
		Eyes_Look_Up_L = 20,
		Eyes_Look_Up_R = 21,
		Inner_Brow_Raiser_L = 22,
		Inner_Brow_Raiser_R = 23,
		Jaw_Drop = 24,
		Jaw_Sideways_Left = 25,
		Jaw_Sideways_Right = 26,
		Jaw_Thrust = 27,
		Lid_Tightener_L = 28,
		Lid_Tightener_R = 29,
		Lip_Corner_Depressor_L = 30,
		Lip_Corner_Depressor_R = 31,
		Lip_Corner_Puller_L = 32,
		Lip_Corner_Puller_R = 33,
		Lip_Funneler_LB = 34,
		Lip_Funneler_LT = 35,
		Lip_Funneler_RB = 36,
		Lip_Funneler_RT = 37,
		Lip_Pressor_L = 38,
		Lip_Pressor_R = 39,
		Lip_Pucker_L = 40,
		Lip_Pucker_R = 41,
		Lip_Stretcher_L = 42,
		Lip_Stretcher_R = 43,
		Lip_Suck_LB = 44,
		Lip_Suck_LT = 45,
		Lip_Suck_RB = 46,
		Lip_Suck_RT = 47,
		Lip_Tightener_L = 48,
		Lip_Tightener_R = 49,
		Lips_Toward = 50,
		Lower_Lip_Depressor_L = 51,
		Lower_Lip_Depressor_R = 52,
		Mouth_Left = 53,
		Mouth_Right = 54,
		Nose_Wrinkler_L = 55,
		Nose_Wrinkler_R = 56,
		Outer_Brow_Raiser_L = 57,
		Outer_Brow_Raiser_R = 58,
		Upper_Lid_Raiser_L = 59,
		Upper_Lid_Raiser_R = 60,
		Upper_Lip_Raiser_L = 61,
		Upper_Lip_Raiser_R = 62,
		Tongue_Tip_Interdental = 63,
		Tongue_Tip_Alveolar = 64,
		Tongue_Front_Dorsal_Palate = 65,
		Tongue_Mid_Dorsal_Palate = 66,
		Tongue_Back_Dorsal_Velar = 67,
		Tongue_Out = 68,
		Tongue_Retreat = 69,
		Max = 70
	}

	public enum FaceTrackingDataSource
	{
		Visual = 0,
		Audio = 1,
		Count = 2
	}

	public enum FaceConstants
	{
		MaxFaceExpressions = 63,
		MaxFaceRegionConfidences = 2,
		MaxFaceExpressions2 = 70
	}

	public struct EyeGazeState
	{
		public Posef Pose;

		public float Confidence;

		internal Bool _isValid;

		public bool IsValid => false;
	}

	public struct EyeGazesState
	{
		public EyeGazeState[] EyeGazes;

		public double Time;
	}

	private struct EyeGazesStateInternal
	{
		public EyeGazeState EyeGazes_0;

		public EyeGazeState EyeGazes_1;

		public double Time;
	}

	public enum ColorSpace
	{
		Unknown = 0,
		Unmanaged = 1,
		Rec_2020 = 2,
		Rec_709 = 3,
		Rift_CV1 = 4,
		Rift_S = 5,
		Quest = 6,
		P3 = 7,
		Adobe_RGB = 8
	}

	public enum EventType
	{
		Unknown = 0,
		DisplayRefreshRateChanged = 1,
		SpatialAnchorCreateComplete = 49,
		SpaceSetComponentStatusComplete = 50,
		SpaceQueryResults = 51,
		SpaceQueryComplete = 52,
		SpaceSaveComplete = 53,
		SpaceEraseComplete = 54,
		SpaceShareResult = 56,
		SpaceListSaveResult = 57,
		SceneCaptureComplete = 100,
		VirtualKeyboardCommitText = 201,
		VirtualKeyboardBackspace = 202,
		VirtualKeyboardEnter = 203,
		VirtualKeyboardShown = 204,
		VirtualKeyboardHidden = 205
	}

	public struct EventDataBuffer
	{
		public EventType EventType;

		public byte[] EventData;
	}

	public struct RenderModelProperties
	{
		public string ModelName;

		public ulong ModelKey;

		public uint VendorId;

		public uint ModelVersion;
	}

	private struct RenderModelPropertiesInternal
	{
		public byte[] ModelName;

		public ulong ModelKey;

		public uint VendorId;

		public uint ModelVersion;
	}

	[Flags]
	public enum RenderModelFlags
	{
		SupportsGltf20Subset1 = 1,
		SupportsGltf20Subset2 = 2
	}

	public enum VirtualKeyboardLocationType
	{
		Custom = 0,
		Far = 1,
		Direct = 2
	}

	public struct VirtualKeyboardSpaceCreateInfo
	{
		public VirtualKeyboardLocationType locationType;

		public Posef pose;
	}

	public struct VirtualKeyboardLocationInfo
	{
		public VirtualKeyboardLocationType locationType;

		public Posef pose;

		public float scale;
	}

	public struct VirtualKeyboardCreateInfo
	{
	}

	public enum VirtualKeyboardInputSource
	{
		Invalid = 0,
		ControllerRayLeft = 1,
		ControllerRayRight = 2,
		HandRayLeft = 3,
		HandRayRight = 4,
		ControllerDirectLeft = 5,
		ControllerDirectRight = 6,
		HandDirectIndexTipLeft = 7,
		HandDirectIndexTipRight = 8,
		EnumSize = int.MaxValue
	}

	[Flags]
	public enum VirtualKeyboardInputStateFlags : ulong
	{
		IsPressed = 1uL
	}

	public struct VirtualKeyboardInputInfo
	{
		public VirtualKeyboardInputSource inputSource;

		public Posef inputPose;

		public VirtualKeyboardInputStateFlags inputState;
	}

	public struct VirtualKeyboardModelAnimationState
	{
		public int AnimationIndex;

		public float Fraction;
	}

	public struct VirtualKeyboardModelAnimationStates
	{
		public VirtualKeyboardModelAnimationState[] States;
	}

	public struct VirtualKeyboardModelAnimationStatesInternal
	{
		public uint StateCapacityInput;

		public uint StateCountOutput;

		public IntPtr StatesBuffer;
	}

	public struct VirtualKeyboardTextureIds
	{
		public ulong[] TextureIds;
	}

	public struct VirtualKeyboardTextureIdsInternal
	{
		public uint TextureIdCapacityInput;

		public uint TextureIdCountOutput;

		public IntPtr TextureIdsBuffer;
	}

	public struct VirtualKeyboardTextureData
	{
		public uint TextureWidth;

		public uint TextureHeight;

		public uint BufferCapacityInput;

		public uint BufferCountOutput;

		public IntPtr Buffer;
	}

	public struct VirtualKeyboardModelVisibility
	{
		internal Bool _visible;

		public bool Visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}

	public enum InsightPassthroughColorMapType
	{
		None = 0,
		MonoToRgba = 1,
		MonoToMono = 2,
		BrightnessContrastSaturation = 4,
		ColorLut = 6,
		InterpolatedColorLut = 7
	}

	public enum InsightPassthroughStyleFlags
	{
		HasTextureOpacityFactor = 1,
		HasEdgeColor = 2,
		HasTextureColorMap = 4
	}

	public struct InsightPassthroughStyle
	{
		public InsightPassthroughStyleFlags Flags;

		public float TextureOpacityFactor;

		public Colorf EdgeColor;

		public InsightPassthroughColorMapType TextureColorMapType;

		public uint TextureColorMapDataSize;

		public IntPtr TextureColorMapData;
	}

	public struct InsightPassthroughStyle2
	{
		public InsightPassthroughStyleFlags Flags;

		public float TextureOpacityFactor;

		public Colorf EdgeColor;

		public InsightPassthroughColorMapType TextureColorMapType;

		public uint TextureColorMapDataSize;

		public IntPtr TextureColorMapData;

		public ulong LutSource;

		public ulong LutTarget;

		public float LutWeight;

		public void CopyTo(ref InsightPassthroughStyle target)
		{
		}
	}

	public enum PassthroughColorLutChannels
	{
		Rgb = 1,
		Rgba = 2
	}

	public struct PassthroughColorLutData
	{
		public uint BufferSize;

		public IntPtr Buffer;
	}

	public struct InsightPassthroughKeyboardHandsIntensity
	{
		public float LeftHandIntensity;

		public float RightHandIntensity;
	}

	public enum PassthroughCapabilityFlags
	{
		Passthrough = 1,
		Color = 2,
		Depth = 4
	}

	public enum PassthroughCapabilityFields
	{
		Flags = 1,
		MaxColorLutResolution = 2
	}

	public struct PassthroughCapabilities
	{
		public PassthroughCapabilityFields Fields;

		public PassthroughCapabilityFlags Flags;

		public uint MaxColorLutResolution;
	}

	public enum SpaceComponentType
	{
		Locatable = 0,
		Storable = 1,
		Sharable = 2,
		Bounded2D = 3,
		Bounded3D = 4,
		SemanticLabels = 5,
		RoomLayout = 6,
		SpaceContainer = 7,
		TriangleMesh = 1000269000
	}

	public enum SpaceStorageLocation
	{
		Invalid = 0,
		Local = 1,
		Cloud = 2
	}

	public enum SpaceStoragePersistenceMode
	{
		Invalid = 0,
		Indefinite = 1
	}

	public enum SpaceQueryActionType
	{
		Load = 0
	}

	public enum SpaceQueryType
	{
		Action = 0
	}

	public enum SpaceQueryFilterType
	{
		None = 0,
		Ids = 1,
		Components = 2
	}

	public struct SpatialAnchorCreateInfo
	{
		public TrackingOrigin BaseTracking;

		public Posef PoseInSpace;

		public double Time;
	}

	public struct SpaceFilterInfoIds
	{
		public Guid[] Ids;

		public int NumIds;
	}

	public struct SpaceFilterInfoComponents
	{
		public SpaceComponentType[] Components;

		public int NumComponents;
	}

	public struct SpaceQueryInfo
	{
		public SpaceQueryType QueryType;

		public int MaxQuerySpaces;

		public double Timeout;

		public SpaceStorageLocation Location;

		public SpaceQueryActionType ActionType;

		public SpaceQueryFilterType FilterType;

		public SpaceFilterInfoIds IdInfo;

		public SpaceFilterInfoComponents ComponentsInfo;
	}

	public struct SpaceQueryResult
	{
		public ulong space;

		public Guid uuid;
	}

	public class Media
	{
		public enum MrcActivationMode
		{
			Automatic = 0,
			Disabled = 1,
			EnumSize = int.MaxValue
		}

		public enum PlatformCameraMode
		{
			Disabled = -1,
			Initialized = 0,
			UserControlled = 1,
			SmartNavigated = 2,
			StabilizedPoV = 3,
			RemoteDroneControlled = 4,
			RemoteSpatialMapped = 5,
			SpectatorMode = 6,
			MobileMRC = 7,
			EnumSize = int.MaxValue
		}

		public enum InputVideoBufferType
		{
			Memory = 0,
			TextureHandle = 1,
			EnumSize = int.MaxValue
		}

		private static Texture2D cachedTexture;

		public static bool Initialize()
		{
			return false;
		}

		public static bool Shutdown()
		{
			return false;
		}

		public static bool GetInitialized()
		{
			return false;
		}

		public static bool Update()
		{
			return false;
		}

		public static MrcActivationMode GetMrcActivationMode()
		{
			return default(MrcActivationMode);
		}

		public static bool SetMrcActivationMode(MrcActivationMode mode)
		{
			return false;
		}

		public static bool SetPlatformInitialized()
		{
			return false;
		}

		public static PlatformCameraMode GetPlatformCameraMode()
		{
			return default(PlatformCameraMode);
		}

		public static bool SetPlatformCameraMode(PlatformCameraMode mode)
		{
			return false;
		}

		public static bool IsMrcEnabled()
		{
			return false;
		}

		public static bool IsMrcActivated()
		{
			return false;
		}

		public static bool UseMrcDebugCamera()
		{
			return false;
		}

		public static bool SetMrcInputVideoBufferType(InputVideoBufferType videoBufferType)
		{
			return false;
		}

		public static InputVideoBufferType GetMrcInputVideoBufferType()
		{
			return default(InputVideoBufferType);
		}

		public static bool SetMrcFrameSize(int frameWidth, int frameHeight)
		{
			return false;
		}

		public static void GetMrcFrameSize(out int frameWidth, out int frameHeight)
		{
			frameWidth = default(int);
			frameHeight = default(int);
		}

		public static bool SetMrcAudioSampleRate(int sampleRate)
		{
			return false;
		}

		public static int GetMrcAudioSampleRate()
		{
			return 0;
		}

		public static bool SetMrcFrameImageFlipped(bool imageFlipped)
		{
			return false;
		}

		public static bool GetMrcFrameImageFlipped()
		{
			return false;
		}

		public static bool EncodeMrcFrame(IntPtr textureHandle, IntPtr fgTextureHandle, float[] audioData, int audioFrames, int audioChannels, double timestamp, double poseTime, ref int outSyncId)
		{
			return false;
		}

		public static bool EncodeMrcFrame(RenderTexture frame, float[] audioData, int audioFrames, int audioChannels, double timestamp, double poseTime, ref int outSyncId)
		{
			return false;
		}

		public static bool SyncMrcFrame(int syncId)
		{
			return false;
		}

		public static bool SetAvailableQueueIndexVulkan(uint queueIndexVk)
		{
			return false;
		}

		public static bool SetMrcHeadsetControllerPose(Posef headsetPose, Posef leftControllerPose, Posef rightControllerPose)
		{
			return false;
		}

		public static bool IsCastingToRemoteClient()
		{
			return false;
		}
	}

	private delegate Bone GetBoneSkeleton2Delegate();

	private delegate Bone GetBoneSkeleton3Delegate();

	public delegate IntPtr VirtualKeyboardModelAnimationStateBufferProvider(int minimumBufferLength, int stateCount);

	public delegate void VirtualKeyboardModelAnimationStateHandler(ref VirtualKeyboardModelAnimationState state);

	private struct SpaceContainerInternal
	{
		public int uuidCapacityInput;

		public int uuidCountOutput;

		public IntPtr uuids;
	}

	private struct SpaceSemanticLabelInternal
	{
		public int byteCapacityInput;

		public int byteCountOutput;

		public IntPtr labels;
	}

	public struct RoomLayout
	{
		public Guid floorUuid;

		public Guid ceilingUuid;

		public Guid[] wallUuids;
	}

	private struct RoomLayoutInternal
	{
		public Guid floorUuid;

		public Guid ceilingUuid;

		public int wallUuidCapacityInput;

		public int wallUuidCountOutput;

		public IntPtr wallUuids;
	}

	private struct PolygonalBoundary2DInternal
	{
		public int vertexCapacityInput;

		public int vertexCountOutput;

		public IntPtr vertices;
	}

	private struct SceneCaptureRequestInternal
	{
		public int requestByteCount;

		public string request;
	}

	private struct PinnedArray<T> : IDisposable where T : struct
	{
		private GCHandle _handle;

		public PinnedArray(T[] array)
		{
			_handle = default(GCHandle);
		}

		public void Dispose()
		{
		}

		public static implicit operator IntPtr(PinnedArray<T> pinnedArray)
		{
			return (IntPtr)0;
		}
	}

	private struct TriangleMeshInternal
	{
		public int vertexCapacityInput;

		public int vertexCountOutput;

		public IntPtr vertices;

		public int indexCapacityInput;

		public int indexCountOutput;

		public IntPtr indices;
	}

	[Flags]
	public enum PassthroughPreferenceFields
	{
		Flags = 1
	}

	[Flags]
	public enum PassthroughPreferenceFlags : long
	{
		DefaultToActive = 1L
	}

	public struct PassthroughPreferences
	{
		public PassthroughPreferenceFields Fields;

		public PassthroughPreferenceFlags Flags;
	}

	public class Ktx
	{
		public static IntPtr LoadKtxFromMemory(IntPtr dataPtr, uint length)
		{
			return (IntPtr)0;
		}

		public static uint GetKtxTextureWidth(IntPtr texture)
		{
			return 0u;
		}

		public static uint GetKtxTextureHeight(IntPtr texture)
		{
			return 0u;
		}

		public static bool TranscodeKtxTexture(IntPtr texture, uint format)
		{
			return false;
		}

		public static uint GetKtxTextureSize(IntPtr texture)
		{
			return 0u;
		}

		public static bool GetKtxTextureData(IntPtr texture, IntPtr textureData, uint bufferSize)
		{
			return false;
		}

		public static bool DestroyKtxTexture(IntPtr texture)
		{
			return false;
		}
	}

	public class UnityOpenXR
	{
		public static bool Enabled;

		public static void SetClientVersion()
		{
		}

		public static IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		public static bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		public static void OnInstanceDestroy(ulong xrInstance)
		{
		}

		public static void OnSessionCreate(ulong xrSession)
		{
		}

		public static void OnAppSpaceChange(ulong xrSpace)
		{
		}

		public static void OnSessionStateChange(int oldState, int newState)
		{
		}

		public static void OnSessionBegin(ulong xrSession)
		{
		}

		public static void OnSessionEnd(ulong xrSession)
		{
		}

		public static void OnSessionExiting(ulong xrSession)
		{
		}

		public static void OnSessionDestroy(ulong xrSession)
		{
		}
	}

	public static class Qpl
	{
		public enum ResultType : short
		{
			Success = 2,
			Fail = 3,
			Cancel = 4
		}

		public const int DefaultInstanceKey = 0;

		public const long AutoSetTimestampMs = -1L;

		public const int AutoSetTimeoutMs = 0;

		public static void SetConsent(Bool consent)
		{
		}

		public static void MarkerStart(int markerId, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public static void MarkerEnd(int markerId, ResultType resultTypeId = ResultType.Success, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public static void MarkerPointCached(int markerId, int nameHandle, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public static void MarkerAnnotation(int markerId, string annotationKey, string annotationValue, int instanceKey = 0)
		{
		}

		public static bool CreateMarkerHandle(string name, out int nameHandle)
		{
			nameHandle = default(int);
			return false;
		}

		public static bool DestroyMarkerHandle(int nameHandle)
		{
			return false;
		}
	}

	private static class OVRP_0_1_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Sizei ovrp_GetEyeTextureSize(Eye eyeId);
	}

	private static class OVRP_0_1_1
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_SetOverlayQuad2(Bool onTop, Bool headLocked, IntPtr texture, IntPtr device, Posef pose, Vector3f scale);
	}

	private static class OVRP_0_1_2
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Posef ovrp_GetNodePose(Node nodeId);

		[PreserveSig]
		public static extern Bool ovrp_SetControllerVibration(uint controllerMask, float frequency, float amplitude);
	}

	private static class OVRP_0_1_3
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Posef ovrp_GetNodeVelocity(Node nodeId);

		[PreserveSig]
		[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
		public static extern Posef ovrp_GetNodeAcceleration(Node nodeId);
	}

	private static class OVRP_0_5_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_0_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern TrackingOrigin ovrp_GetTrackingOriginType();

		[PreserveSig]
		public static extern Bool ovrp_SetTrackingOriginType(TrackingOrigin originType);

		[PreserveSig]
		public static extern Posef ovrp_GetTrackingCalibratedOrigin();

		[PreserveSig]
		public static extern Bool ovrp_RecenterTrackingOrigin(uint flags);
	}

	private static class OVRP_1_1_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_GetInitialized();

		[PreserveSig]
		private static extern IntPtr _ovrp_GetVersion();

		public static string ovrp_GetVersion()
		{
			return null;
		}

		[PreserveSig]
		private static extern IntPtr _ovrp_GetNativeSDKVersion();

		public static string ovrp_GetNativeSDKVersion()
		{
			return null;
		}

		[PreserveSig]
		public static extern IntPtr ovrp_GetAudioOutId();

		[PreserveSig]
		public static extern IntPtr ovrp_GetAudioInId();

		[PreserveSig]
		public static extern float ovrp_GetEyeTextureScale();

		[PreserveSig]
		public static extern Bool ovrp_SetEyeTextureScale(float value);

		[PreserveSig]
		public static extern Bool ovrp_GetTrackingOrientationSupported();

		[PreserveSig]
		public static extern Bool ovrp_GetTrackingOrientationEnabled();

		[PreserveSig]
		public static extern Bool ovrp_SetTrackingOrientationEnabled(Bool value);

		[PreserveSig]
		public static extern Bool ovrp_GetTrackingPositionSupported();

		[PreserveSig]
		public static extern Bool ovrp_GetTrackingPositionEnabled();

		[PreserveSig]
		public static extern Bool ovrp_SetTrackingPositionEnabled(Bool value);

		[PreserveSig]
		public static extern Bool ovrp_GetNodePresent(Node nodeId);

		[PreserveSig]
		public static extern Bool ovrp_GetNodeOrientationTracked(Node nodeId);

		[PreserveSig]
		public static extern Bool ovrp_GetNodePositionTracked(Node nodeId);

		[PreserveSig]
		public static extern Frustumf ovrp_GetNodeFrustum(Node nodeId);

		[PreserveSig]
		public static extern ControllerState ovrp_GetControllerState(uint controllerMask);

		[PreserveSig]
		[Obsolete("Deprecated. Replaced by ovrp_GetSuggestedCpuPerformanceLevel", false)]
		public static extern int ovrp_GetSystemCpuLevel();

		[PreserveSig]
		[Obsolete("Deprecated. Replaced by ovrp_SetSuggestedCpuPerformanceLevel", false)]
		public static extern Bool ovrp_SetSystemCpuLevel(int value);

		[PreserveSig]
		[Obsolete("Deprecated. Replaced by ovrp_GetSuggestedGpuPerformanceLevel", false)]
		public static extern int ovrp_GetSystemGpuLevel();

		[PreserveSig]
		[Obsolete("Deprecated. Replaced by ovrp_SetSuggestedGpuPerformanceLevel", false)]
		public static extern Bool ovrp_SetSystemGpuLevel(int value);

		[PreserveSig]
		public static extern Bool ovrp_GetSystemPowerSavingMode();

		[PreserveSig]
		public static extern float ovrp_GetSystemDisplayFrequency();

		[PreserveSig]
		public static extern int ovrp_GetSystemVSyncCount();

		[PreserveSig]
		public static extern float ovrp_GetSystemVolume();

		[PreserveSig]
		public static extern BatteryStatus ovrp_GetSystemBatteryStatus();

		[PreserveSig]
		public static extern float ovrp_GetSystemBatteryLevel();

		[PreserveSig]
		public static extern float ovrp_GetSystemBatteryTemperature();

		[PreserveSig]
		private static extern IntPtr _ovrp_GetSystemProductName();

		public static string ovrp_GetSystemProductName()
		{
			return null;
		}

		[PreserveSig]
		public static extern Bool ovrp_ShowSystemUI(PlatformUI ui);

		[PreserveSig]
		public static extern Bool ovrp_GetAppMonoscopic();

		[PreserveSig]
		public static extern Bool ovrp_SetAppMonoscopic(Bool value);

		[PreserveSig]
		public static extern Bool ovrp_GetAppHasVrFocus();

		[PreserveSig]
		public static extern Bool ovrp_GetAppShouldQuit();

		[PreserveSig]
		public static extern Bool ovrp_GetAppShouldRecenter();

		[PreserveSig]
		private static extern IntPtr _ovrp_GetAppLatencyTimings();

		public static string ovrp_GetAppLatencyTimings()
		{
			return null;
		}

		[PreserveSig]
		public static extern Bool ovrp_GetUserPresent();

		[PreserveSig]
		public static extern float ovrp_GetUserIPD();

		[PreserveSig]
		public static extern Bool ovrp_SetUserIPD(float value);

		[PreserveSig]
		public static extern float ovrp_GetUserEyeDepth();

		[PreserveSig]
		public static extern Bool ovrp_SetUserEyeDepth(float value);

		[PreserveSig]
		public static extern float ovrp_GetUserEyeHeight();

		[PreserveSig]
		public static extern Bool ovrp_SetUserEyeHeight(float value);
	}

	private static class OVRP_1_2_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_SetSystemVSyncCount(int vsyncCount);

		[PreserveSig]
		public static extern Bool ovrpi_SetTrackingCalibratedOrigin();
	}

	private static class OVRP_1_3_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_GetEyeOcclusionMeshEnabled();

		[PreserveSig]
		public static extern Bool ovrp_SetEyeOcclusionMeshEnabled(Bool value);

		[PreserveSig]
		public static extern Bool ovrp_GetSystemHeadphonesPresent();
	}

	private static class OVRP_1_5_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern SystemRegion ovrp_GetSystemRegion();
	}

	private static class OVRP_1_6_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_GetTrackingIPDEnabled();

		[PreserveSig]
		public static extern Bool ovrp_SetTrackingIPDEnabled(Bool value);

		[PreserveSig]
		public static extern HapticsDesc ovrp_GetControllerHapticsDesc(uint controllerMask);

		[PreserveSig]
		public static extern HapticsState ovrp_GetControllerHapticsState(uint controllerMask);

		[PreserveSig]
		public static extern Bool ovrp_SetControllerHaptics(uint controllerMask, HapticsBuffer hapticsBuffer);

		[PreserveSig]
		public static extern Bool ovrp_SetOverlayQuad3(uint flags, IntPtr textureLeft, IntPtr textureRight, IntPtr device, Posef pose, Vector3f scale, int layerIndex);

		[PreserveSig]
		public static extern float ovrp_GetEyeRecommendedResolutionScale();

		[PreserveSig]
		public static extern float ovrp_GetAppCpuStartToGpuEndTime();

		[PreserveSig]
		public static extern int ovrp_GetSystemRecommendedMSAALevel();
	}

	private static class OVRP_1_7_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_GetAppChromaticCorrection();

		[PreserveSig]
		public static extern Bool ovrp_SetAppChromaticCorrection(Bool value);
	}

	private static class OVRP_1_8_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_GetBoundaryConfigured();

		[PreserveSig]
		[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
		public static extern BoundaryTestResult ovrp_TestBoundaryNode(Node nodeId, BoundaryType boundaryType);

		[PreserveSig]
		[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
		public static extern BoundaryTestResult ovrp_TestBoundaryPoint(Vector3f point, BoundaryType boundaryType);

		[PreserveSig]
		public static extern BoundaryGeometry ovrp_GetBoundaryGeometry(BoundaryType boundaryType);

		[PreserveSig]
		public static extern Vector3f ovrp_GetBoundaryDimensions(BoundaryType boundaryType);

		[PreserveSig]
		[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
		public static extern Bool ovrp_GetBoundaryVisible();

		[PreserveSig]
		[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
		public static extern Bool ovrp_SetBoundaryVisible(Bool value);

		[PreserveSig]
		public static extern Bool ovrp_Update2(int stateId, int frameIndex, double predictionSeconds);

		[PreserveSig]
		public static extern Posef ovrp_GetNodePose2(int stateId, Node nodeId);

		[PreserveSig]
		public static extern Posef ovrp_GetNodeVelocity2(int stateId, Node nodeId);

		[PreserveSig]
		[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
		public static extern Posef ovrp_GetNodeAcceleration2(int stateId, Node nodeId);
	}

	private static class OVRP_1_9_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern SystemHeadset ovrp_GetSystemHeadsetType();

		[PreserveSig]
		public static extern Controller ovrp_GetActiveController();

		[PreserveSig]
		public static extern Controller ovrp_GetConnectedControllers();

		[PreserveSig]
		public static extern Bool ovrp_GetBoundaryGeometry2(BoundaryType boundaryType, IntPtr points, ref int pointsCount);

		[PreserveSig]
		public static extern AppPerfStats ovrp_GetAppPerfStats();

		[PreserveSig]
		public static extern Bool ovrp_ResetAppPerfStats();
	}

	private static class OVRP_1_10_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_11_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Bool ovrp_SetDesiredEyeTextureFormat(EyeTextureFormat value);

		[PreserveSig]
		public static extern EyeTextureFormat ovrp_GetDesiredEyeTextureFormat();
	}

	private static class OVRP_1_12_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern float ovrp_GetAppFramerate();

		[PreserveSig]
		public static extern PoseStatef ovrp_GetNodePoseState(Step stepId, Node nodeId);

		[PreserveSig]
		public static extern ControllerState2 ovrp_GetControllerState2(uint controllerMask);
	}

	private static class OVRP_1_15_0
	{
		public static readonly Version version;

		public const int OVRP_EXTERNAL_CAMERA_NAME_SIZE = 32;

		[PreserveSig]
		public static extern Result ovrp_InitializeMixedReality();

		[PreserveSig]
		public static extern Result ovrp_ShutdownMixedReality();

		[PreserveSig]
		public static extern Bool ovrp_GetMixedRealityInitialized();

		[PreserveSig]
		public static extern Result ovrp_UpdateExternalCamera();

		[PreserveSig]
		public static extern Result ovrp_GetExternalCameraCount(out int cameraCount);

		[PreserveSig]
		public static extern Result ovrp_GetExternalCameraName(int cameraId, char[] cameraName);

		[PreserveSig]
		public static extern Result ovrp_GetExternalCameraIntrinsics(int cameraId, out CameraIntrinsics cameraIntrinsics);

		[PreserveSig]
		public static extern Result ovrp_GetExternalCameraExtrinsics(int cameraId, out CameraExtrinsics cameraExtrinsics);

		[PreserveSig]
		public static extern Result ovrp_CalculateLayerDesc(OverlayShape shape, LayerLayout layout, ref Sizei textureSize, int mipLevels, int sampleCount, EyeTextureFormat format, int layerFlags, ref LayerDesc layerDesc);

		[PreserveSig]
		public static extern Result ovrp_EnqueueSetupLayer(ref LayerDesc desc, IntPtr layerId);

		[PreserveSig]
		public static extern Result ovrp_EnqueueDestroyLayer(IntPtr layerId);

		[PreserveSig]
		public static extern Result ovrp_GetLayerTextureStageCount(int layerId, ref int layerTextureStageCount);

		[PreserveSig]
		public static extern Result ovrp_GetLayerTexturePtr(int layerId, int stage, Eye eyeId, ref IntPtr textureHandle);

		[PreserveSig]
		public static extern Result ovrp_EnqueueSubmitLayer(uint flags, IntPtr textureLeft, IntPtr textureRight, int layerId, int frameIndex, ref Posef pose, ref Vector3f scale, int layerIndex);

		[PreserveSig]
		public static extern Result ovrp_GetNodeFrustum2(Node nodeId, out Frustumf2 nodeFrustum);

		[PreserveSig]
		public static extern Bool ovrp_GetEyeTextureArrayEnabled();
	}

	private static class OVRP_1_16_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_UpdateCameraDevices();

		[PreserveSig]
		public static extern Bool ovrp_IsCameraDeviceAvailable(CameraDevice cameraDevice);

		[PreserveSig]
		public static extern Result ovrp_SetCameraDevicePreferredColorFrameSize(CameraDevice cameraDevice, Sizei preferredColorFrameSize);

		[PreserveSig]
		public static extern Result ovrp_OpenCameraDevice(CameraDevice cameraDevice);

		[PreserveSig]
		public static extern Result ovrp_CloseCameraDevice(CameraDevice cameraDevice);

		[PreserveSig]
		public static extern Bool ovrp_HasCameraDeviceOpened(CameraDevice cameraDevice);

		[PreserveSig]
		public static extern Bool ovrp_IsCameraDeviceColorFrameAvailable(CameraDevice cameraDevice);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceColorFrameSize(CameraDevice cameraDevice, out Sizei colorFrameSize);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceColorFrameBgraPixels(CameraDevice cameraDevice, out IntPtr colorFrameBgraPixels, out int colorFrameRowPitch);

		[PreserveSig]
		public static extern Result ovrp_GetControllerState4(uint controllerMask, ref ControllerState4 controllerState);
	}

	private static class OVRP_1_17_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetExternalCameraPose(CameraDevice camera, out Posef cameraPose);

		[PreserveSig]
		public static extern Result ovrp_ConvertPoseToCameraSpace(CameraDevice camera, ref Posef trackingSpacePose, out Posef cameraSpacePose);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceIntrinsicsParameters(CameraDevice camera, out Bool supportIntrinsics, out CameraDeviceIntrinsicsParameters intrinsicsParameters);

		[PreserveSig]
		public static extern Result ovrp_DoesCameraDeviceSupportDepth(CameraDevice camera, out Bool supportDepth);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceDepthSensingMode(CameraDevice camera, out CameraDeviceDepthSensingMode depthSensoringMode);

		[PreserveSig]
		public static extern Result ovrp_SetCameraDeviceDepthSensingMode(CameraDevice camera, CameraDeviceDepthSensingMode depthSensoringMode);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDevicePreferredDepthQuality(CameraDevice camera, out CameraDeviceDepthQuality depthQuality);

		[PreserveSig]
		public static extern Result ovrp_SetCameraDevicePreferredDepthQuality(CameraDevice camera, CameraDeviceDepthQuality depthQuality);

		[PreserveSig]
		public static extern Result ovrp_IsCameraDeviceDepthFrameAvailable(CameraDevice camera, out Bool available);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceDepthFrameSize(CameraDevice camera, out Sizei depthFrameSize);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceDepthFramePixels(CameraDevice cameraDevice, out IntPtr depthFramePixels, out int depthFrameRowPitch);

		[PreserveSig]
		public static extern Result ovrp_GetCameraDeviceDepthConfidencePixels(CameraDevice cameraDevice, out IntPtr depthConfidencePixels, out int depthConfidenceRowPitch);
	}

	private static class OVRP_1_18_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_SetHandNodePoseStateLatency(double latencyInSeconds);

		[PreserveSig]
		public static extern Result ovrp_GetHandNodePoseStateLatency(out double latencyInSeconds);

		[PreserveSig]
		public static extern Result ovrp_GetAppHasInputFocus(out Bool appHasInputFocus);
	}

	private static class OVRP_1_19_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_21_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetTiledMultiResSupported(out Bool foveationSupported);

		[PreserveSig]
		public static extern Result ovrp_GetTiledMultiResLevel(out FoveatedRenderingLevel level);

		[PreserveSig]
		public static extern Result ovrp_SetTiledMultiResLevel(FoveatedRenderingLevel level);

		[PreserveSig]
		public static extern Result ovrp_GetGPUUtilSupported(out Bool gpuUtilSupported);

		[PreserveSig]
		public static extern Result ovrp_GetGPUUtilLevel(out float gpuUtil);

		[PreserveSig]
		public static extern Result ovrp_GetSystemDisplayFrequency2(out float systemDisplayFrequency);

		[PreserveSig]
		public static extern Result ovrp_GetSystemDisplayAvailableFrequencies(IntPtr systemDisplayAvailableFrequencies, ref int numFrequencies);

		[PreserveSig]
		public static extern Result ovrp_SetSystemDisplayFrequency(float requestedFrequency);

		[PreserveSig]
		public static extern Result ovrp_GetAppAsymmetricFov(out Bool useAsymmetricFov);
	}

	private static class OVRP_1_28_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetDominantHand(out Handedness dominantHand);

		[PreserveSig]
		public static extern Result ovrp_SendEvent(string name, string param);

		[PreserveSig]
		public static extern Result ovrp_EnqueueSetupLayer2(ref LayerDesc desc, int compositionDepth, IntPtr layerId);
	}

	private static class OVRP_1_29_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetLayerAndroidSurfaceObject(int layerId, ref IntPtr surfaceObject);

		[PreserveSig]
		public static extern Result ovrp_SetHeadPoseModifier(ref Quatf relativeRotation, ref Vector3f relativeTranslation);

		[PreserveSig]
		public static extern Result ovrp_GetHeadPoseModifier(out Quatf relativeRotation, out Vector3f relativeTranslation);

		[PreserveSig]
		public static extern Result ovrp_GetNodePoseStateRaw(Step stepId, int frameIndex, Node nodeId, out PoseStatef nodePoseState);
	}

	private static class OVRP_1_30_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetCurrentTrackingTransformPose(out Posef trackingTransformPose);

		[PreserveSig]
		public static extern Result ovrp_GetTrackingTransformRawPose(out Posef trackingTransformRawPose);

		[PreserveSig]
		public static extern Result ovrp_SendEvent2(string name, string param, string source);

		[PreserveSig]
		public static extern Result ovrp_IsPerfMetricsSupported(PerfMetrics perfMetrics, out Bool isSupported);

		[PreserveSig]
		public static extern Result ovrp_GetPerfMetricsFloat(PerfMetrics perfMetrics, out float value);

		[PreserveSig]
		public static extern Result ovrp_GetPerfMetricsInt(PerfMetrics perfMetrics, out int value);
	}

	private static class OVRP_1_31_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetTimeInSeconds(out double value);

		[PreserveSig]
		public static extern Result ovrp_SetColorScaleAndOffset(Vector4 colorScale, Vector4 colorOffset, Bool applyToAllLayers);
	}

	private static class OVRP_1_32_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_AddCustomMetadata(string name, string param);
	}

	private static class OVRP_1_34_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_EnqueueSubmitLayer2(uint flags, IntPtr textureLeft, IntPtr textureRight, int layerId, int frameIndex, ref Posef pose, ref Vector3f scale, int layerIndex, Bool overrideTextureRectMatrix, ref TextureRectMatrixf textureRectMatrix, Bool overridePerLayerColorScaleAndOffset, ref Vector4 colorScale, ref Vector4 colorOffset);
	}

	private static class OVRP_1_35_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_36_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_37_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_38_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetTrackingTransformRelativePose(ref Posef trackingTransformRelativePose, TrackingOrigin trackingOrigin);

		[PreserveSig]
		public static extern Result ovrp_Media_Initialize();

		[PreserveSig]
		public static extern Result ovrp_Media_Shutdown();

		[PreserveSig]
		public static extern Result ovrp_Media_GetInitialized(out Bool initialized);

		[PreserveSig]
		public static extern Result ovrp_Media_Update();

		[PreserveSig]
		public static extern Result ovrp_Media_GetMrcActivationMode(out Media.MrcActivationMode activationMode);

		[PreserveSig]
		public static extern Result ovrp_Media_SetMrcActivationMode(Media.MrcActivationMode activationMode);

		[PreserveSig]
		public static extern Result ovrp_Media_IsMrcEnabled(out Bool mrcEnabled);

		[PreserveSig]
		public static extern Result ovrp_Media_IsMrcActivated(out Bool mrcActivated);

		[PreserveSig]
		public static extern Result ovrp_Media_UseMrcDebugCamera(out Bool useMrcDebugCamera);

		[PreserveSig]
		public static extern Result ovrp_Media_SetMrcInputVideoBufferType(Media.InputVideoBufferType inputVideoBufferType);

		[PreserveSig]
		public static extern Result ovrp_Media_GetMrcInputVideoBufferType(ref Media.InputVideoBufferType inputVideoBufferType);

		[PreserveSig]
		public static extern Result ovrp_Media_SetMrcFrameSize(int frameWidth, int frameHeight);

		[PreserveSig]
		public static extern Result ovrp_Media_GetMrcFrameSize(ref int frameWidth, ref int frameHeight);

		[PreserveSig]
		public static extern Result ovrp_Media_SetMrcAudioSampleRate(int sampleRate);

		[PreserveSig]
		public static extern Result ovrp_Media_GetMrcAudioSampleRate(ref int sampleRate);

		[PreserveSig]
		public static extern Result ovrp_Media_SetMrcFrameImageFlipped(Bool flipped);

		[PreserveSig]
		public static extern Result ovrp_Media_GetMrcFrameImageFlipped(ref Bool flipped);

		[PreserveSig]
		public static extern Result ovrp_Media_EncodeMrcFrame(IntPtr rawBuffer, IntPtr audioDataPtr, int audioDataLen, int audioChannels, double timestamp, ref int outSyncId);

		[PreserveSig]
		public static extern Result ovrp_Media_EncodeMrcFrameWithDualTextures(IntPtr backgroundTextureHandle, IntPtr foregroundTextureHandle, IntPtr audioData, int audioDataLen, int audioChannels, double timestamp, ref int outSyncId);

		[PreserveSig]
		public static extern Result ovrp_Media_SyncMrcFrame(int syncId);

		[PreserveSig]
		public static extern Result ovrp_SetDeveloperMode(Bool active);

		[PreserveSig]
		public static extern Result ovrp_GetNodeOrientationValid(Node nodeId, ref Bool nodeOrientationValid);

		[PreserveSig]
		public static extern Result ovrp_GetNodePositionValid(Node nodeId, ref Bool nodePositionValid);
	}

	private static class OVRP_1_39_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_40_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_41_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_42_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetAdaptiveGpuPerformanceScale2(ref float adaptiveGpuPerformanceScale);
	}

	private static class OVRP_1_43_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_44_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetHandTrackingEnabled(ref Bool handTrackingEnabled);

		[PreserveSig]
		public static extern Result ovrp_GetHandState(Step stepId, Hand hand, out HandStateInternal handState);

		[PreserveSig]
		public static extern Result ovrp_GetSkeleton(SkeletonType skeletonType, out Skeleton skeleton);

		[PreserveSig]
		public static extern Result ovrp_GetMesh(MeshType meshType, IntPtr meshPtr);

		[PreserveSig]
		public static extern Result ovrp_OverrideExternalCameraFov(int cameraId, Bool useOverriddenFov, ref Fovf fov);

		[PreserveSig]
		public static extern Result ovrp_GetUseOverriddenExternalCameraFov(int cameraId, out Bool useOverriddenFov);

		[PreserveSig]
		public static extern Result ovrp_OverrideExternalCameraStaticPose(int cameraId, Bool useOverriddenPose, ref Posef poseInStageOrigin);

		[PreserveSig]
		public static extern Result ovrp_GetUseOverriddenExternalCameraStaticPose(int cameraId, out Bool useOverriddenStaticPose);

		[PreserveSig]
		public static extern Result ovrp_ResetDefaultExternalCamera();

		[PreserveSig]
		public static extern Result ovrp_SetDefaultExternalCamera(string cameraName, ref CameraIntrinsics cameraIntrinsics, ref CameraExtrinsics cameraExtrinsics);

		[PreserveSig]
		public static extern Result ovrp_GetLocalTrackingSpaceRecenterCount(ref int recenterCount);
	}

	private static class OVRP_1_45_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetSystemHmd3DofModeEnabled(ref Bool enabled);

		[PreserveSig]
		public static extern Result ovrp_Media_SetAvailableQueueIndexVulkan(uint queueIndexVk);
	}

	private static class OVRP_1_46_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetTiledMultiResDynamic(out Bool isDynamic);

		[PreserveSig]
		public static extern Result ovrp_SetTiledMultiResDynamic(Bool isDynamic);
	}

	private static class OVRP_1_47_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_48_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_SetExternalCameraProperties(string cameraName, ref CameraIntrinsics cameraIntrinsics, ref CameraExtrinsics cameraExtrinsics);
	}

	private static class OVRP_1_49_0
	{
		public static readonly Version version;

		public const int OVRP_ANCHOR_NAME_SIZE = 32;

		[PreserveSig]
		public static extern Result ovrp_SetClientColorDesc(ColorSpace colorSpace);

		[PreserveSig]
		public static extern Result ovrp_GetHmdColorDesc(ref ColorSpace colorSpace);

		[PreserveSig]
		public static extern Result ovrp_Media_EncodeMrcFrameWithPoseTime(IntPtr rawBuffer, IntPtr audioDataPtr, int audioDataLen, int audioChannels, double timestamp, double poseTime, ref int outSyncId);

		[PreserveSig]
		public static extern Result ovrp_Media_EncodeMrcFrameDualTexturesWithPoseTime(IntPtr backgroundTextureHandle, IntPtr foregroundTextureHandle, IntPtr audioData, int audioDataLen, int audioChannels, double timestamp, double poseTime, ref int outSyncId);

		[PreserveSig]
		public static extern Result ovrp_Media_SetHeadsetControllerPose(Posef headsetPose, Posef leftControllerPose, Posef rightControllerPose);

		[PreserveSig]
		public static extern Result ovrp_Media_EnumerateCameraAnchorHandles(ref int anchorCount, ref IntPtr CameraAnchorHandle);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCurrentCameraAnchorHandle(ref IntPtr anchorHandle);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCameraAnchorName(IntPtr anchorHandle, char[] cameraName);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCameraAnchorHandle(IntPtr anchorName, ref IntPtr anchorHandle);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCameraAnchorType(IntPtr anchorHandle, ref CameraAnchorType anchorType);

		[PreserveSig]
		public static extern Result ovrp_Media_CreateCustomCameraAnchor(IntPtr anchorName, ref IntPtr anchorHandle);

		[PreserveSig]
		public static extern Result ovrp_Media_DestroyCustomCameraAnchor(IntPtr anchorHandle);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCustomCameraAnchorPose(IntPtr anchorHandle, ref Posef pose);

		[PreserveSig]
		public static extern Result ovrp_Media_SetCustomCameraAnchorPose(IntPtr anchorHandle, Posef pose);

		[PreserveSig]
		public static extern Result ovrp_Media_GetCameraMinMaxDistance(IntPtr anchorHandle, ref double minDistance, ref double maxDistance);

		[PreserveSig]
		public static extern Result ovrp_Media_SetCameraMinMaxDistance(IntPtr anchorHandle, double minDistance, double maxDistance);
	}

	private static class OVRP_1_50_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_51_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_52_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_53_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_54_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_Media_SetPlatformInitialized();
	}

	private static class OVRP_1_55_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetSkeleton2(SkeletonType skeletonType, out Skeleton2Internal skeleton);

		[PreserveSig]
		public static extern Result ovrp_PollEvent(ref EventDataBuffer eventDataBuffer);

		[PreserveSig]
		public static extern Result ovrp_GetNativeXrApiType(out XrApi xrApi);

		[PreserveSig]
		public static extern Result ovrp_GetNativeOpenXRHandles(out ulong xrInstance, out ulong xrSession);
	}

	private static class OVRP_1_55_1
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_PollEvent2(ref EventType eventType, ref IntPtr eventData);
	}

	private static class OVRP_1_56_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_57_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_Media_GetPlatformCameraMode(out Media.PlatformCameraMode platformCameraMode);

		[PreserveSig]
		public static extern Result ovrp_Media_SetPlatformCameraMode(Media.PlatformCameraMode platformCameraMode);

		[PreserveSig]
		public static extern Result ovrp_SetEyeFovPremultipliedAlphaMode(Bool enabled);

		[PreserveSig]
		public static extern Result ovrp_GetEyeFovPremultipliedAlphaMode(ref Bool enabled);

		[PreserveSig]
		public static extern Result ovrp_SetKeyboardOverlayUV(Vector2f uv);
	}

	private static class OVRP_1_58_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_59_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_60_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_61_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_62_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_63_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_InitializeInsightPassthrough();

		[PreserveSig]
		public static extern Result ovrp_ShutdownInsightPassthrough();

		[PreserveSig]
		public static extern Bool ovrp_GetInsightPassthroughInitialized();

		[PreserveSig]
		public static extern Result ovrp_SetInsightPassthroughStyle(int layerId, InsightPassthroughStyle style);

		[PreserveSig]
		public static extern Result ovrp_CreateInsightTriangleMesh(int layerId, IntPtr vertices, int vertexCount, IntPtr triangles, int triangleCount, out ulong meshHandle);

		[PreserveSig]
		public static extern Result ovrp_DestroyInsightTriangleMesh(ulong meshHandle);

		[PreserveSig]
		public static extern Result ovrp_AddInsightPassthroughSurfaceGeometry(int layerId, ulong meshHandle, Matrix4x4 T_world_model, out ulong geometryInstanceHandle);

		[PreserveSig]
		public static extern Result ovrp_DestroyInsightPassthroughGeometryInstance(ulong geometryInstanceHandle);

		[PreserveSig]
		public static extern Result ovrp_UpdateInsightPassthroughGeometryTransform(ulong geometryInstanceHandle, Matrix4x4 T_world_model);
	}

	private static class OVRP_1_64_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_LocateSpace(ref Posef location, ref ulong space, TrackingOrigin trackingOrigin);
	}

	private static class OVRP_1_65_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_KtxLoadFromMemory(ref IntPtr data, uint length, ref IntPtr texture);

		[PreserveSig]
		public static extern Result ovrp_KtxTextureWidth(IntPtr texture, ref uint width);

		[PreserveSig]
		public static extern Result ovrp_KtxTextureHeight(IntPtr texture, ref uint height);

		[PreserveSig]
		public static extern Result ovrp_KtxTranscode(IntPtr texture, uint format);

		[PreserveSig]
		public static extern Result ovrp_KtxGetTextureData(IntPtr texture, IntPtr data, uint bufferSize);

		[PreserveSig]
		public static extern Result ovrp_KtxTextureSize(IntPtr texture, ref uint size);

		[PreserveSig]
		public static extern Result ovrp_KtxDestroy(IntPtr texture);

		[PreserveSig]
		public static extern Result ovrp_DestroySpace(ref ulong space);
	}

	private static class OVRP_1_66_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetInsightPassthroughInitializationState();

		[PreserveSig]
		public static extern Result ovrp_Media_IsCastingToRemoteClient(out Bool isCasting);
	}

	private static class OVRP_1_67_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_68_0
	{
		public static readonly Version version;

		public const int OVRP_RENDER_MODEL_MAX_PATH_LENGTH = 256;

		public const int OVRP_RENDER_MODEL_MAX_NAME_LENGTH = 64;

		[PreserveSig]
		public static extern Result ovrp_LoadRenderModel(ulong modelKey, uint bufferInputCapacity, ref uint bufferCountOutput, IntPtr buffer);

		[PreserveSig]
		public static extern Result ovrp_GetRenderModelPaths(uint index, IntPtr path);

		[PreserveSig]
		public static extern Result ovrp_GetRenderModelProperties(string path, out RenderModelPropertiesInternal properties);

		[PreserveSig]
		public static extern Result ovrp_SetInsightPassthroughKeyboardHandsIntensity(int layerId, InsightPassthroughKeyboardHandsIntensity intensity);

		[PreserveSig]
		public static extern Result ovrp_StartKeyboardTracking(ulong trackedKeyboardId);

		[PreserveSig]
		public static extern Result ovrp_StopKeyboardTracking();

		[PreserveSig]
		public static extern Result ovrp_GetSystemKeyboardDescription(TrackedKeyboardQueryFlags keyboardQueryFlags, out KeyboardDescription keyboardDescription);

		[PreserveSig]
		public static extern Result ovrp_GetKeyboardState(Step stepId, int frameIndex, out KeyboardState keyboardState);
	}

	private static class OVRP_1_69_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetNodePoseStateImmediate(Node nodeId, out PoseStatef nodePoseState);
	}

	private static class OVRP_1_70_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_SetLogCallback2(LogCallback2DelegateType logCallback);
	}

	private static class OVRP_1_71_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_IsInsightPassthroughSupported(ref Bool supported);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_SetClientVersion(int majorVersion, int minorVersion, int patchVersion);

		[PreserveSig]
		public static extern IntPtr ovrp_UnityOpenXR_HookGetInstanceProcAddr(IntPtr func);

		[PreserveSig]
		public static extern Result ovrp_UnityOpenXR_OnInstanceCreate(ulong xrInstance);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnInstanceDestroy(ulong xrInstance);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionCreate(ulong xrSession);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnAppSpaceChange(ulong xrSpace);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionStateChange(int oldState, int newState);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionBegin(ulong xrSession);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionEnd(ulong xrSession);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionExiting(ulong xrSession);

		[PreserveSig]
		public static extern void ovrp_UnityOpenXR_OnSessionDestroy(ulong xrSession);

		[PreserveSig]
		public static extern Result ovrp_SetSuggestedCpuPerformanceLevel(ProcessorPerformanceLevel perfLevel);

		[PreserveSig]
		public static extern Result ovrp_GetSuggestedCpuPerformanceLevel(out ProcessorPerformanceLevel perfLevel);

		[PreserveSig]
		public static extern Result ovrp_SetSuggestedGpuPerformanceLevel(ProcessorPerformanceLevel perfLevel);

		[PreserveSig]
		public static extern Result ovrp_GetSuggestedGpuPerformanceLevel(out ProcessorPerformanceLevel perfLevel);
	}

	private static class OVRP_1_72_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_CreateSpatialAnchor(ref SpatialAnchorCreateInfo createInfo, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_SetSpaceComponentStatus(ref ulong space, SpaceComponentType componentType, Bool enable, double timeout, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceComponentStatus(ref ulong space, SpaceComponentType componentType, out Bool enabled, out Bool changePending);

		[PreserveSig]
		public static extern Result ovrp_EnumerateSpaceSupportedComponents(ref ulong space, uint componentTypesCapacityInput, out uint componentTypesCountOutput, [In][Out] SpaceComponentType[] componentTypes);

		[PreserveSig]
		public static extern Result ovrp_SaveSpace(ref ulong space, SpaceStorageLocation location, SpaceStoragePersistenceMode mode, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_QuerySpaces(ref SpaceQueryInfo queryInfo, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_RetrieveSpaceQueryResults(ref ulong requestId, uint resultCapacityInput, ref uint resultCountOutput, IntPtr results);

		[PreserveSig]
		public static extern Result ovrp_EraseSpace(ref ulong space, SpaceStorageLocation location, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceContainer(ref ulong space, ref SpaceContainerInternal containerInternal);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceBoundingBox2D(ref ulong space, out Rectf rect);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceBoundingBox3D(ref ulong space, out Boundsf bounds);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceSemanticLabels(ref ulong space, ref SpaceSemanticLabelInternal labelsInternal);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceRoomLayout(ref ulong space, ref RoomLayoutInternal roomLayoutInternal);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceBoundary2D(ref ulong space, ref PolygonalBoundary2DInternal boundaryInternal);

		[PreserveSig]
		public static extern Result ovrp_RequestSceneCapture(ref SceneCaptureRequestInternal request, out ulong requestId);
	}

	private static class OVRP_1_73_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_74_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetSpaceUuid(in ulong space, out Guid uuid);

		[PreserveSig]
		public static extern Result ovrp_CreateVirtualKeyboard(VirtualKeyboardCreateInfo createInfo);

		[PreserveSig]
		public static extern Result ovrp_DestroyVirtualKeyboard();

		[PreserveSig]
		public static extern Result ovrp_SendVirtualKeyboardInput(VirtualKeyboardInputInfo inputInfo, ref Posef interactorRootPose);

		[PreserveSig]
		public static extern Result ovrp_ChangeVirtualKeyboardTextContext(string textContext);

		[PreserveSig]
		public static extern Result ovrp_CreateVirtualKeyboardSpace(VirtualKeyboardSpaceCreateInfo createInfo, out ulong keyboardSpace);

		[PreserveSig]
		public static extern Result ovrp_SuggestVirtualKeyboardLocation(VirtualKeyboardLocationInfo locationInfo);

		[PreserveSig]
		public static extern Result ovrp_GetVirtualKeyboardScale(out float location);

		[PreserveSig]
		public static extern Result ovrp_GetRenderModelProperties2(string path, RenderModelFlags flags, out RenderModelPropertiesInternal properties);
	}

	private static class OVRP_1_75_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_76_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetNodePoseStateAtTime(double time, Node nodeId, out PoseStatef nodePoseState);
	}

	private static class OVRP_1_78_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetPassthroughCapabilityFlags(ref PassthroughCapabilityFlags capabilityFlags);

		[PreserveSig]
		public static extern Result ovrp_GetFoveationEyeTrackedSupported(out Bool foveationSupported);

		[PreserveSig]
		public static extern Result ovrp_GetFoveationEyeTracked(out Bool isEyeTrackedFoveation);

		[PreserveSig]
		public static extern Result ovrp_SetFoveationEyeTracked(Bool isEyeTrackedFoveation);

		[PreserveSig]
		public static extern Result ovrp_StartFaceTracking();

		[PreserveSig]
		public static extern Result ovrp_StopFaceTracking();

		[PreserveSig]
		public static extern Result ovrp_StartBodyTracking();

		[PreserveSig]
		public static extern Result ovrp_StopBodyTracking();

		[PreserveSig]
		public static extern Result ovrp_StartEyeTracking();

		[PreserveSig]
		public static extern Result ovrp_StopEyeTracking();

		[PreserveSig]
		public static extern Result ovrp_GetEyeTrackingSupported(out Bool eyeTrackingSupported);

		[PreserveSig]
		public static extern Result ovrp_GetFaceTrackingSupported(out Bool faceTrackingSupported);

		[PreserveSig]
		public static extern Result ovrp_GetBodyTrackingEnabled(out Bool value);

		[PreserveSig]
		public static extern Result ovrp_GetBodyTrackingSupported(out Bool value);

		[PreserveSig]
		public static extern Result ovrp_GetBodyState(Step stepId, int frameIndex, out BodyStateInternal bodyState);

		[PreserveSig]
		public static extern Result ovrp_GetFaceTrackingEnabled(out Bool faceTrackingEnabled);

		[PreserveSig]
		public static extern Result ovrp_GetFaceState(Step stepId, int frameIndex, out FaceStateInternal faceState);

		[PreserveSig]
		public static extern Result ovrp_GetEyeTrackingEnabled(out Bool eyeTrackingEnabled);

		[PreserveSig]
		public static extern Result ovrp_GetEyeGazesState(Step stepId, int frameIndex, out EyeGazesStateInternal eyeGazesState);

		[PreserveSig]
		public static extern Result ovrp_GetControllerState5(uint controllerMask, ref ControllerState5 controllerState);

		[PreserveSig]
		public static extern Result ovrp_SetControllerLocalizedVibration(Controller controllerMask, HapticsLocation hapticsLocationMask, float frequency, float amplitude);

		[PreserveSig]
		public static extern Result ovrp_GetLocalDimmingSupported(out Bool localDimmingSupported);

		[PreserveSig]
		public static extern Result ovrp_SetLocalDimming(Bool localDimmingMode);

		[PreserveSig]
		public static extern Result ovrp_GetLocalDimming(out Bool localDimmingMode);

		[PreserveSig]
		public static extern Result ovrp_GetCurrentInteractionProfile(Hand hand, out InteractionProfile interactionProfile);

		[PreserveSig]
		public static extern Result ovrp_SetControllerHapticsAmplitudeEnvelope(Controller controllerMask, HapticsAmplitudeEnvelopeVibration hapticsVibration);

		[PreserveSig]
		public static extern Result ovrp_SetControllerHapticsPcm(Controller controllerMask, HapticsPcmVibration hapticsVibration);

		[PreserveSig]
		public static extern Result ovrp_GetControllerSampleRateHz(Controller controller, out float sampleRateHz);
	}

	private static class OVRP_1_79_0
	{
		public static readonly Version version;

		[PreserveSig]
		public unsafe static extern Result ovrp_ShareSpaces(ulong* spaces, uint numSpaces, ulong* userHandles, uint numUsers, out ulong requestId);

		[PreserveSig]
		public unsafe static extern Result ovrp_SaveSpaceList(ulong* spaces, uint numSpaces, SpaceStorageLocation location, out ulong requestId);

		[PreserveSig]
		public static extern Result ovrp_GetSpaceUserId(in ulong spaceUserHandle, out ulong spaceUserId);

		[PreserveSig]
		public static extern Result ovrp_CreateSpaceUser(in ulong spaceUserId, out ulong spaceUserHandle);

		[PreserveSig]
		public static extern Result ovrp_DestroySpaceUser(in ulong userHandle);

		[PreserveSig]
		public static extern Result ovrp_LocateSpace2(out SpaceLocationf location, in ulong space, TrackingOrigin trackingOrigin);

		[PreserveSig]
		public static extern Result ovrp_DeclareUser(in ulong userId, out ulong userHandle);

		[PreserveSig]
		public static extern Result ovrp_QplMarkerStart(int markerId, int instanceKey, long timestampMs);

		[PreserveSig]
		public static extern Result ovrp_QplMarkerEnd(int markerId, Qpl.ResultType resultTypeId, int instanceKey, long timestampMs);

		[PreserveSig]
		public static extern Result ovrp_QplMarkerPointCached(int markerId, int nameHandle, int instanceKey, long timestampMs);

		[PreserveSig]
		public static extern Result ovrp_QplMarkerAnnotation(int markerId, string annotationKey, string annotationValue, int instanceKey);

		[PreserveSig]
		public static extern Result ovrp_QplCreateMarkerHandle(string name, out int nameHandle);

		[PreserveSig]
		public static extern Result ovrp_QplDestroyMarkerHandle(int nameHandle);
	}

	private static class OVRP_1_81_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_82_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetSpaceTriangleMesh(ref ulong space, ref TriangleMeshInternal triangleMeshInternal);
	}

	private static class OVRP_1_83_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetControllerState6(uint controllerMask, ref ControllerState6 controllerState);

		[PreserveSig]
		public static extern Result ovrp_GetVirtualKeyboardModelAnimationStates(ref VirtualKeyboardModelAnimationStatesInternal animationStates);

		[PreserveSig]
		public static extern Result ovrp_GetVirtualKeyboardDirtyTextures(ref VirtualKeyboardTextureIdsInternal textureIds);

		[PreserveSig]
		public static extern Result ovrp_GetVirtualKeyboardTextureData(ulong textureId, ref VirtualKeyboardTextureData textureData);

		[PreserveSig]
		public static extern Result ovrp_SetVirtualKeyboardModelVisibility(ref VirtualKeyboardModelVisibility visibility);
	}

	private static class OVRP_1_84_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_CreatePassthroughColorLut(PassthroughColorLutChannels channels, uint resolution, PassthroughColorLutData data, out ulong colorLut);

		[PreserveSig]
		public static extern Result ovrp_DestroyPassthroughColorLut(ulong colorLut);

		[PreserveSig]
		public static extern Result ovrp_UpdatePassthroughColorLut(ulong colorLut, PassthroughColorLutData data);

		[PreserveSig]
		public static extern Result ovrp_SetInsightPassthroughStyle2(int layerId, in InsightPassthroughStyle2 style);

		[PreserveSig]
		public static extern Result ovrp_GetLayerRecommendedResolution(int layerId, out Sizei recommendedDimensions);

		[PreserveSig]
		public static extern Result ovrp_GetEyeLayerRecommendedResolution(out Sizei recommendedDimensions);
	}

	private static class OVRP_1_85_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_OnEditorShutdown();

		[PreserveSig]
		public static extern Result ovrp_GetPassthroughCapabilities(ref PassthroughCapabilities capabilityFlags);
	}

	private static class OVRP_1_86_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_SetControllerDrivenHandPoses(Bool controllerDrivenHandPoses);

		[PreserveSig]
		public static extern Result ovrp_IsControllerDrivenHandPosesEnabled(ref Bool enabled);

		[PreserveSig]
		public static extern Result ovrp_AreHandPosesGeneratedByControllerData(Step stepId, Node nodeId, ref Bool isGeneratedByControllerData);

		[PreserveSig]
		public static extern Result ovrp_SetMultimodalHandsControllersSupported(Bool supported);

		[PreserveSig]
		public static extern Result ovrp_IsMultimodalHandsControllersSupported(ref Bool supported);

		[PreserveSig]
		public static extern Result ovrp_GetCurrentDetachedInteractionProfile(Hand hand, out InteractionProfile interactionProfile);

		[PreserveSig]
		public static extern Result ovrp_GetControllerIsInHand(Step stepId, Node nodeId, ref Bool isInHand);
	}

	private static class OVRP_1_87_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetPassthroughPreferences(out PassthroughPreferences preferences);

		[PreserveSig]
		public static extern Result ovrp_SetEyeBufferSharpenType(LayerSharpenType sharpenType);

		[PreserveSig]
		public static extern Result ovrp_SetControllerDrivenHandPosesAreNatural(Bool controllerDrivenHandPosesAreNatural);

		[PreserveSig]
		public static extern Result ovrp_AreControllerDrivenHandPosesNatural(ref Bool natural);
	}

	private static class OVRP_1_88_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_SetSimultaneousHandsAndControllersEnabled(Bool enabled);
	}

	private static class OVRP_1_89_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_90_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_91_0
	{
		public static readonly Version version;
	}

	private static class OVRP_1_92_0
	{
		public static readonly Version version;

		[PreserveSig]
		public static extern Result ovrp_GetFaceState2(Step stepId, int frameIndex, out FaceState2Internal faceState);

		[PreserveSig]
		public static extern Result ovrp_StartFaceTracking2(FaceTrackingDataSource[] requestedDataSources, uint requestedDataSourcesCount);

		[PreserveSig]
		public static extern Result ovrp_StopFaceTracking2();

		[PreserveSig]
		public static extern Result ovrp_GetFaceTracking2Enabled(out Bool faceTracking2Enabled);

		[PreserveSig]
		public static extern Result ovrp_GetFaceTracking2Supported(out Bool faceTracking2Enabled);

		[PreserveSig]
		public static extern Result ovrp_RequestBodyTrackingFidelity(BodyTrackingFidelity2 fidelity);

		[PreserveSig]
		public static extern Result ovrp_SuggestBodyTrackingCalibrationOverride(BodyTrackingCalibrationInfo calibrationInfo);

		[PreserveSig]
		public static extern Result ovrp_ResetBodyTrackingCalibration();

		[PreserveSig]
		public static extern Result ovrp_GetBodyState4(Step stepId, int frameIndex, out BodyState4Internal bodyState);

		[PreserveSig]
		public static extern Result ovrp_GetSkeleton3(SkeletonType skeletonType, out Skeleton3Internal skeleton);

		[PreserveSig]
		public static extern Result ovrp_StartBodyTracking2(BodyJointSet jointSet);

		[PreserveSig]
		public static extern Result ovrp_QplSetConsent(Bool consent);
	}

	public const bool isSupportedPlatform = true;

	public static readonly Version wrapperVersion;

	private static Version _version;

	private static Version _nativeSDKVersion;

	public static int MAX_CPU_CORES;

	private const int OverlayShapeFlagShift = 4;

	public const int AppPerfFrameStatsMaxCount = 5;

	private const int EventDataBufferSize = 4000;

	public const int RENDER_MODEL_NULL_KEY = 0;

	public const int SpaceFilterInfoIdsMaxSize = 1024;

	public const int SpaceFilterInfoComponentsMaxSize = 16;

	public const int SpatialEntityMaxQueryResultsPerEvent = 128;

	private static XrApi? _nativeXrApi;

	private static GUID _nativeAudioOutGuid;

	private static Guid _cachedAudioOutGuid;

	private static string _cachedAudioOutString;

	private static GUID _nativeAudioInGuid;

	private static Guid _cachedAudioInGuid;

	private static string _cachedAudioInString;

	private static bool perfStatWarningPrinted;

	private static bool resetPerfStatWarningPrinted;

	private static Texture2D cachedCameraFrameTexture;

	private static Texture2D cachedCameraDepthTexture;

	private static Texture2D cachedCameraDepthConfidenceTexture;

	private static OVRNativeBuffer _nativeSystemDisplayFrequenciesAvailable;

	private static float[] _cachedSystemDisplayFrequenciesAvailable;

	private static HandStateInternal cachedHandState;

	private static Skeleton cachedSkeleton;

	private static Skeleton2Internal cachedSkeleton2;

	private static GetBoneSkeleton2Delegate[] Skeleton2GetBone;

	private static Skeleton3Internal cachedSkeleton3;

	private static GetBoneSkeleton3Delegate[] Skeleton3GetBone;

	private static FaceStateInternal cachedFaceState;

	private static FaceState2Internal cachedFaceState2;

	private static EyeGazesStateInternal cachedEyeGazesState;

	private static BodyJointSet _currentJointSet;

	private const string pluginName = "OVRPlugin";

	private static Version _versionZero;

	public static Version version => null;

	public static Version nativeSDKVersion => null;

	public static bool initialized => false;

	public static XrApi nativeXrApi => default(XrApi);

	public static bool chromatic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool monoscopic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool rotation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool position
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool useIPDInPositionTracking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool positionSupported => false;

	public static bool positionTracked => false;

	public static bool powerSaving => false;

	public static bool hmdPresent => false;

	public static bool userPresent => false;

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static bool headphonesPresent => false;

	public static int recommendedMSAALevel => 0;

	public static SystemRegion systemRegion => default(SystemRegion);

	public static string audioOutId => null;

	public static string audioInId => null;

	public static bool hasVrFocus => false;

	public static bool hasInputFocus => false;

	public static bool shouldQuit => false;

	public static bool shouldRecenter => false;

	public static string productName => null;

	public static string latency => null;

	public static float eyeDepth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float eyeHeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. Please use SystemInfo.batteryLevel", false)]
	public static float batteryLevel => 0f;

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static float batteryTemperature => 0f;

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

	[Obsolete("Deprecated. Please use suggestedCpuPerfLevel.", false)]
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

	[Obsolete("Deprecated. Please use suggestedGpuPerfLevel.", false)]
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

	public static int vsyncCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static float systemVolume => 0f;

	public static float ipd
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool occlusionMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated. Please use SystemInfo.batteryStatus", false)]
	public static BatteryStatus batteryStatus => default(BatteryStatus);

	private static bool foveatedRenderingSupported => false;

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

	public static bool fixedFoveatedRenderingSupported => false;

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

	public static float[] systemDisplayFrequenciesAvailable => null;

	public static float systemDisplayFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

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

	public static bool AsymmetricFovEnabled => false;

	public static bool EyeTextureArrayEnabled => false;

	public static bool localDimmingSupported => false;

	public static bool localDimming
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool bodyTrackingSupported => false;

	public static bool bodyTrackingEnabled => false;

	public static bool faceTrackingEnabled => false;

	public static bool faceTrackingSupported => false;

	public static bool eyeTrackingEnabled => false;

	public static bool eyeTrackingSupported => false;

	public static bool faceTracking2Enabled => false;

	public static bool faceTracking2Supported => false;

	public static bool IsSuccess(this Result result)
	{
		return false;
	}

	public static void SetLogCallback2(LogCallback2DelegateType logCallback)
	{
	}

	public static bool IsPassthroughShape(OverlayShape shape)
	{
		return false;
	}

	public static bool IsPositionValid(this SpaceLocationFlags value)
	{
		return false;
	}

	public static bool IsOrientationValid(this SpaceLocationFlags value)
	{
		return false;
	}

	public static bool IsPositionTracked(this SpaceLocationFlags value)
	{
		return false;
	}

	public static bool IsOrientationTracked(this SpaceLocationFlags value)
	{
		return false;
	}

	public static string GuidToUuidString(Guid guid)
	{
		return null;
	}

	public static Frustumf GetEyeFrustum(Eye eyeId)
	{
		return default(Frustumf);
	}

	public static Sizei GetEyeTextureSize(Eye eyeId)
	{
		return default(Sizei);
	}

	public static Posef GetTrackerPose(Tracker trackerId)
	{
		return default(Posef);
	}

	public static Frustumf GetTrackerFrustum(Tracker trackerId)
	{
		return default(Frustumf);
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static bool ShowUI(PlatformUI ui)
	{
		return false;
	}

	public static bool EnqueueSubmitLayer(bool onTop, bool headLocked, bool noDepthBufferTesting, IntPtr leftTexture, IntPtr rightTexture, int layerId, int frameIndex, Posef pose, Vector3f scale, int layerIndex = 0, OverlayShape shape = OverlayShape.Quad, bool overrideTextureRectMatrix = false, TextureRectMatrixf textureRectMatrix = default(TextureRectMatrixf), bool overridePerLayerColorScaleAndOffset = false, Vector4 colorScale = default(Vector4), Vector4 colorOffset = default(Vector4), bool expensiveSuperSample = false, bool bicubic = false, bool efficientSuperSample = false, bool efficientSharpen = false, bool expensiveSharpen = false, bool hidden = false, bool secureContent = false, bool automaticFiltering = false)
	{
		return false;
	}

	public static LayerDesc CalculateLayerDesc(OverlayShape shape, LayerLayout layout, Sizei textureSize, int mipLevels, int sampleCount, EyeTextureFormat format, int layerFlags)
	{
		return default(LayerDesc);
	}

	public static bool EnqueueSetupLayer(LayerDesc desc, int compositionDepth, IntPtr layerID)
	{
		return false;
	}

	public static bool EnqueueDestroyLayer(IntPtr layerID)
	{
		return false;
	}

	public static IntPtr GetLayerTexture(int layerId, int stage, Eye eyeId)
	{
		return (IntPtr)0;
	}

	public static int GetLayerTextureStageCount(int layerId)
	{
		return 0;
	}

	public static IntPtr GetLayerAndroidSurfaceObject(int layerId)
	{
		return (IntPtr)0;
	}

	public static bool UpdateNodePhysicsPoses(int frameIndex, double predictionSeconds)
	{
		return false;
	}

	public static Posef GetNodePose(Node nodeId, Step stepId)
	{
		return default(Posef);
	}

	public static Vector3f GetNodeVelocity(Node nodeId, Step stepId)
	{
		return default(Vector3f);
	}

	public static Vector3f GetNodeAngularVelocity(Node nodeId, Step stepId)
	{
		return default(Vector3f);
	}

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public static Vector3f GetNodeAcceleration(Node nodeId, Step stepId)
	{
		return default(Vector3f);
	}

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public static Vector3f GetNodeAngularAcceleration(Node nodeId, Step stepId)
	{
		return default(Vector3f);
	}

	public static bool GetNodePresent(Node nodeId)
	{
		return false;
	}

	public static bool GetNodeOrientationTracked(Node nodeId)
	{
		return false;
	}

	public static bool GetNodeOrientationValid(Node nodeId)
	{
		return false;
	}

	public static bool GetNodePositionTracked(Node nodeId)
	{
		return false;
	}

	public static bool GetNodePositionValid(Node nodeId)
	{
		return false;
	}

	public static PoseStatef GetNodePoseStateRaw(Node nodeId, Step stepId)
	{
		return default(PoseStatef);
	}

	public static PoseStatef GetNodePoseStateAtTime(double time, Node nodeId)
	{
		return default(PoseStatef);
	}

	public static PoseStatef GetNodePoseStateImmediate(Node nodeId)
	{
		return default(PoseStatef);
	}

	public static bool AreHandPosesGeneratedByControllerData(Step stepId, Node nodeId)
	{
		return false;
	}

	public static bool SetSimultaneousHandsAndControllersEnabled(bool enabled)
	{
		return false;
	}

	public static bool GetControllerIsInHand(Step stepId, Node nodeId)
	{
		return false;
	}

	public static Posef GetCurrentTrackingTransformPose()
	{
		return default(Posef);
	}

	public static Posef GetTrackingTransformRawPose()
	{
		return default(Posef);
	}

	public static Posef GetTrackingTransformRelativePose(TrackingOrigin trackingOrigin)
	{
		return default(Posef);
	}

	public static ControllerState GetControllerState(uint controllerMask)
	{
		return default(ControllerState);
	}

	public static ControllerState2 GetControllerState2(uint controllerMask)
	{
		return default(ControllerState2);
	}

	public static ControllerState4 GetControllerState4(uint controllerMask)
	{
		return default(ControllerState4);
	}

	public static ControllerState5 GetControllerState5(uint controllerMask)
	{
		return default(ControllerState5);
	}

	public static ControllerState6 GetControllerState6(uint controllerMask)
	{
		return default(ControllerState6);
	}

	public static InteractionProfile GetCurrentInteractionProfile(Hand hand)
	{
		return default(InteractionProfile);
	}

	public static InteractionProfile GetCurrentDetachedInteractionProfile(Hand hand)
	{
		return default(InteractionProfile);
	}

	public static bool SetControllerVibration(uint controllerMask, float frequency, float amplitude)
	{
		return false;
	}

	public static bool SetControllerLocalizedVibration(Controller controllerMask, HapticsLocation hapticsLocationMask, float frequency, float amplitude)
	{
		return false;
	}

	public static bool SetControllerHapticsAmplitudeEnvelope(Controller controllerMask, HapticsAmplitudeEnvelopeVibration hapticsVibration)
	{
		return false;
	}

	public static bool SetControllerHapticsPcm(Controller controllerMask, HapticsPcmVibration hapticsVibration)
	{
		return false;
	}

	public static bool GetControllerSampleRateHz(Controller controllerMask, out float sampleRateHz)
	{
		sampleRateHz = default(float);
		return false;
	}

	public static HapticsDesc GetControllerHapticsDesc(uint controllerMask)
	{
		return default(HapticsDesc);
	}

	public static HapticsState GetControllerHapticsState(uint controllerMask)
	{
		return default(HapticsState);
	}

	public static bool SetControllerHaptics(uint controllerMask, HapticsBuffer hapticsBuffer)
	{
		return false;
	}

	public static float GetEyeRecommendedResolutionScale()
	{
		return 0f;
	}

	public static float GetAppCpuStartToGpuEndTime()
	{
		return 0f;
	}

	public static bool GetBoundaryConfigured()
	{
		return false;
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static BoundaryTestResult TestBoundaryNode(Node nodeId, BoundaryType boundaryType)
	{
		return default(BoundaryTestResult);
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static BoundaryTestResult TestBoundaryPoint(Vector3f point, BoundaryType boundaryType)
	{
		return default(BoundaryTestResult);
	}

	public static BoundaryGeometry GetBoundaryGeometry(BoundaryType boundaryType)
	{
		return default(BoundaryGeometry);
	}

	public static bool GetBoundaryGeometry2(BoundaryType boundaryType, IntPtr points, ref int pointsCount)
	{
		return false;
	}

	public static AppPerfStats GetAppPerfStats()
	{
		return default(AppPerfStats);
	}

	public static bool ResetAppPerfStats()
	{
		return false;
	}

	public static float GetAppFramerate()
	{
		return 0f;
	}

	public static bool SetHandNodePoseStateLatency(double latencyInSeconds)
	{
		return false;
	}

	public static double GetHandNodePoseStateLatency()
	{
		return 0.0;
	}

	public static bool SetControllerDrivenHandPoses(bool controllerDrivenHandPoses)
	{
		return false;
	}

	public static bool SetControllerDrivenHandPosesAreNatural(bool controllerDrivenHandPosesAreNatural)
	{
		return false;
	}

	public static bool IsControllerDrivenHandPosesEnabled()
	{
		return false;
	}

	public static bool AreControllerDrivenHandPosesNatural()
	{
		return false;
	}

	public static EyeTextureFormat GetDesiredEyeTextureFormat()
	{
		return default(EyeTextureFormat);
	}

	public static bool SetDesiredEyeTextureFormat(EyeTextureFormat value)
	{
		return false;
	}

	public static bool InitializeMixedReality()
	{
		return false;
	}

	public static bool ShutdownMixedReality()
	{
		return false;
	}

	public static bool IsMixedRealityInitialized()
	{
		return false;
	}

	public static int GetExternalCameraCount()
	{
		return 0;
	}

	public static bool UpdateExternalCamera()
	{
		return false;
	}

	public static bool GetMixedRealityCameraInfo(int cameraId, out CameraExtrinsics cameraExtrinsics, out CameraIntrinsics cameraIntrinsics)
	{
		cameraExtrinsics = default(CameraExtrinsics);
		cameraIntrinsics = default(CameraIntrinsics);
		return false;
	}

	public static bool OverrideExternalCameraFov(int cameraId, bool useOverriddenFov, Fovf fov)
	{
		return false;
	}

	public static bool GetUseOverriddenExternalCameraFov(int cameraId)
	{
		return false;
	}

	public static bool OverrideExternalCameraStaticPose(int cameraId, bool useOverriddenPose, Posef poseInStageOrigin)
	{
		return false;
	}

	public static bool GetUseOverriddenExternalCameraStaticPose(int cameraId)
	{
		return false;
	}

	public static bool ResetDefaultExternalCamera()
	{
		return false;
	}

	public static bool SetDefaultExternalCamera(string cameraName, ref CameraIntrinsics cameraIntrinsics, ref CameraExtrinsics cameraExtrinsics)
	{
		return false;
	}

	public static bool SetExternalCameraProperties(string cameraName, ref CameraIntrinsics cameraIntrinsics, ref CameraExtrinsics cameraExtrinsics)
	{
		return false;
	}

	public static bool SetMultimodalHandsControllersSupported(bool value)
	{
		return false;
	}

	public static bool IsMultimodalHandsControllersSupported()
	{
		return false;
	}

	public static bool IsInsightPassthroughSupported()
	{
		return false;
	}

	public static bool InitializeInsightPassthrough()
	{
		return false;
	}

	public static bool ShutdownInsightPassthrough()
	{
		return false;
	}

	public static bool IsInsightPassthroughInitialized()
	{
		return false;
	}

	public static Result GetInsightPassthroughInitializationState()
	{
		return default(Result);
	}

	public static bool CreateInsightTriangleMesh(int layerId, Vector3[] vertices, int[] triangles, out ulong meshHandle)
	{
		meshHandle = default(ulong);
		return false;
	}

	public static bool DestroyInsightTriangleMesh(ulong meshHandle)
	{
		return false;
	}

	public static bool AddInsightPassthroughSurfaceGeometry(int layerId, ulong meshHandle, Matrix4x4 T_world_model, out ulong geometryInstanceHandle)
	{
		geometryInstanceHandle = default(ulong);
		return false;
	}

	public static bool DestroyInsightPassthroughGeometryInstance(ulong geometryInstanceHandle)
	{
		return false;
	}

	public static bool UpdateInsightPassthroughGeometryTransform(ulong geometryInstanceHandle, Matrix4x4 transform)
	{
		return false;
	}

	public static bool SetInsightPassthroughStyle(int layerId, InsightPassthroughStyle2 style)
	{
		return false;
	}

	public static bool SetInsightPassthroughStyle(int layerId, InsightPassthroughStyle style)
	{
		return false;
	}

	public static bool CreatePassthroughColorLut(PassthroughColorLutChannels channels, uint resolution, PassthroughColorLutData data, out ulong colorLut)
	{
		colorLut = default(ulong);
		return false;
	}

	public static bool DestroyPassthroughColorLut(ulong colorLut)
	{
		return false;
	}

	public static bool UpdatePassthroughColorLut(ulong colorLut, PassthroughColorLutData data)
	{
		return false;
	}

	public static bool SetInsightPassthroughKeyboardHandsIntensity(int layerId, InsightPassthroughKeyboardHandsIntensity intensity)
	{
		return false;
	}

	public static PassthroughCapabilityFlags GetPassthroughCapabilityFlags()
	{
		return default(PassthroughCapabilityFlags);
	}

	public static Result GetPassthroughCapabilities(ref PassthroughCapabilities outCapabilities)
	{
		return default(Result);
	}

	public static Vector3f GetBoundaryDimensions(BoundaryType boundaryType)
	{
		return default(Vector3f);
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static bool GetBoundaryVisible()
	{
		return false;
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static bool SetBoundaryVisible(bool value)
	{
		return false;
	}

	public static SystemHeadset GetSystemHeadsetType()
	{
		return default(SystemHeadset);
	}

	public static Controller GetActiveController()
	{
		return default(Controller);
	}

	public static Controller GetConnectedControllers()
	{
		return default(Controller);
	}

	private static Bool ToBool(bool b)
	{
		return default(Bool);
	}

	public static TrackingOrigin GetTrackingOriginType()
	{
		return default(TrackingOrigin);
	}

	public static bool SetTrackingOriginType(TrackingOrigin originType)
	{
		return false;
	}

	public static Posef GetTrackingCalibratedOrigin()
	{
		return default(Posef);
	}

	public static bool SetTrackingCalibratedOrigin()
	{
		return false;
	}

	public static bool RecenterTrackingOrigin(RecenterFlags flags)
	{
		return false;
	}

	public static bool UpdateCameraDevices()
	{
		return false;
	}

	public static bool IsCameraDeviceAvailable(CameraDevice cameraDevice)
	{
		return false;
	}

	public static bool SetCameraDevicePreferredColorFrameSize(CameraDevice cameraDevice, int width, int height)
	{
		return false;
	}

	public static bool OpenCameraDevice(CameraDevice cameraDevice)
	{
		return false;
	}

	public static bool CloseCameraDevice(CameraDevice cameraDevice)
	{
		return false;
	}

	public static bool HasCameraDeviceOpened(CameraDevice cameraDevice)
	{
		return false;
	}

	public static bool IsCameraDeviceColorFrameAvailable(CameraDevice cameraDevice)
	{
		return false;
	}

	public static Texture2D GetCameraDeviceColorFrameTexture(CameraDevice cameraDevice)
	{
		return null;
	}

	public static bool DoesCameraDeviceSupportDepth(CameraDevice cameraDevice)
	{
		return false;
	}

	public static bool SetCameraDeviceDepthSensingMode(CameraDevice camera, CameraDeviceDepthSensingMode depthSensoringMode)
	{
		return false;
	}

	public static bool SetCameraDevicePreferredDepthQuality(CameraDevice camera, CameraDeviceDepthQuality depthQuality)
	{
		return false;
	}

	public static bool IsCameraDeviceDepthFrameAvailable(CameraDevice cameraDevice)
	{
		return false;
	}

	public static Texture2D GetCameraDeviceDepthFrameTexture(CameraDevice cameraDevice)
	{
		return null;
	}

	public static Texture2D GetCameraDeviceDepthConfidenceTexture(CameraDevice cameraDevice)
	{
		return null;
	}

	public static bool GetNodeFrustum2(Node nodeId, out Frustumf2 frustum)
	{
		frustum = default(Frustumf2);
		return false;
	}

	public static Handedness GetDominantHand()
	{
		return default(Handedness);
	}

	public static bool SendEvent(string name, string param = "", string source = "")
	{
		return false;
	}

	public static bool SetHeadPoseModifier(ref Quatf relativeRotation, ref Vector3f relativeTranslation)
	{
		return false;
	}

	public static bool GetHeadPoseModifier(out Quatf relativeRotation, out Vector3f relativeTranslation)
	{
		relativeRotation = default(Quatf);
		relativeTranslation = default(Vector3f);
		return false;
	}

	public static bool IsPerfMetricsSupported(PerfMetrics perfMetrics)
	{
		return false;
	}

	public static float? GetPerfMetricsFloat(PerfMetrics perfMetrics)
	{
		return null;
	}

	public static int? GetPerfMetricsInt(PerfMetrics perfMetrics)
	{
		return null;
	}

	public static double GetTimeInSeconds()
	{
		return 0.0;
	}

	public static bool SetColorScaleAndOffset(Vector4 colorScale, Vector4 colorOffset, bool applyToAllLayers)
	{
		return false;
	}

	public static bool AddCustomMetadata(string name, string param = "")
	{
		return false;
	}

	public static bool SetDeveloperMode(Bool active)
	{
		return false;
	}

	[Obsolete("Deprecated. This function will not be supported in OpenXR", false)]
	public static float GetAdaptiveGPUPerformanceScale()
	{
		return 0f;
	}

	public static bool GetHandTrackingEnabled()
	{
		return false;
	}

	public static bool GetHandState(Step stepId, Hand hand, ref HandState handState)
	{
		return false;
	}

	public static bool IsValidBone(BoneId bone, SkeletonType skeletonType)
	{
		return false;
	}

	public static bool GetSkeleton(SkeletonType skeletonType, out Skeleton skeleton)
	{
		skeleton = default(Skeleton);
		return false;
	}

	public static bool GetSkeleton2(SkeletonType skeletonType, ref Skeleton2 skeleton)
	{
		return false;
	}

	public static bool GetBodyState(Step stepId, ref BodyState bodyState)
	{
		return false;
	}

	public static bool GetBodyState4(Step stepId, BodyJointSet jointSet, ref BodyState bodyState)
	{
		return false;
	}

	public static bool GetMesh(MeshType meshType, out Mesh mesh)
	{
		mesh = null;
		return false;
	}

	public static bool StartKeyboardTracking(ulong trackedKeyboardId)
	{
		return false;
	}

	public static bool StopKeyboardTracking()
	{
		return false;
	}

	public static bool GetKeyboardState(Step stepId, out KeyboardState keyboardState)
	{
		keyboardState = default(KeyboardState);
		return false;
	}

	public static bool GetSystemKeyboardDescription(TrackedKeyboardQueryFlags keyboardQueryFlags, out KeyboardDescription keyboardDescription)
	{
		keyboardDescription = default(KeyboardDescription);
		return false;
	}

	public static Result CreateVirtualKeyboard(VirtualKeyboardCreateInfo createInfo)
	{
		return default(Result);
	}

	public static Result DestroyVirtualKeyboard()
	{
		return default(Result);
	}

	public static Result SendVirtualKeyboardInput(VirtualKeyboardInputInfo inputInfo, ref Posef interactorRootPose)
	{
		return default(Result);
	}

	public static Result ChangeVirtualKeyboardTextContext(string textContext)
	{
		return default(Result);
	}

	public static Result CreateVirtualKeyboardSpace(VirtualKeyboardSpaceCreateInfo createInfo, out ulong keyboardSpace)
	{
		keyboardSpace = default(ulong);
		return default(Result);
	}

	public static Result SuggestVirtualKeyboardLocation(VirtualKeyboardLocationInfo locationInfo)
	{
		return default(Result);
	}

	public static Result GetVirtualKeyboardScale(out float scale)
	{
		scale = default(float);
		return default(Result);
	}

	public static Result GetVirtualKeyboardModelAnimationStates(VirtualKeyboardModelAnimationStateBufferProvider bufferProvider, VirtualKeyboardModelAnimationStateHandler stateHandler)
	{
		return default(Result);
	}

	[Obsolete("Use GetVirtualKeyboardModelAnimationStates with delegates")]
	public static Result GetVirtualKeyboardModelAnimationStates(out VirtualKeyboardModelAnimationStates animationStates)
	{
		animationStates = default(VirtualKeyboardModelAnimationStates);
		return default(Result);
	}

	public static Result GetVirtualKeyboardDirtyTextures(out VirtualKeyboardTextureIds textureIds)
	{
		textureIds = default(VirtualKeyboardTextureIds);
		return default(Result);
	}

	public static Result GetVirtualKeyboardTextureData(ulong textureId, ref VirtualKeyboardTextureData textureData)
	{
		return default(Result);
	}

	public static Result SetVirtualKeyboardModelVisibility(ref VirtualKeyboardModelVisibility visibility)
	{
		return default(Result);
	}

	private static bool GetFaceStateInternal(Step stepId, int frameIndex, ref FaceState faceState)
	{
		return false;
	}

	public static bool GetFaceState(Step stepId, int frameIndex, ref FaceState faceState)
	{
		return false;
	}

	public static bool GetFaceState2(Step stepId, int frameIndex, ref FaceState faceState)
	{
		return false;
	}

	public static bool GetEyeGazesState(Step stepId, int frameIndex, ref EyeGazesState eyeGazesState)
	{
		return false;
	}

	public static bool StartEyeTracking()
	{
		return false;
	}

	public static bool StopEyeTracking()
	{
		return false;
	}

	public static bool StartFaceTracking()
	{
		return false;
	}

	public static bool StopFaceTracking()
	{
		return false;
	}

	public static bool StartFaceTracking2(FaceTrackingDataSource[] requestedFaceTrackingDataSources)
	{
		return false;
	}

	public static bool StopFaceTracking2()
	{
		return false;
	}

	public static bool StartBodyTracking2(BodyJointSet jointSet)
	{
		return false;
	}

	public static bool StartBodyTracking()
	{
		return false;
	}

	public static bool RequestBodyTrackingFidelity(BodyTrackingFidelity2 fidelity)
	{
		return false;
	}

	public static bool SuggestBodyTrackingCalibrationOverride(BodyTrackingCalibrationInfo calibrationInfo)
	{
		return false;
	}

	public static bool ResetBodyTrackingCalibration()
	{
		return false;
	}

	public static bool StopBodyTracking()
	{
		return false;
	}

	public static int GetLocalTrackingSpaceRecenterCount()
	{
		return 0;
	}

	public static bool GetSystemHmd3DofModeEnabled()
	{
		return false;
	}

	public static bool SetClientColorDesc(ColorSpace colorSpace)
	{
		return false;
	}

	public static ColorSpace GetHmdColorDesc()
	{
		return default(ColorSpace);
	}

	public static bool PollEvent(ref EventDataBuffer eventDataBuffer)
	{
		return false;
	}

	public static ulong GetNativeOpenXRInstance()
	{
		return 0uL;
	}

	public static ulong GetNativeOpenXRSession()
	{
		return 0uL;
	}

	public static bool SetKeyboardOverlayUV(Vector2f uv)
	{
		return false;
	}

	public static bool CreateSpatialAnchor(SpatialAnchorCreateInfo createInfo, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool SetSpaceComponentStatus(ulong space, SpaceComponentType componentType, bool enable, double timeout, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool GetSpaceComponentStatus(ulong space, SpaceComponentType componentType, out bool enabled, out bool changePending)
	{
		enabled = default(bool);
		changePending = default(bool);
		return false;
	}

	internal static Result GetSpaceComponentStatusInternal(ulong space, SpaceComponentType componentType, out bool enabled, out bool changePending)
	{
		enabled = default(bool);
		changePending = default(bool);
		return default(Result);
	}

	public static bool EnumerateSpaceSupportedComponents(ulong space, out uint numSupportedComponents, SpaceComponentType[] supportedComponents)
	{
		numSupportedComponents = default(uint);
		return false;
	}

	public static bool SaveSpace(ulong space, SpaceStorageLocation location, SpaceStoragePersistenceMode mode, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool EraseSpace(ulong space, SpaceStorageLocation location, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool GetSpaceUuid(ulong space, out Guid uuid)
	{
		uuid = default(Guid);
		return false;
	}

	public static bool QuerySpaces(SpaceQueryInfo queryInfo, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool RetrieveSpaceQueryResults(ulong requestId, out NativeArray<SpaceQueryResult> results, Allocator allocator)
	{
		results = default(NativeArray<SpaceQueryResult>);
		return false;
	}

	public static bool RetrieveSpaceQueryResults(ulong requestId, out SpaceQueryResult[] results)
	{
		results = null;
		return false;
	}

	public static Result SaveSpaceList(NativeArray<ulong> spaces, SpaceStorageLocation location, out ulong requestId)
	{
		requestId = default(ulong);
		return default(Result);
	}

	public static bool GetSpaceUserId(ulong spaceUserHandle, out ulong spaceUserId)
	{
		spaceUserId = default(ulong);
		return false;
	}

	public static bool CreateSpaceUser(ulong spaceUserId, out ulong spaceUserHandle)
	{
		spaceUserHandle = default(ulong);
		return false;
	}

	public static bool DestroySpaceUser(ulong spaceUserHandle)
	{
		return false;
	}

	public static Result ShareSpaces(NativeArray<ulong> spaces, NativeArray<ulong> userHandles, out ulong requestId)
	{
		requestId = default(ulong);
		return default(Result);
	}

	public static bool TryLocateSpace(ulong space, TrackingOrigin baseOrigin, out Posef pose)
	{
		pose = default(Posef);
		return false;
	}

	[Obsolete("LocateSpace unconditionally returns a pose, even if the underlying OpenXR function fails. Instead, use TryLocateSpace, which indicates failure.")]
	public static Posef LocateSpace(ulong space, TrackingOrigin baseOrigin)
	{
		return default(Posef);
	}

	public static bool TryLocateSpace(ulong space, TrackingOrigin baseOrigin, out Posef pose, out SpaceLocationFlags locationFlags)
	{
		pose = default(Posef);
		locationFlags = default(SpaceLocationFlags);
		return false;
	}

	public static bool DestroySpace(ulong space)
	{
		return false;
	}

	public static bool GetSpaceContainer(ulong space, out Guid[] containerUuids)
	{
		containerUuids = null;
		return false;
	}

	public static bool GetSpaceBoundingBox2D(ulong space, out Rectf rect)
	{
		rect = default(Rectf);
		return false;
	}

	public static bool GetSpaceBoundingBox3D(ulong space, out Boundsf bounds)
	{
		bounds = default(Boundsf);
		return false;
	}

	public static bool GetSpaceSemanticLabels(ulong space, out string labels)
	{
		labels = null;
		return false;
	}

	public static bool GetSpaceRoomLayout(ulong space, out RoomLayout roomLayout)
	{
		roomLayout = default(RoomLayout);
		return false;
	}

	public static bool GetSpaceBoundary2DCount(ulong space, out int count)
	{
		count = default(int);
		return false;
	}

	public static bool GetSpaceBoundary2D(ulong space, NativeArray<Vector2> boundary)
	{
		return false;
	}

	public static bool GetSpaceBoundary2D(ulong space, NativeArray<Vector2> boundary, out int count)
	{
		count = default(int);
		return false;
	}

	public static NativeArray<Vector2> GetSpaceBoundary2D(ulong space, Allocator allocator)
	{
		return default(NativeArray<Vector2>);
	}

	[Obsolete("This method allocates managed arrays. Use GetSpaceBoundary2D(UInt64, Allocator) to avoid managed allocations.")]
	public static bool GetSpaceBoundary2D(ulong space, out Vector2[] boundary)
	{
		boundary = null;
		return false;
	}

	public static bool RequestSceneCapture(string requestString, out ulong requestId)
	{
		requestId = default(ulong);
		return false;
	}

	public static bool GetSpaceTriangleMeshCounts(ulong space, out int vertexCount, out int triangleCount)
	{
		vertexCount = default(int);
		triangleCount = default(int);
		return false;
	}

	public static bool GetSpaceTriangleMesh(ulong space, NativeArray<Vector3> vertices, NativeArray<int> triangles)
	{
		return false;
	}

	public static bool GetLayerRecommendedResolution(int layerId, out Sizei recommendedSize)
	{
		recommendedSize = default(Sizei);
		return false;
	}

	public static bool GetEyeLayerRecommendedResolution(out Sizei recommendedSize)
	{
		recommendedSize = default(Sizei);
		return false;
	}

	public static string[] GetRenderModelPaths()
	{
		return null;
	}

	public static bool GetRenderModelProperties(string modelPath, ref RenderModelProperties modelProperties)
	{
		return false;
	}

	public static byte[] LoadRenderModel(ulong modelKey)
	{
		return null;
	}

	public static void OnEditorShutdown()
	{
	}

	internal static Result GetPassthroughPreferences(out PassthroughPreferences preferences)
	{
		preferences = default(PassthroughPreferences);
		return default(Result);
	}

	public static bool SetEyeBufferSharpenType(LayerSharpenType sharpenType)
	{
		return false;
	}
}
