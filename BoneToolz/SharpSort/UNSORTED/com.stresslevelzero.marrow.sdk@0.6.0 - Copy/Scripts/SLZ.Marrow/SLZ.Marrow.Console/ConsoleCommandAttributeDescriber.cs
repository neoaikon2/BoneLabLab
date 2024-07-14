using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.Console
{
	[UsedImplicitly]
	internal class ConsoleCommandAttributeDescriber : IObjectDescriber
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
	}
}
