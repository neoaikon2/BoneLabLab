using System;
using UnityEngine;

namespace SLZ.Interaction
{
	[Serializable]
	public class VirtualControllerSettings
	{
		[Tooltip("Primary to Secondary swing weight (Blends into per-hand swing weight)")]
		[Range(0f, 1f)]
		public float lookRotationWeight;

		[Tooltip("Per-hand blend twist rotation")]
		[Range(0f, 1f)]
		public float handTwistWeight;

		[Range(0f, 1f)]
		[Tooltip("Per-hand blend swing rotation")]
		public float handSwingWeight;

		[Tooltip("Per-hand blend position")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Range(0f, 90f)]
		[Tooltip("Joint swing limits")]
		public float jointSwingLimit;

		[Tooltip("Joint twist limits")]
		[Range(0f, 90f)]
		public float jointTwistLimit;

		[Tooltip("Swap slip rotation to primary grip")]
		public bool autoTargetUpdatePrimary;

		[Tooltip("Dynamic weights based on hand to hand distance")]
		public bool dynamicHandDistanceWeights;
	}
}
