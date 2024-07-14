using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class DisabledJointInfo
	{
		private bool _hasBeenCopied;

		private Rigidbody _attachedBody;

		private ConfigurableJointMotion _xMotion;

		private ConfigurableJointMotion _yMotion;

		private ConfigurableJointMotion _zMotion;

		private ConfigurableJointMotion _angXMotion;

		private ConfigurableJointMotion _angYMotion;

		private ConfigurableJointMotion _angZMotion;

		private JointDriveExt _xDrive;

		private JointDriveExt _yDrive;

		private JointDriveExt _zDrive;

		private JointDriveExt _angXDrive;

		private JointDriveExt _angYZDrive;

		private JointDriveExt _slerpDrive;

		public void CopyFrom(ConfigurableJoint j)
		{
		}

		public void CopyTo(ConfigurableJoint j)
		{
		}

		public void Clear(ConfigurableJoint j)
		{
		}
	}
}
