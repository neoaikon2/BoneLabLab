using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	public class ConnectionManager
	{
		public bool Connected;

		public bool Connecting;

		public IConnectionManager Interface { get; }

		internal ConnectionInfo ConnectionInfo { set; get; }

		public virtual void OnConnectionChanged(ConnectionInfo info)
		{
		}

		public virtual void OnConnecting(ConnectionInfo info)
		{
		}

		public virtual void OnConnected(ConnectionInfo info)
		{
		}

		public virtual void OnDisconnected(ConnectionInfo info)
		{
		}

		public ConnectionManager()
			: base()
		{
		}
	}
}
