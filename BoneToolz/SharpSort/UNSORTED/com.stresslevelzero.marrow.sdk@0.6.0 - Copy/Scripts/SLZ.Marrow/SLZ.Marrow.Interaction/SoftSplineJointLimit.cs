using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public struct SoftSplineJointLimit
	{
		[SerializeField]
		public float limit;

		[SerializeField]
		public float bounciness;

		[SerializeField]
		public float contactDistance;

		public SoftSplineJointLimit(float limit, float bounciness, float contactDistance)
		{
			this.limit = 0f;
			this.bounciness = 0f;
			this.contactDistance = 0f;
		}
	}
}
