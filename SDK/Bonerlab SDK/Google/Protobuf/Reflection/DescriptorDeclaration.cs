using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorDeclaration
	{
		public int StartLine { get; }

		private DescriptorDeclaration(IDescriptor descriptor, SourceCodeInfo.Types.Location location)
			: base()
		{
		}

		internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location)
		{
			return null;
		}
	}
}
