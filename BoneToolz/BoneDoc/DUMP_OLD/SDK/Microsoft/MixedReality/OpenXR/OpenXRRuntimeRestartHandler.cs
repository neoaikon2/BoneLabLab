using System;
using System.Runtime.InteropServices;
using UnityEngine.XR.OpenXR.Features;

namespace Microsoft.MixedReality.OpenXR
{
	internal class OpenXRRuntimeRestartHandler : IDisposable
	{
		private readonly string m_featureName;

		private readonly bool? m_skipRestart;

		private readonly bool? m_skipQuitApp;

		public OpenXRRuntimeRestartHandler(OpenXRFeature feature, bool? skipRestart = default(bool?), bool? skipQuitApp = default(bool?))
			: base()
		{
		}

		public void Dispose()
		{
		}

		private bool OpenXRRuntime_wantsToQuit()
		{
			return default(bool);
		}

		private bool OpenXRRuntime_wantsToRestart()
		{
			return default(bool);
		}
	}
}
