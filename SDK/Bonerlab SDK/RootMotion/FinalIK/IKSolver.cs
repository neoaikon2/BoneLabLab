using System;
using System.Runtime.CompilerServices;
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

			public Point()
				: base()
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
			}

			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			public Bone()
				: base()
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
				: base()
			{
			}

			public Node(Transform transform)
				: this()
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

		[SerializeField]
		[HideInInspector]
		protected Transform root;

		public bool initiated { get; private set; }

		public abstract bool IsValid(string message);

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
			return default(float);
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
			return default(bool);
		}

		public IKSolver()
			: base()
		{
		}
	}
}
