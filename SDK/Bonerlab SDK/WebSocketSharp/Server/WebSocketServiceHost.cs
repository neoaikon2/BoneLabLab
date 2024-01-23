using System;
using System.Runtime.CompilerServices;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketServiceHost
	{
		private Logger _log;

		private string _path;

		private WebSocketSessionManager _sessions;

		internal ServerState State
		{
			get
			{
				return default(ServerState);
			}
		}

		public bool KeepClean
		{
			set
			{
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		protected WebSocketServiceHost(string path, Logger log)
			: base()
		{
		}

		internal void Start()
		{
		}

		internal void StartSession(WebSocketContext context)
		{
		}

		internal void Stop(ushort code, string reason)
		{
		}

		protected abstract WebSocketBehavior CreateSession();
	}
	internal class WebSocketServiceHost<TBehavior> : WebSocketServiceHost where TBehavior : WebSocketBehavior, new()
	{
		private Func<TBehavior> _creator;

		internal WebSocketServiceHost(string path, Action<TBehavior> initializer, Logger log)
			: base(path, log)
		{
		}

		private static Func<TBehavior> createSessionCreator(Action<TBehavior> initializer)
		{
			return null;
		}

		protected override WebSocketBehavior CreateSession()
		{
			return null;
		}
	}
}
