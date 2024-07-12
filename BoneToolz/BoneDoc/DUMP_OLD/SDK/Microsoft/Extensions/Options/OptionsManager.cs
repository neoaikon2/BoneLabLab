using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Options
{
	public class OptionsManager<TOptions> : IOptions<TOptions>, IOptionsSnapshot<TOptions> where TOptions : class
	{
		private readonly IOptionsFactory<TOptions> _factory;

		private readonly OptionsCache<TOptions> _cache;

		public TOptions Value
		{
			get
			{
				return null;
			}
		}

		public OptionsManager(IOptionsFactory<TOptions> factory)
			: base()
		{
		}

		public virtual TOptions Get(string name)
		{
			return null;
		}
	}
}
