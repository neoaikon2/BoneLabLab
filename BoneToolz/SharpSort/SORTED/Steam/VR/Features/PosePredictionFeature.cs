using System;
using System.Collections.Generic;
using UnityEngine.XR.OpenXR.Features;

namespace Steam.VR.Features
{
	public class PosePredictionFeature : OpenXRFeature
	{
		internal delegate int Type_xrLocateSpace(ulong space, ulong baseSpace, long time, ref IntPtr location);

		public const string featureId = "com.valve.openxr.poseprediction";

		private ulong instanceHandle;

		public long additionalPrediction;

		private Type_xrGetInstanceProcAddr xrGetInstanceProcAddrDelegate;

		private Type_xrLocateSpace xrLocateSpace;

		private IntPtr realLocateSpacePointer;

		private IntPtr realGetProcPointer;

		public bool initialized;

		private List<Delegate> callbacks;

		protected override bool OnInstanceCreate(ulong xrInstance)
		{
			return false;
		}

		protected override void OnInstanceDestroy(ulong xrInstance)
		{
		}

		private void InitializeFunctions()
		{
		}

		protected IntPtr GetCallback<T>(T functionAddr) where T : Delegate
		{
			return (IntPtr)0;
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		public int override_xrGetInstanceProcAddr(ulong instance, string name, out IntPtr function)
		{
			function = default(IntPtr);
			return 0;
		}

		public int override_xrLocateSpace(ulong space, ulong baseSpace, long time, ref IntPtr location)
		{
			return 0;
		}
	}
}
