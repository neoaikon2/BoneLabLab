using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SphereGrip : TargetGrip
	{
		[Header("Sphere Options")]
		[Tooltip("Auto configure friction, limit, and radius")]
		public bool autoConfigure;

		[Tooltip("Overwritten by autoconfigure")]
		public float dynamicFriction = 1.7f;

		[Tooltip("Overwritten by autoconfigure")]
		public float staticFriction = 1.6f;

		private HashSet<Hand> _isJointFree;

		private float _maxRadius;

		protected override void Awake()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return default(bool);
		}

		public override void OnJointAttached(Hand hand)
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnDetachedFromHand(Hand hand)
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void OnRTSkeleFixedUpdate(Hand hand)
		{
		}

		private void UpdateTargetFromHand(Hand hand)
		{
		}

		private SimpleTransform ClampHandleInTarget(SimpleTransform handleInTarget)
		{
			return default(SimpleTransform);
		}

		private SimpleTransform SolveTargetInLimits(Hand hand, SimpleTransform newTargetInWorld, bool applyOffsetBlending = true)
		{
			return default(SimpleTransform);
		}

		public override void CheckHandPriority(HandGripPair primary, HandGripPair secondary)
		{
		}

		private void LockJoint(Hand hand)
		{
		}

		private void FreeJoint(Hand hand)
		{
		}

		public bool IsJointFree(Hand hand)
		{
			return default(bool);
		}

		public override SimpleTransform GetForcePullHandTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		private Quaternion GetTargetFlippedRotation(Hand hand)
		{
			return default(Quaternion);
		}

		public override SimpleTransform GetNeutralTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public override SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		public override float GetSwingLimit(Hand hand)
		{
			return default(float);
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		public override ValueTuple<float, float, Vector3, Vector3> ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(ValueTuple<float, float, Vector3, Vector3>);
		}

		public SphereGrip()
			: base()
		{
		}
	}
}
