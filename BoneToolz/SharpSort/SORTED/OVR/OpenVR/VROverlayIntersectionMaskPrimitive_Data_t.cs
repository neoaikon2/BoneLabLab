using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	[StructLayout(2)]
	public struct VROverlayIntersectionMaskPrimitive_Data_t
	{
		public IntersectionMaskRectangle_t m_Rectangle;

		public IntersectionMaskCircle_t m_Circle;
	}
}
