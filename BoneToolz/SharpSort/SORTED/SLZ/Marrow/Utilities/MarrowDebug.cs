using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public static class MarrowDebug
	{
		public sealed class LogSuppressor : IDisposable
		{
			private readonly bool _doNothing;

			private readonly bool _previousValue;

			private bool _disposedValue;

			private void Dispose(bool disposing)
			{
			}

			public LogSuppressor()
			{
			}

			public LogSuppressor(bool doNothing)
			{
			}

			~LogSuppressor()
			{
			}

			private void System_002EIDisposable_002EDispose()
			{
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		private const bool Enable = true;

		private const bool ShowTypicalLogs = false;

		private const bool ShowWarnings = false;

		private static readonly ThreadLocal<bool> ThreadLocalEnable;

		[MethodImpl(256)]
		public static LogSuppressor SuppressIf(bool condition)
		{
			return null;
		}

		[MethodImpl(256)]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[MethodImpl(256)]
		public static void Log(object message)
		{
		}

		[MethodImpl(256)]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, UnityEngine.Object context)
		{
		}

		[MethodImpl(256)]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		[MethodImpl(256)]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogError(object message)
		{
		}

		[MethodImpl(256)]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[MethodImpl(256)]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogException(Exception exception)
		{
		}

		[MethodImpl(256)]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[MethodImpl(256)]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogFormat(LogType logType, LogOption logOptions, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[MethodImpl(256)]
		public static void LogWarning(object message)
		{
		}

		[MethodImpl(256)]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[MethodImpl(256)]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void WarnIfCalledFromAwake()
		{
		}
	}
}
