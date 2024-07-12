using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPluginRunCallbacks : IMarrowPlugin
	{
		UniTask OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		UniTask OnMarrowPluginStop()
		{
			return default(UniTask);
		}
	}
}
