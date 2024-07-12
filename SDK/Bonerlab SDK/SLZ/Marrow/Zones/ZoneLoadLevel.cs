using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Load Level")]
	public class ZoneLoadLevel : ZoneItem
	{
		public LevelCrateReference level;

		public LevelCrateReference loadScreenLevel;

		public UnityAction OnLevelSwitch;

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		public ZoneLoadLevel()
			: base()
		{
		}
	}
}
