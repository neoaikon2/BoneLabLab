using System;

namespace WebSocketSharp
{
	public class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		internal ErrorEventArgs(string message, Exception exception)
			: base()
		{
		}
	}
}
