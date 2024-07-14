using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	public class MuscleCollisionBroadcasterSensor : MuscleCollisionBroadcaster
	{
		public bool isGrounded;

		public Vector3 groundNormal;

		public Vector3 _totalImpulse;

		public float totalMass;

		public float additionalMass;

		private Vector3 _deltaVel;

		private Vector3 _groundVel;

		private Vector3 _lastGroundVel;

		private float _groundMultSum;

		private float _groundAngVel;

		private int _count;

		private Rigidbody _rb;

		private int collisionLayer;

		private void Start()
		{
		}

		public override void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void ProcessCollision(Collision c)
		{
		}

		public void ReadData(out Vector3 deltaPosition, out Vector3 impulse, out bool asleep)
		{
			deltaPosition = default(Vector3);
			impulse = default(Vector3);
			asleep = default(bool);
		}

		public void ReadData(out Vector3 deltaPosition, out Vector3 impulse, out bool asleep, out Vector3 groundVelocity, out float groundAngVel)
		{
			deltaPosition = default(Vector3);
			impulse = default(Vector3);
			asleep = default(bool);
			groundVelocity = default(Vector3);
			groundAngVel = default(float);
		}
	}
}
