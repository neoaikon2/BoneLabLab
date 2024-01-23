using System.Reflection;

namespace Google.Protobuf.Reflection
{
	internal sealed class MapFieldAccessor : FieldAccessorBase
	{
		internal MapFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) : base(property, descriptor)
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
