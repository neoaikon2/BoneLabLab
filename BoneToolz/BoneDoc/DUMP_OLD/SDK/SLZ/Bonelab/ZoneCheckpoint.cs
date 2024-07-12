using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using SLZ.Rig;

namespace SLZ.Bonelab
{
	public class ZoneCheckpoint : ZoneLinkItem
	{
		public bool onlySetOnce;

		public bool setOnEnter;

		public bool setOnExit;

		private bool _hasSetOnce;

		private void Set(RigManager rigManager)
		{
		}

		public void SetCheckpoint()
		{
		}

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		public ZoneCheckpoint()
			: base()
		{
		}
	}
}
