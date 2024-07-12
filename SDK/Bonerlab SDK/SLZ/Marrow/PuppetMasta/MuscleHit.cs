using SLZ.Marrow.Combat;

namespace SLZ.Marrow.PuppetMasta
{
	public struct MuscleHit
	{
		public int muscleIndex;

		public Attack attack;

		public MuscleHit(int muscleIndex, Attack attack)
		{
			this.attack = default(Attack);
			this.muscleIndex = default(int);
		}
	}
}
