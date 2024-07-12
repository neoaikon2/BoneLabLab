using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace SLZ.Bonelab
{
	[MarrowPlugin("com.stresslevelzero.plugins", "BoneSocket", "0.0.1")]
	public class WebSocketPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		private static readonly Dictionary<string, string> mimeTypes;

		private HttpServer _server;

		private DebugConsoleWebSocketBehavior _debugConsole;

		private SynchronizationContext _mainThreadSyncContext;

		private int _port;

		private Dictionary<string, Action<HttpRequestEventArgs>> commands;

		public int Port
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		UniTask IMarrowPlugin.OnMarrowPluginLoad()
		{
			return default(UniTask);
		}

		UniTask IMarrowPluginRunCallbacks.OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		UniTask IMarrowPluginRunCallbacks.OnMarrowPluginStop()
		{
			return default(UniTask);
		}

		public void StartServer()
		{
		}

		public void StopServer()
		{
		}

		private void HTTPServer_OnGetOrPost(object sender, HttpRequestEventArgs e)
		{
		}

		private bool TryRunCommand(HttpRequestEventArgs e)
		{
			return default(bool);
		}

		private bool TrySetContentTypeFromFileExtension(HttpListenerResponse res, string extension)
		{
			return default(bool);
		}

		private void SetUTF8EncodingIfText(HttpListenerResponse res, string contentType)
		{
		}

		private void Command_HelloWorld(HttpRequestEventArgs e)
		{
		}

		private void Command_Chunks(HttpRequestEventArgs e)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = default(string))
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = default(string))
		{
		}

		public WebSocketPlugin()
			: base()
		{
		}

		public event PropertyChangingEventHandler PropertyChanging;

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
