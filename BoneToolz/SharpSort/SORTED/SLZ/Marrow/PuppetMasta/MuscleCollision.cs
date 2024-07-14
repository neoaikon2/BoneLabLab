using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	public struct MuscleCollision
	{
		public int muscleIndex;

		public Collision collision;

		public bool isStay;

		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
			this.muscleIndex = 0;
			this.collision = null;
			this.isStay = false;
		}
	}
}
