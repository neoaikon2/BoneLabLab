using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		private EnumDescriptor enumType;

		private MessageDescriptor extendeeType;

		private MessageDescriptor messageType;

		private FieldType fieldType;

		private readonly string propertyName;

		private IFieldAccessor accessor;

		public MessageDescriptor ContainingType { get; }

		public OneofDescriptor ContainingOneof { get; }

		public string JsonName { get; }

		internal FieldDescriptorProto Proto { get; }

		internal Extension Extension { get; }

		public override string Name
		{
			get
			{
				return null;
			}
		}

		public IFieldAccessor Accessor
		{
			get
			{
				return null;
			}
		}

		public bool IsRepeated
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsRequired
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsMap
		{
			get
			{
				return default(bool);
			}
		}

		public FieldType FieldType
		{
			get
			{
				return default(FieldType);
			}
		}

		public int FieldNumber
		{
			get
			{
				return default(int);
			}
		}

		public MessageDescriptor ExtendeeType
		{
			get
			{
				return null;
			}
		}

		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Extension extension) : base(file, "", index)
		{
		}

		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			return default(FieldType);
		}

		public int CompareTo(FieldDescriptor other)
		{
			return default(int);
		}

		internal void CrossLink()
		{
		}

		private IFieldAccessor CreateAccessor()
		{
			return null;
		}
	}
}
