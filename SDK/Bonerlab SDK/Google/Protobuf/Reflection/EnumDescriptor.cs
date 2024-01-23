using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumDescriptor : DescriptorBase
	{
		private readonly EnumDescriptorProto proto;

		private readonly MessageDescriptor containingType;

		private readonly IList<EnumValueDescriptor> values;

		private readonly Type clrType;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public IList<EnumValueDescriptor> Values
		{
			get
			{
				return null;
			}
		}

		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType) : base(file, "", index)
		{
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}
	}
}
