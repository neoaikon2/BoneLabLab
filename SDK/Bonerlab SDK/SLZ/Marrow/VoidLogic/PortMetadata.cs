using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.VoidLogic
{
	public struct PortMetadata
	{
		public readonly bool InputIsArray;

		public readonly string InputPropertyName;

		public readonly ReadOnlyCollection<PortInfo> Inputs;

		public readonly ReadOnlyCollection<PortInfo> Outputs;

		public PortMetadata(string inputPropertyName, PortInfo[] inputs, PortInfo[] outputs)
		{
			this.Outputs = default(ReadOnlyCollection<PortInfo>);
			this.Inputs = default(ReadOnlyCollection<PortInfo>);
			this.InputPropertyName = default(string);
			this.InputIsArray = default(bool);
		}
	}
}
