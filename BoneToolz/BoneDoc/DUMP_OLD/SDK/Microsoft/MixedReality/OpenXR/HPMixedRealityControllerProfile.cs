using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Features;
using UnityEngine.XR.OpenXR.Input;

namespace Microsoft.MixedReality.OpenXR
{
	internal class HPMixedRealityControllerProfile : OpenXRInteractionFeature
	{
		[InputControlLayout(displayName = "HP Reverb G2 Controller (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" })]
		[Preserve]
		public class HPMixedRealityController : XRControllerWithRumble
		{
			[Preserve]
			[InputControl(aliases = new string[] { "Primary2DAxis", "Joystick" })]
			public Vector2Control thumbstick { get; private set; }

			[InputControl(aliases = new string[] { "GripAxis", "squeeze" })]
			[Preserve]
			public AxisControl grip { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "GripButton", "squeezeClicked" })]
			public ButtonControl gripPressed { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "menuButton" })]
			public ButtonControl menu { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "A", "X", "buttonA", "buttonX" })]
			public ButtonControl primaryButton { get; private set; }

			[Preserve]
			[InputControl(aliases = new string[] { "B", "Y", "buttonB", "buttonY" })]
			public ButtonControl secondaryButton { get; private set; }

			[Preserve]
			[InputControl]
			public AxisControl trigger { get; private set; }

			[InputControl(aliases = new string[] { "indexButton", "indexTouched", "triggerbutton" })]
			[Preserve]
			public ButtonControl triggerPressed { get; private set; }

			[InputControl(aliases = new string[] { "joystickOrPadPressed" })]
			[Preserve]
			public ButtonControl thumbstickClicked { get; private set; }

			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "device", "gripPose" })]
			public UnityEngine.XR.OpenXR.Input.PoseControl devicePose { get; private set; }

			[Preserve]
			[InputControl(offset = 0u, aliases = new string[] { "aimPose" })]
			public UnityEngine.XR.OpenXR.Input.PoseControl pointer { get; private set; }

			[Preserve]
			[InputControl(offset = 26u)]
			public new ButtonControl isTracked { get; private set; }

			[Preserve]
			[InputControl(offset = 28u)]
			public new IntegerControl trackingState { get; private set; }

			[Preserve]
			[InputControl(offset = 32u, aliases = new string[] { "gripPosition" })]
			public new Vector3Control devicePosition { get; private set; }

			[Preserve]
			[InputControl(offset = 44u, aliases = new string[] { "deviceOrientation", "gripRotation", "gripOrientation" })]
			public new QuaternionControl deviceRotation { get; private set; }

			[Preserve]
			[InputControl(offset = 92u)]
			public Vector3Control pointerPosition { get; private set; }

			[Preserve]
			[InputControl(offset = 104u, aliases = new string[] { "pointerOrientation" })]
			public QuaternionControl pointerRotation { get; private set; }

			protected override void FinishSetup()
			{
			}

			public HPMixedRealityController()
				: base()
			{
			}
		}

		internal const string featureId = "com.microsoft.openxr.feature.interaction.hpmixedrealitycontroller";

		private const string requestedExtensions = "XR_EXT_hp_mixed_reality_controller";

		private const string kDeviceLocalizedName = "HP Reverb G2 Controller OpenXR";

		private const string kDeviceDisplayName = "HP Reverb G2 Controller (OpenXR)";

		public const string profile = "/interaction_profiles/hp/mixed_reality_controller";

		public const string buttonX = "/input/x/click";

		public const string buttonY = "/input/y/click";

		public const string buttonA = "/input/a/click";

		public const string buttonB = "/input/b/click";

		public const string menu = "/input/menu/click";

		public const string squeeze = "/input/squeeze/value";

		public const string trigger = "/input/trigger/value";

		public const string thumbstick = "/input/thumbstick";

		public const string thumbstickClick = "/input/thumbstick/click";

		public const string grip = "/input/grip/pose";

		public const string aim = "/input/aim/pose";

		public const string haptic = "/output/haptic";

		protected override void RegisterDeviceLayout()
		{
		}

		protected override void UnregisterDeviceLayout()
		{
		}

		protected override void RegisterActionMapsWithRuntime()
		{
		}

		public HPMixedRealityControllerProfile()
			: base()
		{
		}
	}
}
