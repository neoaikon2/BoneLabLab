using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public interface IWebSocketSession
	{
		WebSocketState ConnectionState { get; }

		WebSocketContext Context { get; }

		string ID { get; }
	}
}
