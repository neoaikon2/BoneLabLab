using UnityEngine;

namespace SLZ.Props
{
	[CreateAssetMenu(fileName = "Song", menuName = "StressLevelZero/Radio/Song")]
	public class RadioSong : ScriptableObject
	{
		public new string name;

		public string artist;

		public AudioClip audioClip;

		public RadioSong()
			: base()
		{
		}
	}
}
