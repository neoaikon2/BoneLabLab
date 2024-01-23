using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class CylinderGrip : TargetGrip
	{
		[Tooltip("Friction while hand is moving")]
		[Header("Cylinder Options")]
		public float dynamicFriction = 0.6f;

		[Tooltip("Friction while hand is static")]
		public float staticFriction = 0.7f;

		[Tooltip("Meters plus and minus")]
		public float limit = .25f;

		public bool hasCapA = true;

		public bool hasCapB = true;

		public bool ignoreFlipOnZ;

		public float rotationalFrictionMult = 1.0f;

		[Tooltip("Once grabbed, aspect ratio (X:1) defines how much object wants to stay in sweetspot due to oval shape")]
		public float aspectRatio = 1.0f;

		public bool variableRadius = false;

		[Tooltip("Used to vary radius across a cylinder grab (Example: Baseball Bat). Defaults to 1 for no effect")]
		public AnimationCurve RadiusCurve = new AnimationCurve(
			new Keyframe[] {
				new Keyframe(-180, -30),
				new Keyframe(-50, -30),
				new Keyframe(0, 0),
				new Keyframe(50, 30),
				new Keyframe(180, 30),
			});

		private float handWidth;

		private float _handPaddingOffset;

		private readonly HashSet<Hand> _isJointPositionFree;

		private readonly HashSet<Hand> _isJointRotationFree;

		private float _maxRadius;

		private readonly Dictionary<Hand, CylinderConstraintJoint> _constraintJoints;

		protected override void Awake()
		{
		}

		public override float GetTwistLimit(Hand hand)
		{
			return 0f;
		}

		public SimpleTransform SolveStaticFriction(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void SolveOffsetBlending(Hand hand, ref float posInHas, ref float rotInHas)
		{
		}

		private void ClampToTargetLimits(Hand hand, Quaternion toHas, ref float posInHas, ref float rotInHas)
		{
		}

		public SimpleTransform ProcessesLargeRadiusOffset(Hand hand, SimpleTransform newTargetInWorld)
		{
			return default(SimpleTransform);
		}

		private SimpleTransform SolveTargetInLimits(Hand hand, SimpleTransform newTargetInWorld, bool applyOffsetBlending = true, bool useLookAtRotation = true)
		{
			return default(SimpleTransform);
		}

		public bool IsJointFree(Hand hand)
		{
			return false;
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override SimpleTransform GetNeutralTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public override bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return false;
		}

		private void LockJoint(Hand hand)
		{
		}

		private void FreeJoint(Hand hand)
		{
		}

		private Quaternion GetTargetFlippedRotation(Hand hand)
		{
			return default(Quaternion);
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

		public override void OnRTSkeleFixedUpdate(Hand hand)
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void CheckHandPriority(ref HandGripPair primary, ref HandGripPair secondary)
		{
		}

		public bool IsHandYieldInVc(Hand hand)
		{
			return false;
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		private void UpdateConstraintJointAnchor(Hand hand, Vector3 anchor)
		{
		}

		private void UpdateConstraintJointConnectedAnchor(Hand hand, Vector3 connectedAnchor)
		{
		}

		private void CreateConstraintJoint(Hand hand)
		{
		}

		private void DestroyConstraintJoint(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return 0f;
		}

		private Vector3 GetPointOnPerimeter(float radius, float theta, float limit, float perc)
		{
			return default(Vector3);
		}

		private void DrawCircleGizmo(float radius)
		{
		}

		private void DrawCylinderGizmo(float length, float radius, float angle)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
