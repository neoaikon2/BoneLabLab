using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 136)]
	internal struct NativeGesturePoseData
	{
		public ulong gestureTime;

		public Pose headPose;

		public NativeSpaceLocationFlags headPoseFlags;

		public Pose eyeGazePose;

		public NativeSpaceLocationFlags eyeGazePoseFlags;

		public Pose handAimPose;

		public NativeSpaceLocationFlags handAimPoseFlags;

		public Pose handGripPose;

		public NativeSpaceLocationFlags handGripPoseFlags;
	}
}
