using System;
using System.Reflection;

namespace Google.Protobuf.Reflection
{
	public sealed class OneofAccessor
	{
		private readonly Func<IMessage, int> caseDelegate;

		private readonly Action<IMessage> clearDelegate;

		private OneofDescriptor descriptor;

		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor)
			: base()
		{
		}

		public FieldDescriptor GetCaseFieldDescriptor(IMessage message)
		{
			return null;
		}
	}
}
