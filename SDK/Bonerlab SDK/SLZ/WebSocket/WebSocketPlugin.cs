using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using JetBrains.Annotations;
using SLZ.Marrow.Plugins;
using SLZ.SaveData;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace SLZ.WebSocket
{
	[MarrowPlugin("com.stresslevelzero.plugins", "BoneSocket", "0.0.1")]
	public class WebSocketPlugin : IMarrowPluginRunCallbacks, IMarrowPlugin
	{
		private static readonly Dictionary<string, string> mimeTypes;

		private HttpServer _server;

		private DebugConsoleWebSocketBehavior _debugConsole;

		private SynchronizationContext _mainThreadSyncContext;

		private FileStream _clientZipFileStream;

		private ZipArchive _clientZipArchive;

		private int _port;

		private Dictionary<string, Action<HttpRequestEventArgs>> commands;

		public int Port
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public event PropertyChangingEventHandler PropertyChanging
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

		public event PropertyChangedEventHandler PropertyChanged
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

		[MarrowPluginRegisterMethod]
		public static void RegisterPlugin(IMarrowPluginRegistration registration)
		{
		}

		public void OnMarrowPluginLoad()
		{
		}

		private void HandleDataManagerEvent(object sender, DataManagerEventArgs args)
		{
		}

		public void OnMarrowPluginStart()
		{
		}

		public void OnMarrowPluginStop()
		{
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
			return false;
		}

		private bool TrySetContentTypeFromFileExtension(HttpListenerResponse res, string extension)
		{
			return false;
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
		private void OnPropertyChanging([CallerMemberName] string propertyName = null)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
		}
	}
}
