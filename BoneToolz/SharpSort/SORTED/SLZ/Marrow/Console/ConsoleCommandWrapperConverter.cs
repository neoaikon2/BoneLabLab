using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Console
{
	public class ConsoleCommandWrapperConverter : IObjectDescriber, ITokenConverter<ConsoleCommandWrapper>
	{
		public bool CanDescribe(Type type)
		{
			return false;
		}

		public bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description)
		{
			description = null;
			return false;
		}

		public bool CanConvert(Type type)
		{
			return false;
		}
		public IEnumerable<ConsoleCommandWrapper> Convert(string token, TokenParseContext context)
		{
			return null;
		}

		public TokenSuggestions<ConsoleCommandWrapper> SuggestConversions(string partialOrEmptyToken, TokenParseContext context)
		{
			return null;
		}
	}
}
