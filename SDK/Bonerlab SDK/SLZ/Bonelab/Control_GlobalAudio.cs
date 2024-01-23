using UnityEngine;

namespace SLZ.Bonelab
{
	public class Control_GlobalAudio : MonoBehaviour
	{
		private static Control_GlobalAudio _instance;

		private Control_Player ctrl_Player;

		private float safeguardaudio;

		public static Control_GlobalAudio instance => null;

		[HideInInspector]
		public float audio_GlobalVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
