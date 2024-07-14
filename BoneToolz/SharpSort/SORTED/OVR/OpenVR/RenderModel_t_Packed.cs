using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct RenderModel_t_Packed
	{
		public IntPtr rVertexData;

		public uint unVertexCount;

		public IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;

		public RenderModel_t_Packed(RenderModel_t unpacked)
		{
			rVertexData = (IntPtr)0;
			unVertexCount = 0u;
			rIndexData = (IntPtr)0;
			unTriangleCount = 0u;
			diffuseTextureId = 0;
		}

		public void Unpack(ref RenderModel_t unpacked)
		{
		}
	}
}
