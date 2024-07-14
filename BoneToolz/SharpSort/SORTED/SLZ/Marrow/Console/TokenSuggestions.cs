using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	public class TokenSuggestions<TSuggestionContext>
	{
		public List<(TSuggestionContext context, string token)> ExactMatches { get; }

		public List<(TSuggestionContext, string token)> PossibleMatches { get; }

		public List<(TSuggestionContext, string token)> Suggestions { get; }
	}
}
