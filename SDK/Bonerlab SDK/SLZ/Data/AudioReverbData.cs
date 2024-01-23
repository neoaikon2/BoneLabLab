using System;
using UnityEngine;

namespace SLZ.Data
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
				paramName = name;
				paramValue = val;
				minRange = min;
				maxRange = max;
			}
		}

		public ReverbData[] reverbData;
	}
}
