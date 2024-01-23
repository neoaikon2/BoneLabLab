using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class SingleFieldAccessor : FieldAccessorBase
	{
		private readonly Action<IMessage, object> setValueDelegate;

		private readonly Action<IMessage> clearDelegate;

		private readonly Func<IMessage, bool> hasDelegate;

		internal SingleFieldAccessor(PropertyInfo property, FieldDescriptor descriptor) : base(property, descriptor)
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
