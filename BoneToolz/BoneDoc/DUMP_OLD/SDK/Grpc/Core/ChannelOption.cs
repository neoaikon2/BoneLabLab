namespace Grpc.Core
{
	public sealed class ChannelOption
	{
		public enum OptionType
		{
			Integer = 0,
			String = 1
		}

		private readonly OptionType type;

		private readonly string name;

		private readonly int intValue;

		private readonly string stringValue;

		public OptionType Type
		{
			get
			{
				return default(OptionType);
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public int IntValue
		{
			get
			{
				return default(int);
			}
		}

		public string StringValue
		{
			get
			{
				return null;
			}
		}

		public ChannelOption(string name, string stringValue)
			: base()
		{
		}
	}
}
