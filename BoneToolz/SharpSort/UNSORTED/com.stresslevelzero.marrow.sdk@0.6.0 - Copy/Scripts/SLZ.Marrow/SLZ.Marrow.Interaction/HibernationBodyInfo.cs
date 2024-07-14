using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public struct HibernationBodyInfo
	{
		public bool isSleeping;

		public Vector3 velocity;

		public Vector3 angularVelocity;

		public Vector3 inertiaTensor;

		public float sleepThreshold;

		public RigidbodyConstraints constraints;

		public void CopyFrom(Rigidbody rb)
		{
		}

		public void CopyTo(Rigidbody rb)
		{
		}
	}
}
