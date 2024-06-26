using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		public int iterations;

		[Range(0f, 1f)]
		public float rootPin;

		public FABRIKChain[] chains;

		private bool zeroWeightApplied;

		private bool[] isRoot;

		private Vector3 rootDefaultPosition;

		public override bool IsValid(ref string message)
		{
			return false;
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

		private bool IsRoot(int index)
		{
			return false;
		}

		protected override void OnUpdate()
		{
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}
	}
}
