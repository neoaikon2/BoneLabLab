using System;

namespace Microsoft.MixedReality.OpenXR
{
	public class OpenXRContext
	{
		private static OpenXRContext m_current;

		private readonly MixedRealityFeaturePlugin m_feature;

		public static OpenXRContext Current
		{
			get
			{
				return null;
			}
		}

		public ulong Instance
		{
			get
			{
				return default(ulong);
			}
		}

		public ulong SystemId
		{
			get
			{
				return default(ulong);
			}
		}

		public ulong Session
		{
			get
			{
				return default(ulong);
			}
		}

		public bool IsSessionRunning
		{
			get
			{
				return default(bool);
			}
		}

		public ulong SceneOriginSpace
		{
			get
			{
				return default(ulong);
			}
		}

		public IntPtr PFN_xrGetInstanceProcAddr
		{
			get
			{
				return default(IntPtr);
			}
		}

		private OpenXRContext()
			: base()
		{
		}
	}
}
