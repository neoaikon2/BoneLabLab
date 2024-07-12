using System;
using System.Runtime.InteropServices;
using SLZ.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class TargetGrip : Grip
	{
		[Tooltip("Degrees plus/minus. Defaults to 180")]
		[Header("Target Grip")]
		[Range(0f, 180f)]
		public float rotationLimit = 180.0f;

		[Range(0f, 180f)]
		public float rotationPriorityBuffer = 20.0f;

		[Header("Flippable Hand Pose")]
		[Tooltip("Will switch to this handpose when the primary axis is flipped on hover")]
		public HandPose handPoseOnFlippedPrimaryAxis;

		[Tooltip("Will update the target transform when the primary axis is flipped on hover")]
		public bool targetFlipOnPrimaryAxis = false;

		[Tooltip("Will update the target transform when the primary axis is flipped on hover")]
		public bool targetFlipOnTertiaryAxis = false;

		private HandPose _normalHandPose;

		private bool _cosBufferInitiated;

		private float _rotBufferCos;

		public float rotationBufferCos
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		public void InitializeHandPose()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		private bool SelectHandPose(Hand hand, [Out] HandPose hp)
		{
			return default(bool);
		}

		public override ValueTuple<float, float, Vector3, Vector3> ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default(ValueTuple<float, float, Vector3, Vector3>);
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}

		private Vector3 GetPointOnPerimeter(float radius, float theta, float limit, float perc)
		{
			return default(Vector3);
		}

		protected virtual void DrawBodyGizmo(float length, float radius, float angle)
		{
		}

		protected void DrawGizmos(float length, float rotationLimit)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public TargetGrip()
			: base()
		{
		}
	}
}
