using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class TypeRegistry
	{
		private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap;

		public static TypeRegistry Empty { get; }

		private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap)
			: base()
		{
		}

		public MessageDescriptor Find(string fullName)
		{
			return null;
		}
	}
}
