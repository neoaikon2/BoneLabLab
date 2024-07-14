using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Zones
{
	[MarrowPlugin("SLZ.Marrow.NewZones", "Zone Manager Plugin", null)]
	internal class ZoneManagerPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		public static ZoneManager ZoneManager { get; private set; }

		public static ZoneLinkManager<MarrowEntity, ZoneLink> ZoneLinkManager { get; private set; }

		public static ZoneCullManager ZoneCullManager { get; private set; }

		public static InactiveObjectManager InactiveManager { get; private set; }

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
	}
}
