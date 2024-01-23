namespace Google.Protobuf.Reflection
{
	public sealed class MethodDescriptor : DescriptorBase
	{
		private readonly MethodDescriptorProto proto;

		private readonly ServiceDescriptor service;

		private MessageDescriptor inputType;

		private MessageDescriptor outputType;

		internal MethodDescriptorProto Proto
		{
			get
			{
				return null;
			}
		}

		public override string Name
		{
			get
			{
				return null;
			}
		}

		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) : base(file, "", index)
		{
		}

		internal void CrossLink()
		{
		}
	}
}
