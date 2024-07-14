namespace Oculus.Platform.Models
{
	public class PingResult
	{
		private ulong? pingTimeUsec;

		public ulong ID { get; private set; }

		public ulong PingTimeUsec => 0uL;

		public bool IsTimeout => false;

		public PingResult(ulong id, ulong? pingTimeUsec)
		{
		}
	}
}
