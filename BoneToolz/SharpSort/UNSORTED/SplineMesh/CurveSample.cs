using System;
using UnityEngine;

namespace SplineMesh
{
	[Serializable]
	public struct CurveSample
	{
		public readonly Vector3 location;

		public readonly Vector3 tangent;

		public readonly Vector3 up;

		public readonly Vector2 scale;

		public readonly float roll;

		public readonly float distanceInCurve;

		public readonly float timeInCurve;

		public readonly CubicBezierCurve curve;

		private Quaternion rotation;

		public Quaternion Rotation => default(Quaternion);

		public CurveSample(Vector3 location, Vector3 tangent, Vector3 up, Vector2 scale, float roll, float distanceInCurve, float timeInCurve, CubicBezierCurve curve)
		{
			this.location = default(Vector3);
			this.tangent = default(Vector3);
			this.up = default(Vector3);
			this.scale = default(Vector2);
			this.roll = 0f;
			this.distanceInCurve = 0f;
			this.timeInCurve = 0f;
			this.curve = null;
			rotation = default(Quaternion);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CurveSample cs1, CurveSample cs2)
		{
			return false;
		}

		public static bool operator !=(CurveSample cs1, CurveSample cs2)
		{
			return false;
		}

		public static CurveSample Lerp(CurveSample a, CurveSample b, float t)
		{
			return default(CurveSample);
		}

		public MeshVertex GetBent(MeshVertex vert)
		{
			return null;
		}
	}
}
