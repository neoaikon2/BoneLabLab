using System.Runtime.InteropServices;

namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSink : IVoidLogicNode
	{
		int InputCount { get; }

		bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input);
	}
}
