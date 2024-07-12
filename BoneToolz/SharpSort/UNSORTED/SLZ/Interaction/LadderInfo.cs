using UnityEngine;

namespace SLZ.Interaction
{
	public struct LadderInfo
	{
		public enum Source
		{
			LEFTHAND = 0,
			RIGHTHAND = 1,
			FEET = 2
		}

		public Source source;

		public Transform rungTransform;

		public int totalRungs;

		public int rungNumber;

		public float rungWidth;

		public float rungRadius;

		public LadderInfo(Source s, Transform rt, int tr, int tn, float rw, float rr)
		{
			source = default(Source);
			rungTransform = null;
			totalRungs = 0;
			rungNumber = 0;
			rungWidth = 0f;
			rungRadius = 0f;
		}
	}
}
