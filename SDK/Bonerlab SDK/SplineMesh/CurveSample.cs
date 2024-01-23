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

		public CurveSample(Vector3 _location, Vector3 _tangent, Vector3 _up, Vector2 _scale, float _roll, float _distanceInCurve, float _timeInCurve, CubicBezierCurve _curve)
		{
			location = _location;
			tangent = _tangent;
			up = _up;
			scale = _scale;
			roll = _roll;
			distanceInCurve = _distanceInCurve;
			timeInCurve = _timeInCurve;
			curve = _curve;
			rotation = Quaternion.identity;
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
