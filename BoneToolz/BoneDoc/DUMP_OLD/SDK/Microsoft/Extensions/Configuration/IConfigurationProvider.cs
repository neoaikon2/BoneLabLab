using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public interface IConfigurationProvider
	{
		bool TryGet(string key, [Out] string value);

		IChangeToken GetReloadToken();

		void Load();

		IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string parentPath);
	}
}
