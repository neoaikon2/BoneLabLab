namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicSensor : IVoidLogicNode
	{
		void ReadSensors(ref NodeState nodeState);
	}
}
