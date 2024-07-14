using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct IVRChaperone
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ChaperoneCalibrationState _GetCalibrationState();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ReloadInfo();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetSceneColor(HmdColor_t color);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _AreBoundsVisible();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _ForceBoundsVisible(bool bForce);

		internal _GetCalibrationState GetCalibrationState;

		internal _GetPlayAreaSize GetPlayAreaSize;

		internal _GetPlayAreaRect GetPlayAreaRect;

		internal _ReloadInfo ReloadInfo;

		internal _SetSceneColor SetSceneColor;

		internal _GetBoundsColor GetBoundsColor;

		internal _AreBoundsVisible AreBoundsVisible;

		internal _ForceBoundsVisible ForceBoundsVisible;
	}
}
