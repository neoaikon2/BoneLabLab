using System;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Zones
{
	[Serializable]
	public class EntityAggregator
	{
		public MarrowQuery tags;

		public Action<MarrowBody> onBodyEnterAction;

		public Action<MarrowBody> onBodyExitAction;

		public Action<MarrowEntity> onEntityEnterAction;

		public Action<MarrowEntity> onEntityExitAction;

		private readonly Dictionary<MarrowEntity, int> _entityOverlapCounts;

		public void OnBodyEnter(MarrowBody body)
		{
		}

		public void OnBodyExit(MarrowBody body)
		{
		}
	}
}
