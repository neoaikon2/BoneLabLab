using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class RepeatedFieldAccessor : FieldAccessorBase
	{
		internal RepeatedFieldAccessor(PropertyInfo property, FieldDescriptor descriptor)
		{
		}

		public override bool HasValue(IMessage message)
		{
			return default(bool);
		}

		public override void SetValue(IMessage message, object value)
		{
		}
	}
}
