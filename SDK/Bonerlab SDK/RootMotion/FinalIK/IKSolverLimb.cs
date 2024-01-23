using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		public enum BendModifier
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}

		[Serializable]
		public struct AxisDirection
		{
			public Vector3 direction;

			public Vector3 axis;

			public float dot;

			public AxisDirection(Vector3 _direction, Vector3 _axis)
			{
				direction = _direction;
				axis = _axis;
				dot = 0;
			}
		}

		public AvatarIKGoal goal;

		public BendModifier bendModifier;

		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Range(0f, 1f)]
		public float bendModifierWeight;

		public Transform bendGoal;

		private bool maintainBendFor1Frame;

		private bool maintainRotationFor1Frame;

		private Quaternion defaultRootRotation;

		private Quaternion parentDefaultRotation;

		private Quaternion bone3RotationBeforeSolve;

		private Quaternion maintainRotation;

		private Quaternion bone3DefaultRotation;

		private Vector3 _bendNormal;

		private Vector3 animationNormal;

		private AxisDirection[] axisDirectionsLeft;

		private AxisDirection[] axisDirectionsRight;

		private AxisDirection[] axisDirections => null;

		public void MaintainRotation()
		{
		}

		public void MaintainBend()
		{
		}

		protected override void OnInitiateVirtual()
		{
		}

		protected override void OnUpdateVirtual()
		{
		}

		protected override void OnPostSolveVirtual()
		{
		}

		public IKSolverLimb()
		{
		}

		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
}
