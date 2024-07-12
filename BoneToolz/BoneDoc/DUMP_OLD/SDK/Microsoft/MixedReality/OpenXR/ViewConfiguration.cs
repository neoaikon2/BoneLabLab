using System.Collections.Generic;

namespace Microsoft.MixedReality.OpenXR
{
	public struct ViewConfiguration
	{
		private static readonly MixedRealityFeaturePlugin m_feature;

		internal readonly OpenXRViewConfiguration m_openxrViewConfiguration;

		public static IReadOnlyList<ViewConfiguration> EnabledViewConfigurations
		{
			get
			{
				return null;
			}
		}

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

		internal ViewConfiguration(OpenXRViewConfiguration openxrViewConfiguration)
		{
			this.m_openxrViewConfiguration = default(OpenXRViewConfiguration);
		}

		public void SetReprojectionSettings(ReprojectionSettings settings)
		{
		}
	}
}
