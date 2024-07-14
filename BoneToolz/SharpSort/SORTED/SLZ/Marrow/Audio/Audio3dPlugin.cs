using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Audio
{
	[MarrowPlugin("SLZ.Marrow.Zones", "Audio 3d", null)]
	public class Audio3dPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		public static Audio3dManager Audio3dManager { get; private set; }

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
	}
}
