namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicActuator : IVoidLogicNode
	{
		void Actuate(NodeState nodeState);
	}
}
