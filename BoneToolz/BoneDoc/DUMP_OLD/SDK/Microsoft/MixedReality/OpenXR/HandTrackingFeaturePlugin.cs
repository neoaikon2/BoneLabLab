using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;
using UnityEngine.XR.OpenXR.Input;

namespace Microsoft.MixedReality.OpenXR
{
	[NativeLibToken(NativeLibToken = NativeLibToken.HandTracking)]
	internal class HandTrackingFeaturePlugin : OpenXRFeaturePlugin<HandTrackingFeaturePlugin>
	{
		internal enum QuestHandTracking
		{
			v1 = 0,
			v2 = 1
		}

		[Preserve]
		[InputControlLayout(displayName = "Hand Tracking (OpenXR)", commonUsages = new string[] { "LeftHand", "RightHand" }, isGenericTypeOfDevice = true)]
		public class OpenXRHandTracking : OpenXRDevice
		{
			[InputControl]
			public ButtonControl isTracked { get; private set; }

			[InputControl]
			public IntegerControl trackingState { get; private set; }

			protected override void FinishSetup()
			{
			}

			public OpenXRHandTracking()
				: base()
			{
			}
		}

		internal const string featureId = "com.microsoft.openxr.feature.handtracking";

		internal const string featureName = "Hand Tracking";

		private const string requestedExtensions = "XR_EXT_hand_tracking XR_EXT_hand_joints_motion_range XR_MSFT_hand_tracking_mesh";

		[SerializeField]
		private HandTrackingOptions leftHandTrackingOptions;

		[SerializeField]
		private HandTrackingOptions rightHandTrackingOptions;

		[SerializeField]
		[Tooltip("Allows for toggling specific versions of the Quest hand tracking runtime.")]
		[LabelWidth(200f)]
		[DocURL("https://developer.oculus.com/blog/presence-platforms-hand-tracking-api-gets-an-upgrade/")]
		private QuestHandTracking questHandTrackingMode;

		private HandTrackingSubsystemController m_handTrackingSubsystemController;

		internal QuestHandTracking QuestHandTrackingMode
		{
			get
			{
				return default(QuestHandTracking);
			}
		}

		private HandTrackingFeaturePlugin()
			: base()
		{
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		protected override void OnSubsystemStart()
		{
		}

		protected override bool OnInstanceCreate(ulong instance)
		{
			return default(bool);
		}

		private static void RegisterDeviceLayout()
		{
		}

		private static void UnregisterDeviceLayout()
		{
		}
	}
}
