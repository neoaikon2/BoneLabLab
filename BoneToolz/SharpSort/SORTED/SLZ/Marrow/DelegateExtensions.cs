using System;
using System.Collections.Generic;

namespace SLZ.Marrow
{
	public static class DelegateExtensions
	{
		private static readonly List<Exception> _exceptions;

		public static void SafeInvoke(this Delegate del, params object[] args)
		{
		}
	}
}
