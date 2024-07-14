using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public class TransformHistory
	{
		public RingBuffer<TemporalTransform> transforms;

		public RingBuffer<TemporalTransform> extrapTransforms;

		public void AddTransform(in TemporalTransform transform, double toTime)
		{
		}

		private float GetBlendPercentage(in double fromTime, in double toTime, in double atTime)
		{
			return 0f;
		}

		public void CopyPoseAtTime(double atTime, in Transform transform)
		{
		}

		private bool GetPosesIndexAtTime(in double atTime, out int atIndex)
		{
			atIndex = default(int);
			return false;
		}
	}
}
