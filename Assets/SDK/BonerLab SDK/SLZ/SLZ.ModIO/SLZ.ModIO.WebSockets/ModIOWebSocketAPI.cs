using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	public sealed class ModIOWebSocketAPI : IDisposable
	{
		public delegate Task MessageReceivedHandler(Message message);
		private readonly ILogger logger;

		private readonly JsonSerializerSettings _serializerSettings;

		private bool _disposed;

		private readonly ConcurrentQueue<Message> _messages;

		public ClientWebSocket Client { get; private set; }

		public string WebsocketEndpoint { get; }

		public event MessageReceivedHandler MessageReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ModIOWebSocketAPI(ILogger logger, int gameId)
		{
		}

		~ModIOWebSocketAPI()
		{
		}

		[PublicAPI]
		public Task ConnectAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task CloseConnectionAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public void Dispose()
		{
		}
		public ValueTask DisposeAsync()
		{
			return default(ValueTask);
		}

		private void Dispose(bool disposing)
		{
		}
		private ValueTask DisposeAsyncCore()
		{
			return default(ValueTask);
		}

		private void CheckDisposed()
		{
		}

		public void EnqueueOperation(Message message)
		{
		}
		public Task SendOperationsAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
		public Task RunReceiveLoopAsync(CancellationToken cancellationToken)
		{
			return null;
		}
		private Task<MessageContainer> ReceiveAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
