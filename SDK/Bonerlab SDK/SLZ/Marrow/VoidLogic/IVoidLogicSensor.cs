namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSensor : IVoidLogicNode
	{
		void ReadSensors(NodeState nodeState);
	}
}
