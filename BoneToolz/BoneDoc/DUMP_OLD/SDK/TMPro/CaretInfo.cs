namespace TMPro
{
	public struct CaretInfo
	{
		public int index;

		public CaretPosition position;

		public CaretInfo(int index, CaretPosition position)
		{
			this.position = default(CaretPosition);
			this.index = default(int);
		}
	}
}
