namespace SLZ.Interaction
{
	public struct HandGripPair
	{
		public Hand hand;

		public Grip grip;

		public HandGripPair(Hand h, Grip g)
		{
			hand = h;
			grip = g;
		}

		public void Clear()
		{
		}
	}
}
