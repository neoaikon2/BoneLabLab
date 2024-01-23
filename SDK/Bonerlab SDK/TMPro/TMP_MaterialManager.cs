using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	public static class TMP_MaterialManager
	{
		private class FallbackMaterial
		{
			public long fallbackID;

			public Material sourceMaterial;

			internal int sourceMaterialCRC;

			public Material fallbackMaterial;

			public int count;

			public FallbackMaterial()
				: base()
			{
			}
		}

		private class MaskingMaterial
		{
			public Material baseMaterial;

			public Material stencilMaterial;

			public int count;

			public int stencilID;

			public MaskingMaterial()
				: base()
			{
			}
		}

		private static List<MaskingMaterial> m_materialList;

		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials;

		private static Dictionary<int, long> m_fallbackMaterialLookup;

		private static List<FallbackMaterial> m_fallbackCleanupList;

		private static bool isFallbackListDirty;

		static TMP_MaterialManager()
		{
		}

		private static void OnPreRender()
		{
		}

		public static Material GetStencilMaterial(Material baseMaterial, int stencilID)
		{
			return null;
		}

		public static void ReleaseStencilMaterial(Material stencilMaterial)
		{
		}

		public static Material GetBaseMaterial(Material stencilMaterial)
		{
			return null;
		}

		public static Material SetStencil(Material material, int stencilID)
		{
			return null;
		}

		public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID)
		{
		}

		public static void RemoveStencilMaterial(Material stencilMaterial)
		{
		}

		public static void ReleaseBaseMaterial(Material baseMaterial)
		{
		}

		public static void ClearMaterials()
		{
		}

		public static int GetStencilID(GameObject obj)
		{
			return default(int);
		}

		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			return null;
		}

		private static Transform FindRootSortOverrideCanvas(Transform start)
		{
			return null;
		}

		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			return null;
		}

		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			return null;
		}

		public static void AddFallbackMaterialReference(Material targetMaterial)
		{
		}

		public static void RemoveFallbackMaterialReference(Material targetMaterial)
		{
		}

		public static void CleanupFallbackMaterials()
		{
		}

		public static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
		}

		public static void CopyMaterialPresetProperties(Material source, Material destination)
		{
		}
	}
}
