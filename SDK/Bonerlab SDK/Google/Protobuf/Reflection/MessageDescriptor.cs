using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class MessageDescriptor : DescriptorBase
	{
		public sealed class FieldCollection
		{
			private readonly MessageDescriptor messageDescriptor;

			public FieldDescriptor this[int number]
			{
				get
				{
					return null;
				}
			}

			internal FieldCollection(MessageDescriptor messageDescriptor)
				: base()
			{
			}

			public IList<FieldDescriptor> InDeclarationOrder()
			{
				return null;
			}

			public IList<FieldDescriptor> InFieldNumberOrder()
			{
				return null;
			}
		}

		private static readonly HashSet<string> WellKnownTypeNames;

		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

		private readonly IList<FieldDescriptor> fieldsInNumberOrder;

		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal DescriptorProto Proto { get; }

		public Type ClrType { get; }

		public MessageParser Parser { get; }

		internal bool IsWellKnownType
		{
			get
			{
				return default(bool);
			}
		}

		internal bool IsWrapperType
		{
			get
			{
				return default(bool);
			}
		}

		public FieldCollection Fields { get; }

		public ExtensionCollection Extensions { get; }

		public IList<MessageDescriptor> NestedTypes { get; }

		public IList<EnumDescriptor> EnumTypes { get; }

		public IList<OneofDescriptor> Oneofs { get; }

		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) : base(file, "", typeIndex)
		{
		}

		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields)
		{
			return null;
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		public FieldDescriptor FindFieldByNumber(int number)
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}
