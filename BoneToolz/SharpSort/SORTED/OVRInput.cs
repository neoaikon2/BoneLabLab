using System;
using System.Collections.Generic;
using OVR.OpenVR;
using UnityEngine;
using UnityEngine.XR;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_input")]
public static class OVRInput
{
	[Flags]
	public enum Button
	{
		None = 0,
		One = 1,
		Two = 2,
		Three = 4,
		Four = 8,
		Start = 0x100,
		Back = 0x200,
		PrimaryShoulder = 0x1000,
		PrimaryIndexTrigger = 0x2000,
		PrimaryHandTrigger = 0x4000,
		PrimaryThumbstick = 0x8000,
		PrimaryThumbstickUp = 0x10000,
		PrimaryThumbstickDown = 0x20000,
		PrimaryThumbstickLeft = 0x40000,
		PrimaryThumbstickRight = 0x80000,
		PrimaryTouchpad = 0x400,
		SecondaryShoulder = 0x100000,
		SecondaryIndexTrigger = 0x200000,
		SecondaryHandTrigger = 0x400000,
		SecondaryThumbstick = 0x800000,
		SecondaryThumbstickUp = 0x1000000,
		SecondaryThumbstickDown = 0x2000000,
		SecondaryThumbstickLeft = 0x4000000,
		SecondaryThumbstickRight = 0x8000000,
		SecondaryTouchpad = 0x800,
		DpadUp = 0x10,
		DpadDown = 0x20,
		DpadLeft = 0x40,
		DpadRight = 0x80,
		Up = 0x10000000,
		Down = 0x20000000,
		Left = 0x40000000,
		Right = int.MinValue,
		Any = -1
	}

	[Flags]
	public enum RawButton
	{
		None = 0,
		A = 1,
		B = 2,
		X = 0x100,
		Y = 0x200,
		Start = 0x100000,
		Back = 0x200000,
		LShoulder = 0x800,
		LIndexTrigger = 0x10000000,
		LHandTrigger = 0x20000000,
		LThumbstick = 0x400,
		LThumbstickUp = 0x10,
		LThumbstickDown = 0x20,
		LThumbstickLeft = 0x40,
		LThumbstickRight = 0x80,
		LTouchpad = 0x40000000,
		RShoulder = 8,
		RIndexTrigger = 0x4000000,
		RHandTrigger = 0x8000000,
		RThumbstick = 4,
		RThumbstickUp = 0x1000,
		RThumbstickDown = 0x2000,
		RThumbstickLeft = 0x4000,
		RThumbstickRight = 0x8000,
		RTouchpad = int.MinValue,
		DpadUp = 0x10000,
		DpadDown = 0x20000,
		DpadLeft = 0x40000,
		DpadRight = 0x80000,
		Any = -1
	}

	[Flags]
	public enum Touch
	{
		None = 0,
		One = 1,
		Two = 2,
		Three = 4,
		Four = 8,
		PrimaryIndexTrigger = 0x2000,
		PrimaryThumbstick = 0x8000,
		PrimaryThumbRest = 0x1000,
		PrimaryTouchpad = 0x400,
		SecondaryIndexTrigger = 0x200000,
		SecondaryThumbstick = 0x800000,
		SecondaryThumbRest = 0x100000,
		SecondaryTouchpad = 0x800,
		Any = -1
	}

	[Flags]
	public enum RawTouch
	{
		None = 0,
		A = 1,
		B = 2,
		X = 0x100,
		Y = 0x200,
		LIndexTrigger = 0x1000,
		LThumbstick = 0x400,
		LThumbRest = 0x800,
		LTouchpad = 0x40000000,
		RIndexTrigger = 0x10,
		RThumbstick = 4,
		RThumbRest = 8,
		RTouchpad = int.MinValue,
		Any = -1
	}

	[Flags]
	public enum NearTouch
	{
		None = 0,
		PrimaryIndexTrigger = 1,
		PrimaryThumbButtons = 2,
		SecondaryIndexTrigger = 4,
		SecondaryThumbButtons = 8,
		Any = -1
	}

	[Flags]
	public enum RawNearTouch
	{
		None = 0,
		LIndexTrigger = 1,
		LThumbButtons = 2,
		RIndexTrigger = 4,
		RThumbButtons = 8,
		Any = -1
	}

	[Flags]
	public enum Axis1D
	{
		None = 0,
		PrimaryIndexTrigger = 1,
		PrimaryHandTrigger = 4,
		SecondaryIndexTrigger = 2,
		SecondaryHandTrigger = 8,
		PrimaryIndexTriggerCurl = 0x10,
		PrimaryIndexTriggerSlide = 0x20,
		PrimaryThumbRestForce = 0x40,
		PrimaryStylusForce = 0x80,
		SecondaryIndexTriggerCurl = 0x100,
		SecondaryIndexTriggerSlide = 0x200,
		SecondaryThumbRestForce = 0x400,
		SecondaryStylusForce = 0x800,
		PrimaryIndexTriggerForce = 0x1000,
		SecondaryIndexTriggerForce = 0x2000,
		Any = -1
	}

	[Flags]
	public enum RawAxis1D
	{
		None = 0,
		LIndexTrigger = 1,
		LHandTrigger = 4,
		RIndexTrigger = 2,
		RHandTrigger = 8,
		LIndexTriggerCurl = 0x10,
		LIndexTriggerSlide = 0x20,
		LThumbRestForce = 0x40,
		LStylusForce = 0x80,
		RIndexTriggerCurl = 0x100,
		RIndexTriggerSlide = 0x200,
		RThumbRestForce = 0x400,
		RStylusForce = 0x800,
		LIndexTriggerForce = 0x1000,
		RIndexTriggerForce = 0x2000,
		Any = -1
	}

	[Flags]
	public enum Axis2D
	{
		None = 0,
		PrimaryThumbstick = 1,
		PrimaryTouchpad = 4,
		SecondaryThumbstick = 2,
		SecondaryTouchpad = 8,
		Any = -1
	}

	[Flags]
	public enum RawAxis2D
	{
		None = 0,
		LThumbstick = 1,
		LTouchpad = 4,
		RThumbstick = 2,
		RTouchpad = 8,
		Any = -1
	}

	[Flags]
	public enum OpenVRButton : ulong
	{
		None = 0uL,
		Two = 2uL,
		Thumbstick = 0x100000000uL,
		Grip = 4uL
	}

	[Flags]
	public enum Controller
	{
		None = 0,
		LTouch = 1,
		RTouch = 2,
		Touch = 3,
		Remote = 4,
		Gamepad = 0x10,
		Hands = 0x60,
		LHand = 0x20,
		RHand = 0x40,
		Active = int.MinValue,
		All = -1
	}

	public enum Handedness
	{
		Unsupported = 0,
		LeftHanded = 1,
		RightHanded = 2
	}

	public enum HapticsLocation
	{
		None = 0,
		Hand = 1,
		Thumb = 2,
		Index = 4
	}

	public enum InteractionProfile
	{
		None = 0,
		Touch = 1,
		TouchPro = 2,
		TouchPlus = 4
	}

	public enum Hand
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	public enum InputDeviceShowState
	{
		Always = 0,
		ControllerInHandOrNoHand = 1,
		ControllerInHand = 2,
		ControllerNotInHand = 3,
		NoHand = 4
	}

	public enum ControllerInHandState
	{
		NoHand = 0,
		ControllerInHand = 1,
		ControllerNotInHand = 2
	}

	public struct HapticsAmplitudeEnvelopeVibration
	{
		public int SamplesCount;

		public float[] Samples;

		public float Duration;
	}

	public struct HapticsPcmVibration
	{
		public int SamplesCount;

		public float[] Samples;

		public float SampleRateHz;

		public bool Append;
	}

	[Flags]
	public enum OpenVRController : ulong
	{
		Unknown = 0uL,
		OculusTouch = 1uL,
		ViveController = 2uL,
		WindowsMRController = 3uL
	}

	public struct OpenVRControllerDetails
	{
		public VRControllerState_t state;

		public OpenVRController controllerType;

		public uint deviceID;

		public Vector3 localPosition;

		public Quaternion localOrientation;
	}

	private class HapticInfo
	{
		public bool playingHaptics;

		public float hapticsDurationPlayed;

		public float hapticsDuration;

		public float hapticAmplitude;

		public XRNode node;
	}

	public abstract class OVRControllerBase
	{
		public class VirtualButtonMap
		{
			public RawButton None;

			public RawButton One;

			public RawButton Two;

			public RawButton Three;

			public RawButton Four;

			public RawButton Start;

			public RawButton Back;

			public RawButton PrimaryShoulder;

			public RawButton PrimaryIndexTrigger;

			public RawButton PrimaryHandTrigger;

			public RawButton PrimaryThumbstick;

			public RawButton PrimaryThumbstickUp;

			public RawButton PrimaryThumbstickDown;

			public RawButton PrimaryThumbstickLeft;

			public RawButton PrimaryThumbstickRight;

			public RawButton PrimaryTouchpad;

			public RawButton SecondaryShoulder;

			public RawButton SecondaryIndexTrigger;

			public RawButton SecondaryHandTrigger;

			public RawButton SecondaryThumbstick;

			public RawButton SecondaryThumbstickUp;

			public RawButton SecondaryThumbstickDown;

			public RawButton SecondaryThumbstickLeft;

			public RawButton SecondaryThumbstickRight;

			public RawButton SecondaryTouchpad;

			public RawButton DpadUp;

			public RawButton DpadDown;

			public RawButton DpadLeft;

			public RawButton DpadRight;

			public RawButton Up;

			public RawButton Down;

			public RawButton Left;

			public RawButton Right;

			public RawButton ToRawMask(Button virtualMask)
			{
				return default(RawButton);
			}
		}

		public class VirtualTouchMap
		{
			public RawTouch None;

			public RawTouch One;

			public RawTouch Two;

			public RawTouch Three;

			public RawTouch Four;

			public RawTouch PrimaryIndexTrigger;

			public RawTouch PrimaryThumbstick;

			public RawTouch PrimaryThumbRest;

			public RawTouch PrimaryTouchpad;

			public RawTouch SecondaryIndexTrigger;

			public RawTouch SecondaryThumbstick;

			public RawTouch SecondaryThumbRest;

			public RawTouch SecondaryTouchpad;

			public RawTouch ToRawMask(Touch virtualMask)
			{
				return default(RawTouch);
			}
		}

		public class VirtualNearTouchMap
		{
			public RawNearTouch None;

			public RawNearTouch PrimaryIndexTrigger;

			public RawNearTouch PrimaryThumbButtons;

			public RawNearTouch SecondaryIndexTrigger;

			public RawNearTouch SecondaryThumbButtons;

			public RawNearTouch ToRawMask(NearTouch virtualMask)
			{
				return default(RawNearTouch);
			}
		}

		public class VirtualAxis1DMap
		{
			public RawAxis1D None;

			public RawAxis1D PrimaryIndexTrigger;

			public RawAxis1D PrimaryHandTrigger;

			public RawAxis1D SecondaryIndexTrigger;

			public RawAxis1D SecondaryHandTrigger;

			public RawAxis1D PrimaryIndexTriggerCurl;

			public RawAxis1D PrimaryIndexTriggerSlide;

			public RawAxis1D PrimaryThumbRestForce;

			public RawAxis1D PrimaryStylusForce;

			public RawAxis1D SecondaryIndexTriggerCurl;

			public RawAxis1D SecondaryIndexTriggerSlide;

			public RawAxis1D SecondaryThumbRestForce;

			public RawAxis1D SecondaryStylusForce;

			public RawAxis1D PrimaryIndexTriggerForce;

			public RawAxis1D SecondaryIndexTriggerForce;

			public RawAxis1D ToRawMask(Axis1D virtualMask)
			{
				return default(RawAxis1D);
			}
		}

		public class VirtualAxis2DMap
		{
			public RawAxis2D None;

			public RawAxis2D PrimaryThumbstick;

			public RawAxis2D PrimaryTouchpad;

			public RawAxis2D SecondaryThumbstick;

			public RawAxis2D SecondaryTouchpad;

			public RawAxis2D ToRawMask(Axis2D virtualMask)
			{
				return default(RawAxis2D);
			}
		}

		public Controller controllerType;

		public VirtualButtonMap buttonMap;

		public VirtualTouchMap touchMap;

		public VirtualNearTouchMap nearTouchMap;

		public VirtualAxis1DMap axis1DMap;

		public VirtualAxis2DMap axis2DMap;

		public OVRPlugin.ControllerState6 previousState;

		public OVRPlugin.ControllerState6 currentState;

		public bool shouldApplyDeadzone;

		private uint[] HapticsPcmSamplesConsumedCache;

		public OVRControllerBase()
		{
		}

		public virtual Controller Update()
		{
			return default(Controller);
		}

		private OVRPlugin.ControllerState6 GetOpenVRControllerState(Controller controllerType)
		{
			return default(OVRPlugin.ControllerState6);
		}

		public virtual void SetControllerVibration(float frequency, float amplitude)
		{
		}

		public virtual void SetControllerLocalizedVibration(HapticsLocation hapticsLocationMask, float frequency, float amplitude)
		{
		}

		public virtual void SetControllerHapticsAmplitudeEnvelope(HapticsAmplitudeEnvelopeVibration hapticsVibration)
		{
		}

		public virtual int SetControllerHapticsPcm(HapticsPcmVibration hapticsVibration)
		{
			return 0;
		}

		public virtual float GetControllerSampleRateHz()
		{
			return 0f;
		}

		public virtual byte GetBatteryPercentRemaining()
		{
			return 0;
		}

		public abstract void ConfigureButtonMap();

		public abstract void ConfigureTouchMap();

		public abstract void ConfigureNearTouchMap();

		public abstract void ConfigureAxis1DMap();

		public abstract void ConfigureAxis2DMap();

		public RawButton ResolveToRawMask(Button virtualMask)
		{
			return default(RawButton);
		}

		public RawTouch ResolveToRawMask(Touch virtualMask)
		{
			return default(RawTouch);
		}

		public RawNearTouch ResolveToRawMask(NearTouch virtualMask)
		{
			return default(RawNearTouch);
		}

		public RawAxis1D ResolveToRawMask(Axis1D virtualMask)
		{
			return default(RawAxis1D);
		}

		public RawAxis2D ResolveToRawMask(Axis2D virtualMask)
		{
			return default(RawAxis2D);
		}
	}

	public class OVRControllerTouch : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	public class OVRControllerLTouch : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	private class OVRControllerRTouch : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	public class OVRControllerHands : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	public class OVRControllerLHand : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	public class OVRControllerRHand : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}

		public override byte GetBatteryPercentRemaining()
		{
			return 0;
		}
	}

	public class OVRControllerRemote : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}
	}

	public class OVRControllerGamepadPC : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}
	}

	private class OVRControllerGamepadAndroid : OVRControllerBase
	{
		public override void ConfigureButtonMap()
		{
		}

		public override void ConfigureTouchMap()
		{
		}

		public override void ConfigureNearTouchMap()
		{
		}

		public override void ConfigureAxis1DMap()
		{
		}

		public override void ConfigureAxis2DMap()
		{
		}
	}

	public static readonly float AXIS_AS_BUTTON_THRESHOLD;

	public static readonly float AXIS_DEADZONE_THRESHOLD;

	public static List<OVRControllerBase> controllers;

	public static Controller activeControllerType;

	public static Controller connectedControllerTypes;

	public static OVRPlugin.Step stepType;

	public static int fixedUpdateCount;

	private static bool _pluginSupportsActiveController;

	private static bool _pluginSupportsActiveControllerCached;

	private static Version _pluginSupportsActiveControllerMinVersion;

	private static int NUM_HAPTIC_CHANNELS;

	private static HapticInfo[] hapticInfos;

	private static float OPENVR_MAX_HAPTIC_AMPLITUDE;

	private static float HAPTIC_VIBRATION_DURATION_SECONDS;

	private static string OPENVR_TOUCH_NAME;

	private static string OPENVR_VIVE_CONTROLLER_NAME;

	private static string OPENVR_WINDOWSMR_CONTROLLER_NAME;

	public static OpenVRControllerDetails[] openVRControllerDetails;

	public static bool pluginSupportsActiveController => false;

	static OVRInput()
	{
	}

	public static void Update()
	{
	}

	public static void FixedUpdate()
	{
	}

	public static InteractionProfile GetCurrentInteractionProfile(Hand hand)
	{
		return default(InteractionProfile);
	}

	public static bool GetControllerOrientationTracked(Controller controllerType)
	{
		return false;
	}

	public static bool GetControllerOrientationValid(Controller controllerType)
	{
		return false;
	}

	public static bool GetControllerPositionTracked(Controller controllerType)
	{
		return false;
	}

	public static bool GetControllerPositionValid(Controller controllerType)
	{
		return false;
	}

	public static bool AreHandPosesGeneratedByControllerData(OVRPlugin.Step stepId, Hand hand)
	{
		return false;
	}

	public static bool EnableSimultaneousHandsAndControllers()
	{
		return false;
	}

	public static bool DisableSimultaneousHandsAndControllers()
	{
		return false;
	}

	public static ControllerInHandState GetControllerIsInHandState(Hand hand)
	{
		return default(ControllerInHandState);
	}

	public static Controller GetActiveControllerForHand(Handedness handedness)
	{
		return default(Controller);
	}

	public static Vector3 GetLocalControllerPosition(Controller controllerType)
	{
		return default(Vector3);
	}

	public static Vector3 GetLocalControllerVelocity(Controller controllerType)
	{
		return default(Vector3);
	}

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public static Vector3 GetLocalControllerAcceleration(Controller controllerType)
	{
		return default(Vector3);
	}

	public static Quaternion GetLocalControllerRotation(Controller controllerType)
	{
		return default(Quaternion);
	}

	public static Vector3 GetLocalControllerAngularVelocity(Controller controllerType)
	{
		return default(Vector3);
	}

	[Obsolete("Deprecated. Acceleration is not supported in OpenXR", false)]
	public static Vector3 GetLocalControllerAngularAcceleration(Controller controllerType)
	{
		return default(Vector3);
	}

	public static bool GetLocalControllerStatesWithoutPrediction(Controller controllerType, out Vector3 position, out Quaternion rotation, out Vector3 velocity, out Vector3 angularVelocity)
	{
		position = default(Vector3);
		rotation = default(Quaternion);
		velocity = default(Vector3);
		angularVelocity = default(Vector3);
		return false;
	}

	public static Handedness GetDominantHand()
	{
		return default(Handedness);
	}

	public static bool Get(Button virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool Get(RawButton rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedButton(Button virtualMask, RawButton rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetDown(Button virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetDown(RawButton rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedButtonDown(Button virtualMask, RawButton rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetUp(Button virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetUp(RawButton rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedButtonUp(Button virtualMask, RawButton rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool Get(Touch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool Get(RawTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedTouch(Touch virtualMask, RawTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetDown(Touch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetDown(RawTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedTouchDown(Touch virtualMask, RawTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetUp(Touch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetUp(RawTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedTouchUp(Touch virtualMask, RawTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool Get(NearTouch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool Get(RawNearTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedNearTouch(NearTouch virtualMask, RawNearTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetDown(NearTouch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetDown(RawNearTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedNearTouchDown(NearTouch virtualMask, RawNearTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static bool GetUp(NearTouch virtualMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	public static bool GetUp(RawNearTouch rawMask, Controller controllerMask = Controller.Active)
	{
		return false;
	}

	private static bool GetResolvedNearTouchUp(NearTouch virtualMask, RawNearTouch rawMask, Controller controllerMask)
	{
		return false;
	}

	public static float Get(Axis1D virtualMask, Controller controllerMask = Controller.Active)
	{
		return 0f;
	}

	public static float Get(RawAxis1D rawMask, Controller controllerMask = Controller.Active)
	{
		return 0f;
	}

	private static float GetResolvedAxis1D(Axis1D virtualMask, RawAxis1D rawMask, Controller controllerMask)
	{
		return 0f;
	}

	public static Vector2 Get(Axis2D virtualMask, Controller controllerMask = Controller.Active)
	{
		return default(Vector2);
	}

	public static Vector2 Get(RawAxis2D rawMask, Controller controllerMask = Controller.Active)
	{
		return default(Vector2);
	}

	private static Vector2 GetResolvedAxis2D(Axis2D virtualMask, RawAxis2D rawMask, Controller controllerMask)
	{
		return default(Vector2);
	}

	public static Controller GetConnectedControllers()
	{
		return default(Controller);
	}

	public static bool IsControllerConnected(Controller controller)
	{
		return false;
	}

	public static Controller GetActiveController()
	{
		return default(Controller);
	}

	private static void StartVibration(float amplitude, float duration, XRNode controllerNode)
	{
	}

	public static void SetOpenVRLocalPose(Vector3 leftPos, Vector3 rightPos, Quaternion leftRot, Quaternion rightRot)
	{
	}

	public static string GetOpenVRStringProperty(ETrackedDeviceProperty prop, uint deviceId = 0u)
	{
		return null;
	}

	private static void UpdateXRControllerNodeIds()
	{
	}

	private static void UpdateXRControllerHaptics()
	{
	}

	private static void InitHapticInfo()
	{
	}

	private static void PlayHapticImpulse(float amplitude, XRNode deviceNode)
	{
	}

	private static bool IsValidOpenVRDevice(uint deviceId)
	{
		return false;
	}

	public static void SetControllerVibration(float frequency, float amplitude, Controller controllerMask = Controller.Active)
	{
	}

	public static void SetControllerLocalizedVibration(HapticsLocation hapticsLocationMask, float frequency, float amplitude, Controller controllerMask = Controller.Active)
	{
	}

	public static void SetControllerHapticsAmplitudeEnvelope(HapticsAmplitudeEnvelopeVibration hapticsVibration, Controller controllerMask = Controller.Active)
	{
	}

	public static int SetControllerHapticsPcm(HapticsPcmVibration hapticsVibration, Controller controllerMask = Controller.Active)
	{
		return 0;
	}

	public static float GetControllerSampleRateHz(Controller controllerMask = Controller.Active)
	{
		return 0f;
	}

	public static byte GetControllerBatteryPercentRemaining(Controller controllerMask = Controller.Active)
	{
		return 0;
	}

	private static Vector2 CalculateAbsMax(Vector2 a, Vector2 b)
	{
		return default(Vector2);
	}

	private static float CalculateAbsMax(float a, float b)
	{
		return 0f;
	}

	private static Vector2 CalculateDeadzone(Vector2 a, float deadzone)
	{
		return default(Vector2);
	}

	private static float CalculateDeadzone(float a, float deadzone)
	{
		return 0f;
	}

	private static bool ShouldResolveController(Controller controllerType, Controller controllerMask)
	{
		return false;
	}
}
