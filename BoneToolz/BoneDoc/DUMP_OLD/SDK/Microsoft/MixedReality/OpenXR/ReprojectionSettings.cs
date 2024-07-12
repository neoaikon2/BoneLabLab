using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	public struct ReprojectionSettings
	{
		private ReprojectionMode? m_reprojectionMode;

		public Vector3? ReprojectionPlaneOverridePosition;

		public Vector3? ReprojectionPlaneOverrideNormal;

		public Vector3? ReprojectionPlaneOverrideVelocity;

		public ReprojectionMode ReprojectionMode
		{
			get
			{
				return default(ReprojectionMode);
			}
			set
			{
			}
		}
	}
}
