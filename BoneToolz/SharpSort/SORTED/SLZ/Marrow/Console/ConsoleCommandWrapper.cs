using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	public sealed class ConsoleCommandWrapper
	{
		public readonly BaseConsoleCommand Command;

		public bool Installed { get; internal set; }

		public IReadOnlyList<ConsoleCommandAttribute> Attributes { get; internal set; }

		public ConsoleCommandWrapper(Type commandType)
		{
		}
	}
}
