namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSink : IVoidLogicNode
	{
		int InputCount { get; }

		bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input);
	}
}
