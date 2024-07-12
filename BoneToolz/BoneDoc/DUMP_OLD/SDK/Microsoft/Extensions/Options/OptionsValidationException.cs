using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Options
{
	public class OptionsValidationException : Exception
	{
		public IEnumerable<string> Failures { get; }

		public override string Message
		{
			get
			{
				return null;
			}
		}

		public OptionsValidationException(string optionsName, Type optionsType, IEnumerable<string> failureMessages)
			: base()
		{
		}
	}
}
