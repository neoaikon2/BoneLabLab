using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Timers;

namespace WebSocketSharp.Server
{
	[DefaultMember("Item")]
	public class WebSocketSessionManager
	{
		private static readonly byte[] _emptyPingFrameAsBytes;

		private object _forSweep;

		private bool _keepClean;

		private Logger _log;

		private Dictionary<string, IWebSocketSession> _sessions;

		private ServerState _state;

		private bool _sweeping;

		private Timer _sweepTimer;

		private object _sync;

		private TimeSpan _waitTime;

		internal ServerState State
		{
			get
			{
				return default(ServerState);
			}
		}

		public IEnumerable<string> InactiveIDs
		{
			//[IteratorStateMachine(typeof(_003Cget_InactiveIDs_003Ed__21))]
			get
			{
				return null;
			}
		}

		public bool KeepClean
		{
			set
			{
			}
		}

		public IEnumerable<IWebSocketSession> Sessions
		{
			get
			{
				return null;
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

		static WebSocketSessionManager()
		{
		}

		internal WebSocketSessionManager(Logger log)
			: base()
		{
		}

		private void broadcast(Opcode opcode, byte[] data, Action completed)
		{
		}

		private void broadcast(Opcode opcode, Stream stream, Action completed)
		{
		}

		private void broadcastAsync(Opcode opcode, byte[] data, Action completed)
		{
		}

		private void broadcastAsync(Opcode opcode, Stream stream, Action completed)
		{
		}

		private Dictionary<string, bool> broadping(byte[] frameAsBytes)
		{
			return null;
		}

		private bool canSet()
		{
			return default(bool);
		}

		private static string createID()
		{
			return null;
		}

		private void setSweepTimer(double interval)
		{
		}

		private void stop(PayloadData payloadData, bool send)
		{
		}

		internal string Add(IWebSocketSession session)
		{
			return null;
		}

		internal bool Remove(string id)
		{
			return default(bool);
		}

		internal void Start()
		{
		}

		internal void Stop(ushort code, string reason)
		{
		}

		public void BroadcastAsync(byte[] data, Action completed)
		{
		}

		public void BroadcastAsync(string data, Action completed)
		{
		}

		public void Sweep()
		{
		}
	}
}
