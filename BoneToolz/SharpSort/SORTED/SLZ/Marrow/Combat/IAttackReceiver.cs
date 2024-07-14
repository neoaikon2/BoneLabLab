using UnityEngine.EventSystems;

namespace SLZ.Marrow.Combat
{
	public interface IAttackReceiver : IEventSystemHandler
	{
		void ReceiveAttack(Attack attack);
	}
}
