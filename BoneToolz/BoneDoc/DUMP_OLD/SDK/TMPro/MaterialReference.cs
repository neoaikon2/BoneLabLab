using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public struct MaterialReference
	{
		public int index;

		public TMP_FontAsset fontAsset;

		public TMP_SpriteAsset spriteAsset;

		public Material material;

		public bool isDefaultMaterial;

		public bool isFallbackMaterial;

		public Material fallbackMaterial;

		public float padding;

		public int referenceCount;

		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
		{
			this.referenceCount = default(int);
			this.padding = default(float);
			this.fallbackMaterial = default(Material);
			this.isFallbackMaterial = default(bool);
			this.isDefaultMaterial = default(bool);
			this.material = default(Material);
			this.spriteAsset = default(TMP_SpriteAsset);
			this.fontAsset = default(TMP_FontAsset);
			this.index = default(int);
		}

		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset)
		{
			return default(bool);
		}

		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return default(int);
		}

		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return default(int);
		}
	}
}
