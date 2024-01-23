using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro.SpriteAssetUtilities
{
	public class TexturePacker_JsonArray
	{
		[Serializable]
		public struct SpriteFrame
		{
			public float x;

			public float y;

			public float w;

			public float h;

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public struct SpriteSize
		{
			public float w;

			public float h;

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public struct Frame
		{
			public string filename;

			public SpriteFrame frame;

			public bool rotated;

			public bool trimmed;

			public SpriteFrame spriteSourceSize;

			public SpriteSize sourceSize;

			public Vector2 pivot;
		}

		[Serializable]
		public struct Meta
		{
			public string app;

			public string version;

			public string image;

			public string format;

			public SpriteSize size;

			public float scale;

			public string smartupdate;
		}

		[Serializable]
		public class SpriteDataObject
		{
			public List<Frame> frames;

			public Meta meta;

			public SpriteDataObject()
				: base()
			{
			}
		}

		public TexturePacker_JsonArray()
			: base()
		{
		}
	}
}
