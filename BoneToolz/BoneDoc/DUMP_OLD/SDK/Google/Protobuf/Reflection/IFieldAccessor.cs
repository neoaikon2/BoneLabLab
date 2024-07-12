namespace Google.Protobuf.Reflection
{
	public interface IFieldAccessor
	{
		FieldDescriptor Descriptor { get; }

		bool HasValue(IMessage message);

		object GetValue(IMessage message);
	}
}
