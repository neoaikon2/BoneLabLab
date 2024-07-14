using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

namespace SLZ.Marrow.Interaction
{
	[RequireComponent(typeof(SplineContainer))]
	public class PolyLine : MonoBehaviour
	{
		private static readonly float LINEAR_LOOKUP_MIN_DIST;

		[SerializeField]
		public PolyLineData lineData;

		private PolyLineVert[] _polyVerts;

		private float _segmentDistance;

		private float _totalDistance;

		private bool _isBaked;

		[SerializeField]
		private SplineContainer _splineContainer;

		public SplineContainer SplineContainer => null;

		private void Awake()
		{
		}

		public int GetNearestPoint(float3 worldPos, out float3 position, out float3 tangent, out float3 normal)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		public int GetPointAtLinearDistance(float3 worldPos, float distance, out float3 position, out float3 tangent, out float3 normal, int startIndex = 0)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		public int GetNearestPointFromIndex(float3 worldPos, out float3 position, out float3 tangent, out float3 normal, int startIndex = 0)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
			return 0;
		}

		public bool IsACappedIndex(int index)
		{
			return false;
		}

		public void GetPointAtIndex(int index, out float3 position, out float3 tangent, out float3 normal)
		{
			position = default(float3);
			tangent = default(float3);
			normal = default(float3);
		}

		private int GetNearestVertWithinRange(float3 localPos, int start, int end, out int interval, uint intervalDivision = 1u)
		{
			interval = default(int);
			return 0;
		}

		public static int Mod(int i, int max)
		{
			return 0;
		}

		private void Reset()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawSplineGizmo()
		{
		}
	}
}
