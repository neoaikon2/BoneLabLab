using System;
using System.IO;

namespace Grpc.Core.Logging
{
	public class TextWriterLogger : ILogger
	{
		private readonly Func<TextWriter> textWriterProvider;

		private readonly Type forType;

		private readonly string forTypeString;

		protected Type AssociatedType
		{
			get
			{
				return null;
			}
		}

		protected TextWriterLogger(Type forType)
			: base()
		{
		}

		protected TextWriterLogger(Func<TextWriter> textWriterProvider, Type forType)
			: base()
		{
		}

		public virtual ILogger ForType<T>()
		{
			return null;
		}

		public void Debug(string message)
		{
		}

		public void Debug(string format, params object[] formatArgs)
		{
			formatArgs = default(object[]);
		}

		public void Info(string message)
		{
		}

		public void Warning(string message)
		{
		}

		public void Warning(string format, params object[] formatArgs)
		{
			formatArgs = default(object[]);
		}

		public void Error(string message)
		{
		}

		public void Error(Exception exception, string message)
		{
		}

		private void Log(string severityString, string message)
		{
		}
	}
}
