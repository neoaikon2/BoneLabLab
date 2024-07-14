using System;

namespace OVR.OpenVR
{
	public class CVRChaperone
	{
		private IVRChaperone FnTable;

		internal CVRChaperone(IntPtr pInterface)
		{
		}

		public ChaperoneCalibrationState GetCalibrationState()
		{
			return default(ChaperoneCalibrationState);
		}

		public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return false;
		}

		public bool GetPlayAreaRect(ref HmdQuad_t rect)
		{
			return false;
		}

		public void ReloadInfo()
		{
		}

		public void SetSceneColor(HmdColor_t color)
		{
		}

		public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor)
		{
		}

		public bool AreBoundsVisible()
		{
			return false;
		}

		public void ForceBoundsVisible(bool bForce)
		{
		}
	}
}
