using UnityEngine;

namespace RootMotion
{
	public class SolverManager : MonoBehaviour
	{
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		public Animator animator;

		private bool updateFrame;

		private bool skipSolverUpdate;

		private bool animatePhysics => false;

		protected virtual void InitiateSolver()
		{
		}

		protected virtual void UpdateSolver()
		{
		}

		protected virtual void FixTransforms()
		{
		}

		public void Initiate()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
