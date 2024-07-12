using System.Runtime.InteropServices;
using SLZ.Marrow.Audio;

namespace SLZ.Bonelab.VoidLogic
{
	internal class AudioPlayerAndClipPair
	{
		public AudioPlayer AudioPlayer;

		public ClipPair ClipPair;

		public void Deconstruct([Out] AudioPlayer audioPlayer, [Out] ClipPair clipPair)
		{
		}

		public AudioPlayerAndClipPair()
			: base()
		{
		}
	}
}
