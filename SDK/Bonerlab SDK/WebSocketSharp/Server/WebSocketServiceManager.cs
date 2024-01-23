using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WebSocketSharp.Server
{
	[DefaultMember("Item")]
	public class WebSocketServiceManager
	{
		private Dictionary<string, WebSocketServiceHost> _hosts;

		private bool _keepClean;

		private Logger _log;

		private ServerState _state;

		private object _sync;

		private TimeSpan _waitTime;

		internal WebSocketServiceManager(Logger log)
			: base()
		{
		}

		internal bool InternalTryGetServiceHost(string path, [Out] WebSocketServiceHost host)
		{
			return default(bool);
		}

		internal void Start()
		{
		}

		internal void Stop(ushort code, string reason)
		{
		}

		public void AddService<TBehavior>(string path, Action<TBehavior> initializer) where TBehavior : WebSocketBehavior, new()
		{
		}

		public bool RemoveService(string path)
		{
			return default(bool);
		}
	}
}
