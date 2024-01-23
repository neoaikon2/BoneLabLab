using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		[Range(0f, 1f)]
		public float IKRotationWeight;

		public Quaternion IKRotation;

		public Point chest;

		public Point shoulder;

		public Point upperArm;

		public Point forearm;

		public Point hand;

		public bool isLeft;

		public IKSolverVR.Arm arm;

		private Vector3[] positions;

		private Quaternion[] rotations;

		public override bool IsValid(ref string message)
		{
			return false;
		}

		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
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

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
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

		private void Read()
		{
		}

		private void Write()
		{
		}
	}
}
