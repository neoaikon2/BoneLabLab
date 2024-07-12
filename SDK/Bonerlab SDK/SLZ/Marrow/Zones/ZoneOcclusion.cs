using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneOcclusion : ZoneLinkItem
	{
		[SerializeField]
		private OcclusionPortal _occlusion;

		private void Awake()
		{
		}

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		protected override void OnExit(MarrowEntity activatorEntity)
		{
		}

		public ZoneOcclusion()
			: base()
		{
		}
	}
}
