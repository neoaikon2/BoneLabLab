using System;
using System.ComponentModel;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class TrackerSettings
	{
		[Serializable]
		public enum Type
		{
			Bounds = 0,
			Box = 1,
			Sphere = 2,
			Capsule = 3
		}

		[Serializable]
		public enum Direction
		{
			[Description("X-Axis")]
			XAxis = 0,
			[Description("Y-Axis")]
			YAxis = 1,
			[Description("Z-Axis")]
			ZAxis = 2
		}

		[SerializeField]
		public bool isActive;

		[SerializeField]
		public int layer;

		[SerializeField]
		public Type type;

		[SerializeField]
		public Vector3 center;

		[SerializeField]
		public Vector3 size;

		[SerializeField]
		public float radius;

		[SerializeField]
		public float height;

		[SerializeField]
		public Direction direction;
	}
}
