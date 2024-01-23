using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public abstract class IKSolver
	{
		[Serializable]
		public class Point
		{
			public Transform transform;

			[Range(0f, 1f)]
			public float weight;

			public Vector3 solverPosition;

			public Quaternion solverRotation;

			public Vector3 defaultLocalPosition;

			public Quaternion defaultLocalRotation;

			public void StoreDefaultLocalState()
			{
			}

			public void FixTransform()
			{
			}

			public void UpdateSolverPosition()
			{
			}

			public void UpdateSolverLocalPosition()
			{
			}

			public void UpdateSolverState()
			{
			}

			public void UpdateSolverLocalState()
			{
			}
		}

		[Serializable]
		public class Bone : Point
		{
			public float length;

			public float sqrMag;

			public Vector3 axis;

			private RotationLimit _rotationLimit;

			private bool isLimited;

			public RotationLimit rotationLimit
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			public void SetToSolverPosition()
			{
			}

			public Bone()
			{
			}

			public Bone(Transform transform)
			{
			}

			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		public class Node : Point
		{
			public float length;

			public float effectorPositionWeight;

			public float effectorRotationWeight;

			public Vector3 offset;

			public Node()
			{
			}

			public Node(Transform transform)
			{
			}

			public Node(Transform transform, float weight)
			{
			}
		}

		public delegate void UpdateDelegate();

		public delegate void IterationDelegate(int i);

		[HideInInspector]
		public Vector3 IKPosition;

		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		public UpdateDelegate OnPreInitiate;

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnPreUpdate;

		public UpdateDelegate OnPostUpdate;

		protected bool firstInitiation;

		[HideInInspector]
		[SerializeField]
		protected Transform root;

		public bool initiated { get; private set; }

		public bool IsValid()
		{
			return false;
		}

		public abstract bool IsValid(ref string message);

		public void Initiate(Transform root)
		{
		}

		public void Update()
		{
		}

		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		public void SetIKPosition(Vector3 position)
		{
		}

		public float GetIKPositionWeight()
		{
			return 0f;
		}

		public void SetIKPositionWeight(float weight)
		{
		}

		public Transform GetRoot()
		{
			return null;
		}

		public abstract Point[] GetPoints();

		public abstract Point GetPoint(Transform transform);

		public abstract void FixTransforms();

		public abstract void StoreDefaultLocalState();

		protected abstract void OnInitiate();

		protected abstract void OnUpdate();

		protected void LogWarning(string message)
		{
		}

		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		public static bool HierarchyIsValid(Bone[] bones)
		{
			return false;
		}

		protected static float PreSolveBones(ref Bone[] bones)
		{
			return 0f;
		}
	}
}
