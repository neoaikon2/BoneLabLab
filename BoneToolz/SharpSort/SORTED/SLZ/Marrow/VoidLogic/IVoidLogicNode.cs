namespace SLZ.Marrow.VoidLogic
{
	public interface IVoidLogicNode
	{
		PortMetadata PortMetadata { get; }

		VoidLogicSubgraph Subgraph { get; set; }
	}
}
