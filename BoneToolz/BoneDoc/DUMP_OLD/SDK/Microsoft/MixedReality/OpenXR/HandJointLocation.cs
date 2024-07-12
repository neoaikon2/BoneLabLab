using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 36)]
	public struct HandJointLocation
	{
		private readonly byte isTracked;

		public bool IsTracked
		{
			get
			{
				return default(bool);
			}
		}

		public Pose Pose { get; }

		public float Radius { get; }
	}
}
