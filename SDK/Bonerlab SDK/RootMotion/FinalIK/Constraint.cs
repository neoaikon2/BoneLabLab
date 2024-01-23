using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public abstract class Constraint
	{
		public Transform transform;

		public float weight;

		public bool isValid => false;

		public abstract void UpdateConstraint();
	}
}
