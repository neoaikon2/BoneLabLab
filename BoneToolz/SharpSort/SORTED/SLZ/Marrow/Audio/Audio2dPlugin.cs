using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Audio
{
	[MarrowPlugin("SLZ.Marrow.Zones", "Audio 2d", null)]
	public class Audio2dPlugin : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		public static Audio2dManager Audio2dManager { get; private set; }

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
	}
}
