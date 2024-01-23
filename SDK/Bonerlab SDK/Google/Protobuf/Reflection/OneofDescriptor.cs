using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class OneofDescriptor : DescriptorBase
	{
		private readonly OneofDescriptorProto proto;

		private MessageDescriptor containingType;

		private IList<FieldDescriptor> fields;

		private readonly OneofAccessor accessor;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public MessageDescriptor ContainingType
		{
			get
			{
				return null;
			}
		}

		public OneofAccessor Accessor
		{
			get
			{
				return null;
			}
		}

		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) : base(file, "", index)
		{
		}

		internal void CrossLink()
		{
		}

		private OneofAccessor CreateAccessor(string clrName)
		{
			return null;
		}
	}
}
