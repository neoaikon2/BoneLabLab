using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginEditorCallbacks : IMarrowPlugin
	{
		UniTask OnMarrowPluginEditorPaused()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorUnpaused()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorEnteredEditMode()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorExitingEditMode()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorEnteredPlayMode()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorExitingPlayMode()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorBeforeAssemblyReload()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginEditorAfterAssemblyReload()
		{
			return default(UniTask);
		}
	}
}
