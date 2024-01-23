using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		public class ReachCone
		{
			public Vector3[] tetrahedron;

			public float volume;

			public Vector3 S;

			public Vector3 B;

			public Vector3 o => default(Vector3);

			public Vector3 a => default(Vector3);

			public Vector3 b => default(Vector3);

			public Vector3 c => default(Vector3);

			public bool isValid => false;

			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			public void Calculate()
			{
			}
		}

		[Serializable]
		public class LimitPoint
		{
			public Vector3 point;

			public float tangentWeight;
		}

		[Range(0f, 180f)]
		public float twistLimit;

		[Range(0f, 3f)]
		public int smoothIterations;

		[HideInInspector]
		[SerializeField]
		public LimitPoint[] points;

		[HideInInspector]
		[SerializeField]
		public Vector3[] P;

		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		private void Start()
		{
		}

		public void ResetToDefault()
		{
		}

		public void BuildReachCones()
		{
		}

		private Vector3[] SmoothPoints()
		{
			return null;
		}

		private float GetScalar(int k)
		{
			return 0f;
		}

		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		private int GetReachCone(Vector3 L)
		{
			return 0;
		}
	}
}
