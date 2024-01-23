namespace Google.Protobuf.Reflection
{
	internal sealed class PackageDescriptor : IDescriptor
	{
		private readonly string name;

		private readonly string fullName;

		private readonly FileDescriptor file;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string FullName
		{
			get
			{
				return null;
			}
		}

		public FileDescriptor File
		{
			get
			{
				return null;
			}
		}

		internal PackageDescriptor(string name, string fullName, FileDescriptor file)
			: base()
		{
		}
	}
}
