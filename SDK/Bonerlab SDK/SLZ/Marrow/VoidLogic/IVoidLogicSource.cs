namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSource : IVoidLogicNode
	{
		void Calculate(NodeState nodeState);
	}
}
