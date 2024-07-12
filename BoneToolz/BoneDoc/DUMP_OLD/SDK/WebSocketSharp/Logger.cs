using System;

namespace WebSocketSharp
{
	public class Logger
	{
		private string _file;

		private LogLevel _level;

		private Action<LogData, string> _output;

		private object _sync;

		public Logger()
			: base()
		{
		}

		public Logger(LogLevel level, string file, Action<LogData, string> output)
			: this()
		{
		}

		private static void defaultOutput(LogData data, string path)
		{
		}

		private void output(string message, LogLevel level)
		{
		}

		private static void writeToFile(string value, string path)
		{
		}

		public void Debug(string message)
		{
		}

		public void Error(string message)
		{
		}

		public void Fatal(string message)
		{
		}

		public void Info(string message)
		{
		}

		public void Trace(string message)
		{
		}

		public void Warn(string message)
		{
		}
	}
}
