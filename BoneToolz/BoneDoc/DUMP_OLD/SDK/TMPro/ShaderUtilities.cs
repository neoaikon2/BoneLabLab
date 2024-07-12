using UnityEngine;

namespace TMPro
{
	public static class ShaderUtilities
	{
		public static int ID_MainTex;

		public static int ID_FaceTex;

		public static int ID_FaceColor;

		public static int ID_FaceDilate;

		public static int ID_Shininess;

		public static int ID_UnderlayColor;

		public static int ID_UnderlayOffsetX;

		public static int ID_UnderlayOffsetY;

		public static int ID_UnderlayDilate;

		public static int ID_UnderlaySoftness;

		public static int ID_UnderlayOffset;

		public static int ID_UnderlayIsoPerimeter;

		public static int ID_WeightNormal;

		public static int ID_WeightBold;

		public static int ID_OutlineTex;

		public static int ID_OutlineWidth;

		public static int ID_OutlineSoftness;

		public static int ID_OutlineColor;

		public static int ID_Outline2Color;

		public static int ID_Outline2Width;

		public static int ID_Padding;

		public static int ID_GradientScale;

		public static int ID_ScaleX;

		public static int ID_ScaleY;

		public static int ID_PerspectiveFilter;

		public static int ID_Sharpness;

		public static int ID_TextureWidth;

		public static int ID_TextureHeight;

		public static int ID_BevelAmount;

		public static int ID_GlowColor;

		public static int ID_GlowOffset;

		public static int ID_GlowPower;

		public static int ID_GlowOuter;

		public static int ID_GlowInner;

		public static int ID_LightAngle;

		public static int ID_EnvMap;

		public static int ID_EnvMatrix;

		public static int ID_EnvMatrixRotation;

		public static int ID_MaskCoord;

		public static int ID_ClipRect;

		public static int ID_MaskSoftnessX;

		public static int ID_MaskSoftnessY;

		public static int ID_VertexOffsetX;

		public static int ID_VertexOffsetY;

		public static int ID_UseClipRect;

		public static int ID_StencilID;

		public static int ID_StencilOp;

		public static int ID_StencilComp;

		public static int ID_StencilReadMask;

		public static int ID_StencilWriteMask;

		public static int ID_ShaderFlags;

		public static int ID_ScaleRatio_A;

		public static int ID_ScaleRatio_B;

		public static int ID_ScaleRatio_C;

		public static string Keyword_Bevel;

		public static string Keyword_Glow;

		public static string Keyword_Underlay;

		public static string Keyword_Ratios;

		public static string Keyword_MASK_SOFT;

		public static string Keyword_MASK_HARD;

		public static string Keyword_MASK_TEX;

		public static string Keyword_Outline;

		public static string ShaderTag_ZTestMode;

		public static string ShaderTag_CullMode;

		private static float m_clamp;

		public static bool isInitialized;

		private static Shader k_ShaderRef_MobileSDF;

		private static Shader k_ShaderRef_MobileBitmap;

		internal static Shader ShaderRef_MobileSDF
		{
			get
			{
				return null;
			}
		}

		internal static Shader ShaderRef_MobileBitmap
		{
			get
			{
				return null;
			}
		}

		static ShaderUtilities()
		{
		}

		public static void GetShaderPropertyIDs()
		{
		}

		public static void UpdateShaderRatios(Material mat)
		{
		}

		public static Vector4 GetFontExtent(Material material)
		{
			return default(Vector4);
		}

		public static bool IsMaskingEnabled(Material material)
		{
			return default(bool);
		}

		public static float GetPadding(Material material, bool enableExtraPadding, bool isBold)
		{
			return default(float);
		}

		public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold)
		{
			return default(float);
		}
	}
}
