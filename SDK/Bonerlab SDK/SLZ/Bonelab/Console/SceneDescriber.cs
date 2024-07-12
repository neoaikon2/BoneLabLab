using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[UsedImplicitly]
	internal class SceneDescriber : IObjectDescriber
	{
		public bool CanDescribe(Type type)
		{
			return default(bool);
		}

		public bool TryDescribe(object obj, TokenParseContext context, [Out] ObjectDescription description)
		{
			return default(bool);
		}

		public SceneDescriber()
			: base()
		{
		}
	}
}
