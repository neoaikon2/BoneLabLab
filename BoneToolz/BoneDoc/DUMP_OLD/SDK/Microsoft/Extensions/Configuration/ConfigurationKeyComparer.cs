using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Configuration
{
	public class ConfigurationKeyComparer : IComparer<string>
	{
		private static readonly string[] _keyDelimiterArray;

		public static ConfigurationKeyComparer Instance { get; }

		internal static Comparison<string> Comparison { get; }

		public int Compare(string x, string y)
		{
			return default(int);
		}

		public ConfigurationKeyComparer()
			: base()
		{
		}
	}
}
