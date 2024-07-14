using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct SoftJointLimitSpringExt
	{
		public float spring;

		public float damper;

		public SoftJointLimitSpringExt(SoftJointLimitSpring softJointLimitSpring)
		{
			spring = 0f;
			damper = 0f;
		}

		public SoftJointLimitSpring ToUnitySoftJointLimitSpring()
		{
			return default(SoftJointLimitSpring);
		}
	}
}
