using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		public Transform transform;

		public Vector3 axis;

		public Vector3 poleAxis;

		public Vector3 polePosition;

		[Range(0f, 1f)]
		public float poleWeight;

		public Transform poleTarget;

		[Range(0f, 1f)]
		public float clampWeight;

		[Range(0f, 2f)]
		public int clampSmoothing;

		public IterationDelegate OnPreIteration;

		private float step;

		private Vector3 clampedIKPosition;

		private RotationLimit transformLimit;

		private Transform lastTransform;

		public Vector3 transformAxis => default(Vector3);

		public Vector3 transformPoleAxis => default(Vector3);

		protected override int minBones => 0;

		protected override Vector3 localDirection => default(Vector3);

		public float GetAngle()
		{
			return 0f;
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void Solve()
		{
		}

		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}
	}
}
