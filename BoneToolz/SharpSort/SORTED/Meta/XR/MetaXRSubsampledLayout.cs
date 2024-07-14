using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Meta.XR
{
	public class MetaXRSubsampledLayout : OpenXRFeature
	{
		public const string extensionName = "XR_META_vulkan_swapchain_create_info";

		public const string featureId = "com.meta.openxr.feature.subsampledLayout";

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		[PreserveSig]
		private static extern void MetaSetSubsampledLayout(bool enabled);
	}
}
