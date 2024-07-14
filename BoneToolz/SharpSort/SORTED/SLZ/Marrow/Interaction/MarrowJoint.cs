using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class MarrowJoint : MonoBehaviour
	{
		[SerializeField]
		private MarrowBody _bodyA;

		[SerializeField]
		private MarrowBody _bodyB;

		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		[SerializeField]
		private MarrowEntity _entity;

		[SerializeField]
		[ReadOnly(false)]
		private ConfigurableJointInfo _defaultConfigJointInfo;

		private SimpleTransform _jointSpace;

		private readonly ConfigurableJointInfo _cjTempInfo;

		private bool _doResetConnectedAnchor;

		private bool _hasBeenEnabled;

		private DisabledJointInfo _disableJointInfo;

		private List<Action<MarrowJoint>> _jointBreakActions;

		public MarrowBody BodyA => null;

		public MarrowBody BodyB => null;

		public bool SwapBodies => false;

		public bool ConfiguredInWorld => false;

		public Quaternion StartRotation { get; private set; }

		public Quaternion ToJointSpace { get; private set; }

		public Quaternion ToJointSpaceInv { get; private set; }

		public Quaternion ToJointSpaceFromDefault { get; private set; }

		public bool IsCreatedAtRuntime { get; private set; }

		public bool HasConfigJoint => false;

		public JointDrive xDriveBase { get; set; }

		public JointDrive yDriveBase { get; set; }

		public JointDrive zDriveBase { get; set; }

		public JointDrive angularXDriveBase { get; set; }

		public JointDrive angularYZDriveBase { get; set; }

		public JointDrive slerpDriveBase { get; set; }

		private void Awake()
		{
		}

		public void CreateJoint(ConfigurableJointInfo configJointInfo, MarrowBody bodyA, MarrowBody bodyB)
		{
		}

		private void OnDestroy()
		{
		}

		public void Destroy()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}
		private UniTaskVoid JointCleanupCheckAsync()
		{
			return default(UniTaskVoid);
		}

		public bool TryGetConfigurableJoint(out ConfigurableJoint joint)
		{
			joint = null;
			return false;
		}

		internal void SetFromDefaultConfig()
		{
		}

		public void SetToDefaultConfig()
		{
		}

		private void Build(ConfigurableJointInfo info)
		{
		}

		private void ReadJointSpace()
		{
		}

		private void WriteJointSpace()
		{
		}

		private void RestoreStartRotation()
		{
		}

		internal void OnBodyEnable()
		{
		}

		internal void OnBodyDisable()
		{
		}

		public void RegisterOnBreakEvent(Action<MarrowJoint> jointBreakAction)
		{
		}

		public void UnregisterOnBreakEvent(Action<MarrowJoint> jointBreakAction)
		{
		}

		public void SetXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetYDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularYZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetSlerpDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetYDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularYZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetSlerpDriveBase(float spring, float damper, float maxForce)
		{
		}

		private JointDrive ComputeJointDrive(JointDrive driveBase, float springMult, float damperMult, float maxForceMult)
		{
			return default(JointDrive);
		}

		public void FreeAllConstraints()
		{
		}

		public JointDrive SetJointDrive(float spring, float damper, float maxForce)
		{
			return default(JointDrive);
		}

		public void SetJointLimitsAll(float linearLimit, Vector4 angularLimits)
		{
		}

		private void Validate(ConfigurableJoint cj, MarrowEntity entity)
		{
		}

		private void CopyJointInfo(ConfigurableJoint cj)
		{
		}

		public void SetEntity(MarrowEntity marrowEntity)
		{
		}
	}
}
