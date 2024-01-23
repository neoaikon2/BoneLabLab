using Steamworks.Data;

namespace Steamworks
{
	public interface IConnectionManager
	{
		void OnConnecting(ConnectionInfo info);

		void OnConnected(ConnectionInfo info);

		void OnDisconnected(ConnectionInfo info);
	}
}
