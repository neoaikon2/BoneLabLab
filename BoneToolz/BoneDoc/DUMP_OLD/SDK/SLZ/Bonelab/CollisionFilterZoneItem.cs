using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CollisionFilterZoneItem : ZoneItem
	{
		[SerializeField]
		private Collider[] _collidersToIgnore;

		protected override void OnEnter(MarrowEntity entity)
		{
		}

		protected override void OnExit(MarrowEntity entity)
		{
		}

		public CollisionFilterZoneItem()
			: base()
		{
		}
	}
}
