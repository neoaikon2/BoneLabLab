using System.Runtime.CompilerServices;
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
			return default(bool);
		}

		public virtual bool ResetBodyTrackingCalibration()
		{
			return default(bool);
		}

		public XRBody()
			: base()
		{
		}
	}
}
