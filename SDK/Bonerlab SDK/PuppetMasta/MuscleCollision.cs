using UnityEngine;

namespace PuppetMasta
{
	public struct MuscleCollision
	{
		public int muscleIndex;

		public Collision collision;

		public bool isStay;

		public MuscleCollision(int _muscleIndex, Collision _collision, bool _isStay = false)
		{
			muscleIndex = _muscleIndex;
			collision = _collision;
			isStay = _isStay;
		}
	}
}
