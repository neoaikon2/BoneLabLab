using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		public Transform target;

		public float tolerance;

		public int maxIterations;

		public bool useRotationLimits;

		public bool XY;

		public Bone[] bones;

		protected Vector3 lastLocalDirection;

		protected float chainLength;

		protected virtual int minBones => 0;

		protected virtual bool boneLengthCanBeZero => false;

		protected virtual bool allowCommonParent => false;

		protected virtual Vector3 localDirection => default(Vector3);

		protected float positionOffset => 0f;

		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return false;
		}

		public void AddBone(Transform bone)
		{
		}

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		public override bool IsValid(ref string message)
		{
			return false;
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected void InitiateBones()
		{
		}

		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		private bool SingularityDetected()
		{
			return false;
		}
	}
}
