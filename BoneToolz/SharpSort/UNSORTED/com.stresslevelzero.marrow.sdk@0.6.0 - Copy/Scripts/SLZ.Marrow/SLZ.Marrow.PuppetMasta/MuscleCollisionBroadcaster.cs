using SLZ.Marrow.Combat;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Marrow.PuppetMasta
{
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<MuscleCollisionBroadcaster> _cache;

		[HideInInspector]
		[SerializeField]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		private const string onMuscleHit = "OnMuscleHit";

		private const string onMuscleCollision = "OnMuscleCollision";

		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		private MuscleCollisionBroadcaster otherBroadcaster;

		public static ComponentCache<MuscleCollisionBroadcaster> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Hit(Attack attack)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public virtual void OnCollisionEnter(Collision collision)
		{
		}
	}
}
