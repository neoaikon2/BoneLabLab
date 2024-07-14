using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public struct JointDriveExt
	{
		public float positionSpring;

		public float positionDamper;

		public float maximumForce;

		public JointDriveExt(JointDrive drive)
		{
			positionSpring = 0f;
			positionDamper = 0f;
			maximumForce = 0f;
		}

		public JointDrive ToUnityJointDrive()
		{
			return default(JointDrive);
		}
	}
}
