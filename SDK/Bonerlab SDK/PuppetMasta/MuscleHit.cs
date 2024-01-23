using SLZ.Combat;

namespace PuppetMasta
{
	public struct MuscleHit
	{
		public int muscleIndex;

		public Attack attack;

		public MuscleHit(int _muscleIndex, Attack _attack)
		{
			muscleIndex = _muscleIndex;
			attack = _attack;
		}
	}
}
