using System;

namespace SLZ.Marrow.Console
{
	public interface IObjectDescriber
	{
		bool CanDescribe(Type type);

		bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description);
	}
}
