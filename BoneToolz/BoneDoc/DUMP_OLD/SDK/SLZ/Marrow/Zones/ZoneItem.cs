using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneItem : MonoBehaviour, IZoneEntityListenable
	{
		[SerializeField]
		protected Zone _zone;

		public MarrowQuery activatorTags;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnEnter(MarrowEntity entity)
		{
		}

		protected virtual void OnExit(MarrowEntity entity)
		{
		}

		public void OnZoneEntityEnter(MarrowEntity entity)
		{
		}

		public void OnZoneEntityExit(MarrowEntity entity)
		{
		}

		public ZoneItem()
			: base()
		{
		}
	}
}
