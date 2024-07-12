using System;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	[NativeLibToken(NativeLibToken = NativeLibToken.Remoting)]
	internal class PlayModeRemotingPlugin : OpenXRFeaturePlugin<PlayModeRemotingPlugin>
	{
		internal const string featureId = "com.microsoft.openxr.feature.playmoderemoting";

		internal const string featureName = "Holographic Remoting for Play Mode";

		private const string requestedExtensions = "XR_MSFT_holographic_remoting XR_MSFT_holographic_remoting_speech";

		private const string SettingsFileName = "MixedRealityOpenXRRemotingSettings.asset";

		[SerializeField]
		[Obsolete("Use the remotingSettings values instead")]
		[Tooltip("The host name or IP address of the player running in network server mode to connect to.")]
		private string m_remoteHostName;

		[Obsolete("Use the remotingSettings values instead")]
		[Tooltip("The port number of the server's handshake port.")]
		[SerializeField]
		private ushort m_remoteHostPort;

		[Obsolete("Use the remotingSettings values instead")]
		[Tooltip("The max bitrate in Kbps to use for the connection.")]
		[SerializeField]
		private uint m_maxBitrate;

		[Tooltip("The video codec to use for the connection.")]
		[SerializeField]
		[Obsolete("Use the remotingSettings values instead")]
		private RemotingVideoCodec m_videoCodec;

		[SerializeField]
		[Tooltip("Enable/disable audio remoting.")]
		[Obsolete("Use the remotingSettings values instead")]
		private bool m_enableAudio;

		private bool m_runtimeOverrideAttempted;

		private readonly bool m_playModeRemotingIsActive;

		private RemotingSettings m_remotingSettings;

		private static string UserSettingsFolder
		{
			get
			{
				return null;
			}
		}

		private static string SettingsAssetPath
		{
			get
			{
				return null;
			}
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
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

		internal RemotingSettings GetOrLoadRemotingSettings()
		{
			return null;
		}

		public PlayModeRemotingPlugin()
			: base()
		{
		}
	}
}
