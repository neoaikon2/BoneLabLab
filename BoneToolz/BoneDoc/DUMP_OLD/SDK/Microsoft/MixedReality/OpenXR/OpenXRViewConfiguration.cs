using System.Collections.Generic;

namespace Microsoft.MixedReality.OpenXR
{
	internal struct OpenXRViewConfiguration
	{
		private NativeLibToken m_nativeLibToken;

		private ViewConfigurationType m_viewConfigurationType;

		private ReprojectionMode[] m_supportedReprojectionModes;

		public ViewConfigurationType ViewConfigurationType
		{
			get
			{
				return default(ViewConfigurationType);
			}
		}

		public bool IsActive
		{
			get
			{
				return default(bool);
			}
		}

		public IReadOnlyList<ReprojectionMode> SupportedReprojectionModes
		{
			get
			{
				return null;
			}
		}

		internal bool HasTrackingFlags(NativeSpaceLocationFlags nativeSpaceLocationFlags)
		{
			return default(bool);
		}

		public OpenXRViewConfiguration(NativeLibToken nativeLibToken, ViewConfigurationType viewConfigurationType)
		{
			this.m_supportedReprojectionModes = default(ReprojectionMode[]);
			this.m_viewConfigurationType = default(ViewConfigurationType);
			this.m_nativeLibToken = default(NativeLibToken);
		}

		public void SetReprojectionSettings(ReprojectionSettings reprojectionSettings)
		{
		}
	}
}
