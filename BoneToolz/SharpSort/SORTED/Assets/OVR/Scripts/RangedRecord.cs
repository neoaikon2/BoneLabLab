namespace Assets.OVR.Scripts
{
	public class RangedRecord : Record
	{
		public float value;

		public float min;

		public float max;

		public RangedRecord(int order, string cat, string msg, float val, float minVal, float maxVal)
			: base(0, null, null)
		{
		}
	}
}
