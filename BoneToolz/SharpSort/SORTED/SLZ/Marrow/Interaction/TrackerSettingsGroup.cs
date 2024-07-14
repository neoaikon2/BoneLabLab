using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class TrackerSettingsGroup
	{
		[SerializeField]
		public TrackerLayers layers;

		[SerializeField]
		public TrackerSettings[] settings;
	}
}
