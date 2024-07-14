namespace Oculus.Platform
{
	public class VoipPCMSourceNative : IVoipPCMSource
	{
		private ulong senderID;

		public int GetPCM(float[] dest, int length)
		{
			return 0;
		}

		public void SetSenderID(ulong senderID)
		{
		}

		public int PeekSizeElements()
		{
			return 0;
		}

		public void Update()
		{
		}
	}
}
