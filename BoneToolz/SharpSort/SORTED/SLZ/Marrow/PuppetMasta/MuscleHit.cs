using SLZ.Marrow.Combat;

namespace SLZ.Marrow.PuppetMasta
{
	public struct MuscleHit
	{
		public int muscleIndex;

		public Attack attack;

		public MuscleHit(int muscleIndex, Attack attack)
		{
			this.muscleIndex = 0;
			this.attack = default(Attack);
		}
	}
}
