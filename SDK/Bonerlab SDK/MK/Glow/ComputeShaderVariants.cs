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

			public KeywordState(int _bloom, int _lensSurface, int _lensFlare, int _glare, int _natural, int _renderPriority)
			{
				bloom = _bloom;
				lensSurface = _lensSurface;
				lensFlare = _lensFlare;
				glare = _glare;
				natural = _natural;
				renderPriority = _renderPriority;
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
