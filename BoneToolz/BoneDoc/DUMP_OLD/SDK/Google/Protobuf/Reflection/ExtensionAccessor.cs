using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class ExtensionAccessor : IFieldAccessor
	{
		private readonly Extension extension;

		private readonly ReflectionUtil.IExtensionReflectionHelper helper;

		public FieldDescriptor Descriptor { get; }

		internal ExtensionAccessor(FieldDescriptor descriptor)
			: base()
		{
		}

		public bool HasValue(IMessage message)
		{
			return default(bool);
		}

		public object GetValue(IMessage message)
		{
			return null;
		}
	}
}
