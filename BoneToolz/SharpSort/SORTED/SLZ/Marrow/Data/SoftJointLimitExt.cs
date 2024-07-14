using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct SoftJointLimitExt
	{
		public float limit;

		public float bounciness;

		public float contactDistance;

		public SoftJointLimitExt(SoftJointLimit softJointLimit)
		{
			limit = 0f;
			bounciness = 0f;
			contactDistance = 0f;
		}

		public SoftJointLimit ToUnitySoftJointLimit()
		{
			return default(SoftJointLimit);
		}
	}
}
