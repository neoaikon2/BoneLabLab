using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		public Vector3 offset;

		private Vector3 defaultLocalPosition;

		private Vector3 lastLocalPosition;

		private bool initiated;

		private bool positionChanged => false;

		public override void UpdateConstraint()
		{
		}

		public ConstraintPositionOffset()
		{
		}

		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
}
