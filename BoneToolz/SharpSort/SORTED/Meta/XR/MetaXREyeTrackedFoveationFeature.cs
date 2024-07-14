using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Meta.XR
{
	public class MetaXREyeTrackedFoveationFeature : OpenXRFeature
	{
		public const string extensionName = "XR_META_foveation_eye_tracked XR_FB_eye_tracking_social XR_META_vulkan_swapchain_create_info";

		public const string featureId = "com.meta.openxr.feature.eyetrackedfoveation";

		private static ulong _xrSession;

		private static bool _eyeTrackedFoveatedRenderingEnabled;

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

		public static bool eyeTrackedFoveatedRenderingSupported => false;

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		[PreserveSig]
		private static extern void MetaSetFoveationEyeTracked(ulong session, bool isEyeTracked);

		[PreserveSig]
		private static extern void MetaGetFoveationEyeTracked(out bool isEyeTracked);

		[PreserveSig]
		private static extern void MetaGetEyeTrackedFoveationSupported(out bool supported);
	}
}
