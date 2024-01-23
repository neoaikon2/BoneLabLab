using UnityEngine;

namespace RootMotion.FinalIK
{
	public class FingerRig : SolverManager
	{
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		public Finger[] fingers;

		public bool initiated { get; private set; }

		public bool IsValid(ref string errorMessage)
		{
			return false;
		}

		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target = null)
		{
		}

		public void RemoveFinger(int index)
		{
		}

		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		protected override void InitiateSolver()
		{
		}

		public void UpdateFingerSolvers()
		{
		}

		public void FixFingerTransforms()
		{
		}

		public void StoreDefaultLocalState()
		{
		}

		protected override void UpdateSolver()
		{
		}

		protected override void FixTransforms()
		{
		}
	}
}
