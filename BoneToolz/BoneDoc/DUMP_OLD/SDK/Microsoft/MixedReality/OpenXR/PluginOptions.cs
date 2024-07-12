using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 2)]
	internal struct PluginOptions
	{
		private byte m_disableFirstPersonObserver;

		private byte m_enablePoseUpdateOnBeforeRender;

		public bool DisableFirstPersonObserver
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnablePoseUpdateOnBeforeRender
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}
	}
}
