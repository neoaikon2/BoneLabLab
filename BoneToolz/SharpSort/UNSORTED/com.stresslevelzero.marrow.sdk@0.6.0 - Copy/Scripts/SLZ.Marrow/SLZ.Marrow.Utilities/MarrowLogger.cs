using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Microsoft.Extensions.Logging;

namespace SLZ.Marrow.Utilities
{
	public static class MarrowLogger
	{
		private static ILoggerFactory _loggerFactory { get; }

		[PublicAPI]
		public static ILogger Logger { get; }

		static MarrowLogger()
		{
		}

		[PublicAPI]
		public static ILogger<T> GetLogger<T>() where T : class
		{
			return null;
		}

		[PublicAPI]
		public static ILogger GetLogger(string categoryName)
		{
			return null;
		}
	}

	internal interface ILoggerFactory { }
}
