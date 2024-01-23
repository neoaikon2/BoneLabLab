using System;
using UnityEngine.Rendering;

namespace OccaSoftware.Exposure.Runtime
{
	[Serializable]
	public sealed class AutoExposureMeteringMaskModeParameter : VolumeParameter<AutoExposureMeteringMaskMode>
	{
		public AutoExposureMeteringMaskModeParameter(AutoExposureMeteringMaskMode value, bool overrideState = false)
			: base()
		{
		}
	}
}
