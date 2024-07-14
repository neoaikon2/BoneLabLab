using System;
using System.Collections.Generic;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	[Serializable]
	public class SubBehaviourSensors : SubBehaviourBase
	{
		public struct TargetInfo
		{
			public float threat;

			public float timeAdded;

			public ulong id;

			public TargetInfo(float threat, float timeAdded, ulong id)
			{
				this.threat = 0f;
				this.timeAdded = 0f;
				this.id = 0uL;
			}
		}

		[Header("Vision")]
		public LayerMask blockVisionRaycast;

		public float visionFov;

		[Header("Touch")]
		public MuscleCollisionBroadcasterSensor[] forceSensorsFeet;

		public MuscleCollisionBroadcasterSensor[] forceSensorsHands;

		public MuscleCollisionBroadcasterSensor[] forceSensorsBody;

		public float additionalMass;

		public float footSupported;

		public float handSupported;

		public float bodySupported;

		[Header("Targets")]
		public TriggerRefProxy target;

		public TriggerRefProxy selfTrp;

		private float _totalMass;

		private SphereCollider _visionSphere;

		private Vector3 _hipsForward;

		private Vector3 _hipsUp;

		private List<TriggerRefProxy> _trpList;

		private Dictionary<TriggerRefProxy, TargetInfo> _trpTargets;

		private float _getVelocityDue;

		private Vector3 _storedComVel;

		private float _getCenterOfMassDue;

		private Vector3 _storedCom;

		private float _getFeetCentroidDue;

		private Vector3 _storedSum;

		public Vector3 GroundVelocity { get; private set; }

		public float totalSupported { get; private set; }

		public bool isGrounded { get; private set; }

		public float visionFovCos { get; private set; }

		public float TotalMass => 0f;

		public List<TriggerRefProxy> TrpList => null;

		public void Initiate(BehaviourBase b)
		{
		}

		public void Respawn()
		{
		}

		public bool AddThreat(TriggerRefProxy trp, float threat)
		{
			return false;
		}

		public bool RemoveTarget(TriggerRefProxy trp)
		{
			return false;
		}

		public void ClearTargets()
		{
		}

		public void CheckTarget()
		{
		}

		public void SetAgro(TriggerRefProxy trp)
		{
		}

		public void SetEngaged(TriggerRefProxy trp)
		{
		}

		private ulong GetId(TriggerRefProxy trp)
		{
			return 0uL;
		}

		private float InitialThreat(TriggerRefProxy trp)
		{
			return 0f;
		}

		public void UpdateGrounded(float deltaT)
		{
		}

		public void ReadPoses()
		{
		}

		public void SetVisionSphere(float radius, bool enabled = true, bool noOffset = false)
		{
		}

		public void SetEnableAnimatorSphere(float radius, bool enabled = true)
		{
		}

		public Vector3 GetVelocity(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public Vector3 GetCenterOfMass(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public Vector3 GetFeetCentroid(bool forceUpdate = false)
		{
			return default(Vector3);
		}

		public float GetBalanceTangent()
		{
			return 0f;
		}

		public float GetBalanceTangent(out Vector3 worldDirection)
		{
			worldDirection = default(Vector3);
			return 0f;
		}

		public bool IsProne()
		{
			return false;
		}

		public float ProneFloat()
		{
			return 0f;
		}

		public Vector3 HipsUpWorld()
		{
			return default(Vector3);
		}

		public Vector3 HipsForwardWorld()
		{
			return default(Vector3);
		}
	}
}
