using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_ktx_texture")]
public class OVRKtxTexture
{
	private const uint KTX_TTF_BC7_RGBA = 6u;

	private const uint KTX_TTF_ASTC_4x4_RGBA = 10u;

	public static bool Load(byte[] data, ref OVRTextureData ktxData)
	{
		return false;
	}
}
