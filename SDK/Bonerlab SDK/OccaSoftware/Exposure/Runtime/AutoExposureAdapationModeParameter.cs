using System;
using UnityEngine.Rendering;

namespace OccaSoftware.Exposure.Runtime
{
	[Serializable]
	public sealed class AutoExposureAdapationModeParameter : VolumeParameter<AutoExposureAdaptationMode>
	{
		public AutoExposureAdapationModeParameter(AutoExposureAdaptationMode value, bool overrideState = false)
			: base()
		{
		}
	}
}
