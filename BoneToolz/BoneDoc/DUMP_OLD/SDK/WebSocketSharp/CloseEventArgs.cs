using System;

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private PayloadData _payloadData;

		internal CloseEventArgs(PayloadData payloadData, bool clean)
			: base()
		{
		}

		internal CloseEventArgs(ushort code, string reason, bool clean)
			: base()
		{
		}
	}
}
