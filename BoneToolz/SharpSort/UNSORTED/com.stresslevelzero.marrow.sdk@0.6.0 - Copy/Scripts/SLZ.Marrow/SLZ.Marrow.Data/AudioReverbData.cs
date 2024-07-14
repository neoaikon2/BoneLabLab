using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[CreateAssetMenu(fileName = "AudioReverbData", menuName = "StressLevelZero/Audio Reverb Data", order = 2)]
	public class AudioReverbData : ScriptableObject
	{
		[Serializable]
		public struct ReverbData
		{
			public string paramName;

			public float paramValue;

			[HideInInspector]
			public float minRange;

			[HideInInspector]
			public float maxRange;

			public ReverbData(string name, float val, float min, float max)
			{
				paramName = null;
				paramValue = 0f;
				minRange = 0f;
				maxRange = 0f;
			}
		}

		public ReverbData[] reverbData;
	}
}
