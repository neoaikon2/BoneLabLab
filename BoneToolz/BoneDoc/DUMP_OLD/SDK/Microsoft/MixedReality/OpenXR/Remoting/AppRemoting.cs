using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	public static class AppRemoting
	{
		private static readonly AppRemotingPlugin m_appRemotingPlugin;

		public static IEnumerator Connect(RemotingConfiguration configuration)
		{
			return null;
		}

		public static IEnumerator Listen(RemotingListenConfiguration listenConfiguration, Action onRemotingListenCompleted = default(Action))
		{
			return null;
		}

		public static void Disconnect()
		{
		}

		public static bool TryGetConnectionState([Out] ConnectionState connectionState, [Out] DisconnectReason disconnectReason)
		{
			return default(bool);
		}

		public static bool TryLocateUserReferenceSpace(FrameTime frameTime, [Out] Pose pose)
		{
			return default(bool);
		}
	}
}
