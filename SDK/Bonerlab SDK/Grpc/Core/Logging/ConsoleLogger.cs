using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Grpc.Core.Logging
{
	public class ConsoleLogger : TextWriterLogger
	{
		public ConsoleLogger()
			: this(default(System.Type))
		{
		}

		private ConsoleLogger(Type forType) : base(forType)
		{
		}

		public override ILogger ForType<T>()
		{
			return null;
		}
	}
}
