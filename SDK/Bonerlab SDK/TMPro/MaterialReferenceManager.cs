using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace TMPro
{
	public class MaterialReferenceManager
	{
		private static MaterialReferenceManager s_Instance;

		private Dictionary<int, Material> m_FontMaterialReferenceLookup;

		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup;

		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup;

		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup;

		public static MaterialReferenceManager instance
		{
			get
			{
				return null;
			}
		}

		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
		}

		private void AddFontAssetInternal(TMP_FontAsset fontAsset)
		{
		}

		public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset)
		{
		}

		private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset)
		{
		}

		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		public static void AddFontMaterial(int hashCode, Material material)
		{
		}

		private void AddFontMaterialInternal(int hashCode, Material material)
		{
		}

		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		public bool Contains(TMP_FontAsset font)
		{
			return default(bool);
		}

		public bool Contains(TMP_SpriteAsset sprite)
		{
			return default(bool);
		}

		public static bool TryGetFontAsset(int hashCode, [Out] TMP_FontAsset fontAsset)
		{
			return default(bool);
		}

		private bool TryGetFontAssetInternal(int hashCode, [Out] TMP_FontAsset fontAsset)
		{
			return default(bool);
		}

		public static bool TryGetSpriteAsset(int hashCode, [Out] TMP_SpriteAsset spriteAsset)
		{
			return default(bool);
		}

		private bool TryGetSpriteAssetInternal(int hashCode, [Out] TMP_SpriteAsset spriteAsset)
		{
			return default(bool);
		}

		public static bool TryGetColorGradientPreset(int hashCode, [Out] TMP_ColorGradient gradientPreset)
		{
			return default(bool);
		}

		private bool TryGetColorGradientPresetInternal(int hashCode, [Out] TMP_ColorGradient gradientPreset)
		{
			return default(bool);
		}

		public static bool TryGetMaterial(int hashCode, [Out] Material material)
		{
			return default(bool);
		}

		private bool TryGetMaterialInternal(int hashCode, [Out] Material material)
		{
			return default(bool);
		}

		public MaterialReferenceManager()
			: base()
		{
		}
	}
}
