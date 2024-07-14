using System.Collections.ObjectModel;

namespace SLZ.Marrow.VoidLogic
{
	public readonly struct PortMetadata
	{
		public readonly bool InputIsArray;

		public readonly string InputPropertyName;

		public readonly ReadOnlyCollection<PortInfo> Inputs;

		public readonly ReadOnlyCollection<PortInfo> Outputs;

		public PortMetadata(string inputPropertyName, PortInfo[] inputs, PortInfo[] outputs)
		{
			InputIsArray = false;
			InputPropertyName = null;
			Inputs = null;
			Outputs = null;
		}
	}
}
