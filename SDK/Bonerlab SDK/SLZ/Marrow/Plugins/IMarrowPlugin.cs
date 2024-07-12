using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	public interface IMarrowPlugin
	{
		UniTask OnMarrowPluginLoad()
		{
			return default(UniTask);
		}
	}
}
