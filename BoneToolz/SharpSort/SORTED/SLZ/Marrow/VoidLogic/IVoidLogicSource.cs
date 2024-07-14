namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSource : IVoidLogicNode
	{
		void Calculate(ref NodeState nodeState);
	}
}
