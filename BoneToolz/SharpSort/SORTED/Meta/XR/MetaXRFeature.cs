using System;
using UnityEngine.XR.OpenXR.Features;

namespace Meta.XR
{
	public class MetaXRFeature : OpenXRFeature
	{
		public const string featureId = "com.meta.openxr.feature.metaxr";

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		protected override void OnSessionCreate(ulong xrSession)
		{
		}

		protected override void OnAppSpaceChange(ulong xrSpace)
		{
		}

		protected override void OnSessionStateChange(int oldState, int newState)
		{
		}

		protected override void OnSessionBegin(ulong xrSession)
		{
		}

		protected override void OnSessionEnd(ulong xrSession)
		{
		}

		protected override void OnSessionExiting(ulong xrSession)
		{
		}

		protected override void OnSessionDestroy(ulong xrSession)
		{
		}
	}
}
