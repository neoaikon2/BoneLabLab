namespace Microsoft.Extensions.Options
{
	internal sealed class UnnamedOptionsManager<TOptions> : IOptions<TOptions> where TOptions : class
	{
		private readonly IOptionsFactory<TOptions> _factory;

		private object _syncObj;

		private TOptions _value;

		public TOptions Value
		{
			get
			{
				return null;
			}
		}

		public UnnamedOptionsManager(IOptionsFactory<TOptions> factory)
			: base()
		{
		}
	}
}
