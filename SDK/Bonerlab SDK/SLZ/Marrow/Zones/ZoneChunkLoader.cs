using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Zone Chunk Loader")]
	public class ZoneChunkLoader : ZoneLinkItem
	{
		public SceneChunk[] chunks;

		protected override void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		public ZoneChunkLoader()
			: base()
		{
		}
	}
}
