using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 56)]
	internal struct NativeAnchor
	{
		public Guid id;

		public Pose pose;

		public TrackingState trackingState;

		public IntPtr nativePtr;
	}
}
