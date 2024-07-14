using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct RenderModel_TextureMap_t_Packed
	{
		public ushort unWidth;

		public ushort unHeight;

		public IntPtr rubTextureMapData;

		public RenderModel_TextureMap_t_Packed(RenderModel_TextureMap_t unpacked)
		{
			unWidth = 0;
			unHeight = 0;
			rubTextureMapData = (IntPtr)0;
		}

		public void Unpack(ref RenderModel_TextureMap_t unpacked)
		{
		}
	}
}
