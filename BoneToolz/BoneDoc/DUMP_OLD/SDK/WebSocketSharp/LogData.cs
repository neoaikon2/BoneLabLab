using System;
using System.Diagnostics;

namespace WebSocketSharp
{
	public class LogData
	{
		private StackFrame _caller;

		private DateTime _date;

		private LogLevel _level;

		private string _message;

		internal LogData(LogLevel level, StackFrame caller, string message)
			: base()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
