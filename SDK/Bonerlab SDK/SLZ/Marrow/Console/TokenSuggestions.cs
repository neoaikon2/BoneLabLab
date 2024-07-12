using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Console
{
	public class TokenSuggestions<TSuggestionContext>
	{		
		public List<ValueTuple<TSuggestionContext, string>> ExactMatches { get; }

		public List<ValueTuple<TSuggestionContext, string>> PossibleMatches { get; }
				
		public List<ValueTuple<TSuggestionContext, string>> Suggestions { get; }

		public TokenSuggestions()
			: base()
		{
		}
	}
}
