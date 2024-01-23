using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class GeneratedClrTypeInfo
	{
		private static readonly string[] EmptyNames;

		private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo;

		private static readonly Extension[] EmptyExtensions;

		public Type ClrType { get; private set; }

		public MessageParser Parser { get; }

		public string[] PropertyNames { get; }

		public Extension[] Extensions { get; }

		public string[] OneofNames { get; }

		public GeneratedClrTypeInfo[] NestedTypes { get; }

		public Type[] NestedEnums { get; }

		public GeneratedClrTypeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes)
			: base()
		{
		}

		public GeneratedClrTypeInfo(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
			: base()
		{
		}

		public GeneratedClrTypeInfo(Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes)
			: base()
		{
		}

		public GeneratedClrTypeInfo(Type[] nestedEnums, GeneratedClrTypeInfo[] nestedTypes)
			: base()
		{
		}
	}
}
