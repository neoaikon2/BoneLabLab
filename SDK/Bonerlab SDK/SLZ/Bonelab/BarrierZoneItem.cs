using System;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;

namespace SLZ.Bonelab
{
	public class BarrierZoneItem : ZoneItem
	{
		private Action<MarrowEntity> _onEnterAction;

		private Action<MarrowEntity> _onExitAction;

		public void RegisterActions(Action<MarrowEntity> onEnter, Action<MarrowEntity> onExit)
		{
		}

		protected override void OnEnter(MarrowEntity entity)
		{
		}

		protected override void OnExit(MarrowEntity entity)
		{
		}

		public BarrierZoneItem()
			: base()
		{
		}
	}
}
