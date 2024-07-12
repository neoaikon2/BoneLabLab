using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using SLZ.ModIO;
using SLZ.ModIO.ApiModels;
using SLZ.ModIO.WebSockets;
using UnityEngine;

namespace SLZ.Marrow.Forklift
{
	public class ModIOManager : MonoBehaviour
	{
		public delegate UniTask LoginSequenceHandler();

		public delegate UniTask UserCodePromptHandler(DeviceLoginResponseContext loginResponseContext);

		private CancellationTokenSource _enableCTS;

		private CancellationTokenSource _receiveLoopCTS;

		private static string ModIOSettingsPath
		{
			get
			{
				return null;
			}
		}

		public string ModIOApiKey { get; private set; }

		public int ModIOGameId { get; private set; }

		public bool IsLoggedIn { get; private set; }

		public ModIOAPI ModIOAPI { get; private set; }

		public ModIOWebSocketAPI ModIOWebSocketAPI { get; private set; }

		[CanBeNull]
		public JObject ModSettingsJSON { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public UniTask<bool> LoadAndCheckLogin(CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		public UniTaskVoid LogIn(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		private Task ApiOnMessageReceived(Message message)
		{
			return null;
		}

		private UniTask ApiOnMessageReceivedUT(Message message)
		{
			return default(UniTask);
		}

		private UniTask<bool> ValidateAccessToken(string accessToken, CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		private static UniTask<JObject> LoadModSettings(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<JObject>);
		}

		private static RequestContext _oneOffRequestContext(string apiKey, string accessToken)
		{
			return null;
		}

		public ModIOManager()
			: base()
		{
		}

		public event LoginSequenceHandler BeginUserInitiatedLogin;

		public event UserCodePromptHandler RequestUserCodeEntry;

		public event LoginSequenceHandler CompleteUserInitiatedLogin;

		public event LoginSequenceHandler FailUserInitiatedLogin;
	}
}
