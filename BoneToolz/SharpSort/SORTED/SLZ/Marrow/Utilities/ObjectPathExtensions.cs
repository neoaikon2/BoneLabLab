using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public static class ObjectPathExtensions
	{
		private static IEnumerable<string> ObjectPathComponents(this Transform tf)
		{
			return null;
		}

		[PublicAPI]
		public static string ObjectPath(this Transform tf)
		{
			return null;
		}

		[PublicAPI]
		public static string ObjectPath(this Component c)
		{
			return null;
		}

		[PublicAPI]
		public static string ObjectPath(this GameObject go)
		{
			return null;
		}
	}
}
