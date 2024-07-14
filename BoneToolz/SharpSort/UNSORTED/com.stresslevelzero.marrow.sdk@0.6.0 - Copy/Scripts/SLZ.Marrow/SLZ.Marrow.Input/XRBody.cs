using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class XRBody : XRDevice
	{
		public virtual Vector3[] BonePositions { get; protected set; }

		public virtual Quaternion[] BoneRotations { get; protected set; }

		public bool HasPermission { get; protected set; }

		public float Confidence { get; protected set; }

		public int SkeletonChangedCount { get; protected set; }

		public virtual bool SuggestCalibrationHeight(float height)
		{
			return false;
		}

		public virtual bool ResetBodyTrackingCalibration()
		{
			return false;
		}
	}
}
