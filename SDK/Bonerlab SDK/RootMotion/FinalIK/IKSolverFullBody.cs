using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		[Range(0f, 10f)]
		public int iterations;

		public FBIKChain[] chain;

		public IKEffector[] effectors;

		public IKMappingSpine spineMapping;

		public IKMappingBone[] boneMappings;

		public IKMappingLimb[] limbMappings;

		public bool FABRIKPass;

		public UpdateDelegate OnPreRead;

		public UpdateDelegate OnPreSolve;

		public IterationDelegate OnPreIteration;

		public IterationDelegate OnPostIteration;

		public UpdateDelegate OnPreBend;

		public UpdateDelegate OnPostSolve;

		public UpdateDelegate OnStoreDefaultLocalState;

		public UpdateDelegate OnFixTransforms;

		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		public int GetChainIndex(Transform transform)
		{
			return 0;
		}

		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
			chainIndex = default(int);
			nodeIndex = default(int);
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

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

		protected override void OnUpdate()
		{
		}

		protected virtual void ReadPose()
		{
		}

		protected virtual void Solve()
		{
		}

		protected virtual void ApplyBendConstraints()
		{
		}

		protected virtual void WritePose()
		{
		}
	}
}
