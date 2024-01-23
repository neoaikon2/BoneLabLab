namespace MK.Glow
{
	internal struct RenderDimension : IDimension
	{
		public int width { get; set; }

		public int height { get; set; }

		public RenderDimension renderDimension => default(RenderDimension);

		public RenderDimension(int _width, int _height)
		{
			width = _width;
			height = _height;
		}
	}
}
