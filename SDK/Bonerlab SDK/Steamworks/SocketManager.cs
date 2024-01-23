using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class SocketManager
	{
		public List<Connection> Connecting;

		public List<Connection> Connected;

		internal HSteamNetPollGroup pollGroup;

		public ISocketManager Interface { get; }

		public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnConnecting(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnConnected(Connection connection, ConnectionInfo info)
		{
		}

		public virtual void OnDisconnected(Connection connection, ConnectionInfo info)
		{
		}

		public SocketManager()
			: base()
		{
		}
	}
}
