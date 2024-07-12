using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public abstract class DescriptorBase : IDescriptor
	{
		public abstract string Name { get; }

		public string FullName { get; }

		public FileDescriptor File { get; }

		internal DescriptorBase(FileDescriptor file, string fullName, int index)
			: base()
		{
		}

		internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}
	}
}
