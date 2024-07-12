using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 52)]
	internal struct NativeReprojectionSettings
	{
		public ReprojectionMode reprojectionMode;

		public Vector3 reprojectionPlaneOverridePosition;

		public byte reprojectionPlaneOverridePositionHasValue;

		public Vector3 reprojectionPlaneOverrideNormal;

		public byte reprojectionPlaneOverrideNormalHasValue;

		public Vector3 reprojectionPlaneOverrideVelocity;

		public byte reprojectionPlaneOverrideVelocityHasValue;

		internal NativeReprojectionSettings(ReprojectionSettings settings)
		{
			this.reprojectionPlaneOverrideVelocityHasValue = default(byte);
			this.reprojectionPlaneOverrideVelocity = default(Vector3);
			this.reprojectionPlaneOverrideNormalHasValue = default(byte);
			this.reprojectionPlaneOverrideNormal = default(Vector3);
			this.reprojectionPlaneOverridePositionHasValue = default(byte);
			this.reprojectionPlaneOverridePosition = default(Vector3);
			this.reprojectionMode = default(ReprojectionMode);
		}
	}
}
