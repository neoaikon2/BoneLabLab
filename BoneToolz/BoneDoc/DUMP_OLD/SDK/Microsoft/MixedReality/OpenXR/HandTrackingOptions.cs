using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 4)]
	internal struct HandTrackingOptions
	{
		[Tooltip("The requested motion range for this hand.")]
		[SerializeField]
		private HandJointsMotionRange motionRange;

		public HandJointsMotionRange MotionRange
		{
			get
			{
				return default(HandJointsMotionRange);
			}
			set
			{
			}
		}
	}
}
