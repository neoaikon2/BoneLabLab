using SLZ.Marrow.Interaction;
using SLZ.Player;
using SLZ.Rig;

namespace SLZ.Marrow.Zones
{
	public class SlowmoSwitch : ZoneLinkItem
	{
		public bool oneWayToggle;

		public bool toggleSlowmo;

		public Health.HealthMode healthModeToSet;

		private RigManager rm;

		private Health.HealthMode cashedHeathMode;

		private bool firstCall;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		public void ToggleSlowmo(bool apply, MarrowEntity activatorEntity)
		{
		}

		public void TurnOffSlowMoAndSetInvincible()
		{
		}

		public void OnDestroy()
		{
		}

		public SlowmoSwitch()
			: base()
		{
		}
	}
}
