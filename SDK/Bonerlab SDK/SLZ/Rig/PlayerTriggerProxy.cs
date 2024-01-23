using SLZ.Marrow.Utilities;

namespace SLZ.Rig
{
	public class PlayerTriggerProxy : ObjectCleanupEvents
	{
		private static ComponentCache<PlayerTriggerProxy> _cache;

		public PhysicsRig physicsRig;

		public new static ComponentCache<PlayerTriggerProxy> Cache => null;

		public override void Awake()
		{
		}

		public override void OnDestroy()
		{
		}

		public override void OnCleanup()
		{
		}
	}
}
