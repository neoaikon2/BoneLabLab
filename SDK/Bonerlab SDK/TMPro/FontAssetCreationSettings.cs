using System;

namespace TMPro
{
	[Serializable]
	public struct FontAssetCreationSettings
	{
		public string sourceFontFileName;

		public string sourceFontFileGUID;

		public int pointSizeSamplingMode;

		public int pointSize;

		public int padding;

		public int packingMode;

		public int atlasWidth;

		public int atlasHeight;

		public int characterSetSelectionMode;

		public string characterSequence;

		public string referencedFontAssetGUID;

		public string referencedTextAssetGUID;

		public int fontStyle;

		public float fontStyleModifier;

		public int renderMode;

		public bool includeFontFeatures;

		internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)
		{
			this.includeFontFeatures = default(bool);
			this.renderMode = default(int);
			this.fontStyleModifier = default(float);
			this.fontStyle = default(int);
			this.referencedTextAssetGUID = default(string);
			this.referencedFontAssetGUID = default(string);
			this.characterSequence = default(string);
			this.characterSetSelectionMode = default(int);
			this.atlasHeight = default(int);
			this.atlasWidth = default(int);
			this.packingMode = default(int);
			this.padding = default(int);
			this.pointSize = default(int);
			this.pointSizeSamplingMode = default(int);
			this.sourceFontFileGUID = default(string);
			this.sourceFontFileName = default(string);
		}
	}
}
