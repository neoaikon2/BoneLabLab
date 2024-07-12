using System.Collections.Generic;

namespace Microsoft.Extensions.Options
{
	public class OptionsFactory<TOptions> : IOptionsFactory<TOptions> where TOptions : class
	{
		private readonly IConfigureOptions<TOptions>[] _setups;

		private readonly IPostConfigureOptions<TOptions>[] _postConfigures;

		private readonly IValidateOptions<TOptions>[] _validations;

		public OptionsFactory(IEnumerable<IConfigureOptions<TOptions>> setups, IEnumerable<IPostConfigureOptions<TOptions>> postConfigures)
			: base()
		{
		}

		public OptionsFactory(IEnumerable<IConfigureOptions<TOptions>> setups, IEnumerable<IPostConfigureOptions<TOptions>> postConfigures, IEnumerable<IValidateOptions<TOptions>> validations)
			: base()
		{
		}

		public TOptions Create(string name)
		{
			return null;
		}

		protected virtual TOptions CreateInstance(string name)
		{
			return null;
		}
	}
}
