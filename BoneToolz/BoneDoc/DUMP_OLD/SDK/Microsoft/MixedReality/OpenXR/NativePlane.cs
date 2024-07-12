using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 60)]
	internal struct NativePlane
	{
		public Guid id;

		public Vector3 position;

		public Quaternion rotation;

		public TrackingState trackingState;

		public Vector2 size;

		public XrSceneObjectTypeMSFT type;
	}
}
