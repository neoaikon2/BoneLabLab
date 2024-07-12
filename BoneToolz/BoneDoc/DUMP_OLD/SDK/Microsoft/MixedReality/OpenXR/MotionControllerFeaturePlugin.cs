using System;

namespace Microsoft.MixedReality.OpenXR
{
	[NativeLibToken(NativeLibToken = NativeLibToken.Controller)]
	internal class MotionControllerFeaturePlugin : OpenXRFeaturePlugin<MotionControllerFeaturePlugin>
	{
		internal const string featureId = "com.microsoft.openxr.feature.controller";

		private const string requestedExtensions = "XR_MSFT_controller_model XR_FB_render_model";

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		public MotionControllerFeaturePlugin()
			: base()
		{
		}
	}
}
