using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class WorldGrip : Grip
	{
		private class HandToGenericGripState
		{
			public bool isRaycastHit;

			public Vector3 raycastNormal;

			public Vector3 raycastPoint;

			public SimpleTransform worldHandleTransform;

			public Vector3 backOfHandNormal;

			public Collider[] targetColliders;

			public int targetColliderCount;
		}

		private Dictionary<Hand, HandToGenericGripState> genericHandStates;

		private List<Collider> ignoreColliders;

		protected override void Awake()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return 0f;
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override void OnJointAttached(Hand hand)
		{
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}
	}
}
