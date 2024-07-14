using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Meta.XR
{
	public class MetaXRFoveationFeature : OpenXRFeature
	{
		public const string extensionList = "XR_FB_foveation XR_FB_foveation_configuration XR_FB_foveation_vulkan ";

		public const string featureId = "com.meta.openxr.feature.foveation";

		private static ulong _xrSession;

		private static uint _foveatedRenderingLevel;

		private static uint _useDynamicFoveation;

		public static OVRManager.FoveatedRenderingLevel foveatedRenderingLevel
		{
			get
			{
				return default(OVRManager.FoveatedRenderingLevel);
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

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		[PreserveSig]
		private static extern void FBSetFoveationLevel(ulong session, uint level, float verticalOffset, uint dynamic);

		[PreserveSig]
		private static extern void FBGetFoveationLevel(out uint level);

		[PreserveSig]
		private static extern void FBGetFoveationDynamic(out uint dynamic);
	}
}
