using UnityEngine.XR.OpenXR.Features;

namespace Steam.VR.Features
{
	public class RefreshRateFeature : OpenXRFeature
	{
		internal delegate int Type_xrGetDisplayRefreshRateFB(ulong session, out float displayRefreshRate);

		public const string featureId = "com.valve.openxr.refreshrate";

		public bool initialized;

		private ulong instanceHandle;

		private ulong sessionHandle;

		private Type_xrGetInstanceProcAddr xrGetInstanceProcAddrDelegate;

		private Type_xrGetDisplayRefreshRateFB xrGetDisplayRefreshRateFB;

		public OnRefreshRateFeatureAvailableDelegate OnRefreshRateFeatureAvailable;

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected override void OnSessionBegin(ulong xrSession)
		{
		}

		protected override void OnSessionDestroy(ulong xrSession)
		{
		}

		protected override void OnSessionEnd(ulong xrSession)
		{
		}

		private void InitializeFunctions()
		{
		}

		public float GetRefreshRate()
		{
			return 0f;
		}
	}
}
