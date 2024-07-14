using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public readonly struct TemporalTransform
	{
		public readonly SimpleTransform transform;

		public readonly Vector3 velocity;

		public readonly Vector3 angularVelocity;

		public readonly double time;

		public TemporalTransform(Vector3 position, Quaternion rotation, Vector3 velocity, Vector3 angularVelocity, double time)
		{
			transform = default(SimpleTransform);
			this.velocity = default(Vector3);
			this.angularVelocity = default(Vector3);
			this.time = 0.0;
		}

		public TemporalTransform(SimpleTransform transform, Vector3 velocity, Vector3 angularVelocity, in double time)
		{
			this.transform = default(SimpleTransform);
			this.velocity = default(Vector3);
			this.angularVelocity = default(Vector3);
			this.time = 0.0;
		}
	}
}
