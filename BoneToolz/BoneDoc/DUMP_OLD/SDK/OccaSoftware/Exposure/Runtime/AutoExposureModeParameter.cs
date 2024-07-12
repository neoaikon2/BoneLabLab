using System;
using UnityEngine.Rendering;

namespace OccaSoftware.Exposure.Runtime
{
	[Serializable]
	public sealed class AutoExposureModeParameter : VolumeParameter<AutoExposureMode>
	{
		public AutoExposureModeParameter(AutoExposureMode value, bool overrideState = false)
			: base()
		{
		}
	}
}
