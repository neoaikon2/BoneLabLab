using System;

namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorValidationException : Exception
	{
		private readonly string name;

		private readonly string description;

		internal DescriptorValidationException(IDescriptor problemDescriptor, string description)
			: base()
		{
		}
	}
}
