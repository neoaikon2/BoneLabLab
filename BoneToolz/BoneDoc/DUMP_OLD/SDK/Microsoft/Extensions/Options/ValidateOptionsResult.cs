using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Options
{
	public class ValidateOptionsResult
	{
		public static readonly ValidateOptionsResult Skip;

		public static readonly ValidateOptionsResult Success;

		protected bool Succeeded { set; }

		protected bool Skipped { set; }

		public bool Failed { get; }

		public IEnumerable<string> Failures { get; }

		public ValidateOptionsResult()
			: base()
		{
		}
	}
}
