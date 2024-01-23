using UnityEngine;

namespace TMPro
{
	public class Compute_DT_EventArgs
	{
		public Compute_DistanceTransform_EventTypes EventType;

		public float ProgressPercentage;

		public Color[] Colors;

		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress)
			: base()
		{
		}

		public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors)
			: base()
		{
		}
	}
}
