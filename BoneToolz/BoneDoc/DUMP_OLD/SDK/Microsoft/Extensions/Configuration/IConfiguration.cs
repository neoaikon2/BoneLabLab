using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public interface IConfiguration
	{
		string this[string key] { get; }

		IConfigurationSection GetSection(string key);

		IEnumerable<IConfigurationSection> GetChildren();

		IChangeToken GetReloadToken();
	}
}
