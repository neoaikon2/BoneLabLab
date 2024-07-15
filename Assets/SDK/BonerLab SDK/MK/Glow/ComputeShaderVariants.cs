using System.Collections.Generic;

namespace MK.Glow
{
	internal sealed class ComputeShaderVariants
	{
		internal static class KeywordValues
		{
			internal const int BLOOM = 1;

			internal const int LENS_SURFACE = 1;

			internal const int LENS_FLARE = 1;

			internal const int GLARE = 4;

			internal const int MK_NATURAL = 1;

			internal const int RENDER_PRIORITY = 2;
		}

		internal struct KeywordState
		{
			public int bloom;

			public int lensSurface;

			public int lensFlare;

			public int glare;

			public int natural;

			public int renderPriority;

			public KeywordState(int bloom, int lensSurface, int lensFlare, int glare, int natural, int renderPriority)
			{
				this.bloom = 0;
				this.lensSurface = 0;
				this.lensFlare = 0;
				this.glare = 0;
				this.natural = 0;
				this.renderPriority = 0;
			}
		}

		private Dictionary<KeywordState, int> variants;

		internal void GetVariantNumber(KeywordState features, out int index)
		{
			index = default(int);
		}

		public ComputeShaderVariants(int offset)
		{
		}
	}
}
