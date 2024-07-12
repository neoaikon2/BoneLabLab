namespace MK.Glow
{
	internal struct RenderDimension : IDimension
	{
		public int width { get; set; }

		public int height { get; set; }

		public RenderDimension renderDimension => default(RenderDimension);

		public RenderDimension(int width, int height)
		{
			this.width = 0;
			this.height = 0;
		}
	}
}
