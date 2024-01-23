using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class TargetGrip : Grip
	{
		[Tooltip("Degrees plus/minus. Defaults to 180")]
		[Range(0f, 180f)]
		[Header("Target Grip")]
		public float rotationLimit = 180.0f;

		[Range(0f, 180f)]
		public float rotationPriorityBuffer = 20.0f;

		[Tooltip("Will switch to this handpose when the primary axis is flipped on hover")]
		[Header("Flippable Hand Pose")]
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
				return 0f;
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

		private bool SelectHandPose(Hand hand, out HandPose hp)
		{
			hp = null;
			return false;
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return 0f;
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
	}
}
