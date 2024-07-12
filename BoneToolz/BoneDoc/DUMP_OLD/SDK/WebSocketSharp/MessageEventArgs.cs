using System;

namespace WebSocketSharp
{
	public class MessageEventArgs : EventArgs
	{
		private string _data;

		private bool _dataSet;

		private Opcode _opcode;

		private byte[] _rawData;

		public string Data
		{
			get
			{
				return null;
			}
		}

		internal MessageEventArgs(WebSocketFrame frame)
			: base()
		{
		}

		internal MessageEventArgs(Opcode opcode, byte[] rawData)
			: base()
		{
		}

		private void setData()
		{
		}
	}
}
