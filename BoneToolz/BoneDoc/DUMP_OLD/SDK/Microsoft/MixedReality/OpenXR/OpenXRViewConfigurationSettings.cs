using System;
using System.Collections.Generic;

namespace Microsoft.MixedReality.OpenXR
{
	internal class OpenXRViewConfigurationSettings : SubsystemController
	{
		private readonly NativeLibToken m_nativeLibToken;

		private List<ViewConfiguration> m_enabledViewConfigurations;

		public IReadOnlyList<ViewConfiguration> EnabledViewConfigurations
		{
			get
			{
				return null;
			}
		}

		public OpenXRViewConfigurationSettings(NativeLibToken token, IOpenXRContext context)
			: base(context)
		{
		}

		private void Context_SessionBegun(IOpenXRContext sender, EventArgs args)
		{
		}

		private void Context_SessionEnding(IOpenXRContext sender, EventArgs args)
		{
		}
	}
}
