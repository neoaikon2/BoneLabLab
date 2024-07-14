using System;

namespace OVR.OpenVR
{
	public struct RenderModel_t
	{
		public IntPtr rVertexData;

		public uint unVertexCount;

		public IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;
	}
}
