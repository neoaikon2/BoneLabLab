using UnityEngine;

public static class TextureExtentions
{
	public static void SetComputeBuffer(this ComputeShader shader, string name, int kernel, ComputeBuffer buffer)
	{
	}

	public static RenderTexture Copy3DSliceToRenderTexture(RenderTexture source, int layer)
	{
		return null;
	}

	public static Texture2D ConvertFromRenderTexture(RenderTexture rt)
	{
		return null;
	}

	public static Texture2D ConvertToTexture2D(this RenderTexture rt)
	{
		return null;
	}

	public static Vector2Int GetImageSize(this Texture2D asset)
	{
		return default(Vector2Int);
	}

	public static void Clear(this RenderTexture renderTexture)
	{
	}

	public static void SaveToTexture3D(this RenderTexture Rtex3d, string NameAtPath)
	{
	}

	public static TextureFileExtension GetTextureExtension(this string path)
	{
		return default(TextureFileExtension);
	}

	public static byte[] EncodeTexture(this Texture2D tex, TextureFileExtension textureFileExtension)
	{
		return null;
	}
}
