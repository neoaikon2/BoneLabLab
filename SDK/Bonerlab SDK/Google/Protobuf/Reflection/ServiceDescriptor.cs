using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class ServiceDescriptor : DescriptorBase
	{
		private readonly ServiceDescriptorProto proto;

		private readonly IList<MethodDescriptor> methods;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index) : base(file, "", index)
		{
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}
