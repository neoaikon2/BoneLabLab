using System;

namespace Grpc.Core.Logging
{
	public interface ILogger
	{
		ILogger ForType<T>();

		void Debug(string message);

		void Debug(string format, params object[] formatArgs);

		void Info(string message);

		void Warning(string format, params object[] formatArgs);

		void Error(string message);

		void Error(Exception exception, string message);
	}
}
