using Steamworks.Data;

namespace Steamworks
{
	public interface ISocketManager
	{
		void OnConnecting(Connection connection, ConnectionInfo info);

		void OnConnected(Connection connection, ConnectionInfo info);

		void OnDisconnected(Connection connection, ConnectionInfo info);
	}
}
