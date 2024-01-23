using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		public Quaternion offset;

		private Quaternion defaultRotation;

		private Quaternion defaultLocalRotation;

		private Quaternion lastLocalRotation;

		private Quaternion defaultTargetLocalRotation;

		private bool initiated;

		private bool rotationChanged => false;

		public override void UpdateConstraint()
		{
		}

		public ConstraintRotationOffset()
		{
		}

		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
}
