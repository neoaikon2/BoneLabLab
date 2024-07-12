using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	[NativeLibToken(NativeLibToken = NativeLibToken.Remoting)]
	internal class AppRemotingPlugin : OpenXRFeaturePlugin<AppRemotingPlugin>
	{
		private enum RemotingState
		{
			Idle = 0,
			Connect = 1,
			Listen = 2,
			Disconnecting = 3
		}

		private class AppRemotingDisconnectHelper : MonoBehaviour
		{
			private void Start()
			{
			}

			public static IEnumerator NotifySubsystemDestroyAndDisconnect()
			{
				return null;
			}

			public AppRemotingDisconnectHelper()
				: base()
			{
			}
		}

		private static RemotingState s_remotingState;

		private RemotingConfiguration m_remotingConfiguration;

		private RemotingListenConfiguration m_remotingListenConfiguration;

		private SecureConnectionServerConfiguration m_secureConnectionServerConfiguration;

		internal const string featureId = "com.microsoft.openxr.feature.appremoting";

		internal const string featureName = "Holographic Remoting remote app";

		private const string requestedExtensions = "XR_MSFT_holographic_remoting XR_MSFT_holographic_remoting_speech";

		private bool m_runtimeOverrideAttempted;

		private OpenXRRuntimeRestartHandler m_restartHandler;

		private readonly bool m_appRemotingIsActive;

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}

		private new void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnInstanceDestroy(ulong instance)
		{
		}

		protected override void OnSystemChange(ulong systemId)
		{
		}

		protected override void OnSessionStateChange(int oldState, int newState)
		{
		}

		public IEnumerator Connect(RemotingConfiguration configuration)
		{
			return null;
		}

		public IEnumerator Listen(RemotingListenConfiguration configuration, SecureConnectionServerConfiguration secureConnectionServerConfiguration, Action onRemotingListenCompleted = default(Action))
		{
			return null;
		}

		public void Disconnect()
		{
		}

		private static void StopXrLoader()
		{
		}

		public bool TryGetConnectionState([Out] ConnectionState connectionState, [Out] DisconnectReason disconnectReason)
		{
			return default(bool);
		}

		public bool TryLocateUserReferenceSpace(FrameTime frameTime, [Out] Pose pose)
		{
			return default(bool);
		}

		public AppRemotingPlugin()
			: base()
		{
		}
	}
}
