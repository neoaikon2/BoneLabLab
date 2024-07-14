using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginLevelCallbacks : IMarrowPlugin
	{
		UniTask OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		UniTask OnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		UniTask OnBeforeLevelUnload()
		{
			return default(UniTask);
		}

		UniTask OnAfterLevelUnload()
		{
			return default(UniTask);
		}
	}
}
