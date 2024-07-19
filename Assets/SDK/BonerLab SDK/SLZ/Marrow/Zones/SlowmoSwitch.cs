using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	public class SlowmoSwitch : ZoneLinkItem
	{
		public bool oneWayToggle;

		public bool toggleSlowmo;

		public Health.HealthMode healthModeToSet;

		private Health.HealthMode cashedHeathMode;

		private bool firstCall;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		public void ToggleSlowmo(bool apply)
		{
		}

		public void TurnOffSlowMoAndSetInvincible()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
