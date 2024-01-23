using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Graphics2.VRS
{
	public class VRSOverrideSettingsCache
	{
		public class OverrideSettings
		{
			public CameraVRSOverride overrideSettings;

			public bool hasOverride;

			public OverrideSettings()
				: base()
			{
			}
		}

		public Dictionary<Camera, OverrideSettings> perCameraOverride;

		private int purgeCounter;

		private int purgeMax;

		public void RemoveCamera(Camera cam)
		{
		}

		public OverrideSettings GetVRSSettings(Camera cam)
		{
			return null;
		}

		public void RemoveAllNull()
		{
		}

		public VRSOverrideSettingsCache()
			: base()
		{
		}
	}
}
