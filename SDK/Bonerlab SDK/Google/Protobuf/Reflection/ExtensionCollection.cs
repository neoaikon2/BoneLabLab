using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public class ExtensionCollection
	{
		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder;

		private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder;

		public IList<FieldDescriptor> UnorderedExtensions { get; }

		internal ExtensionCollection(FileDescriptor file, Extension[] extensions)
			: base()
		{
		}

		internal ExtensionCollection(MessageDescriptor message, Extension[] extensions)
			: base()
		{
		}

		internal void CrossLink()
		{
		}
	}
}
