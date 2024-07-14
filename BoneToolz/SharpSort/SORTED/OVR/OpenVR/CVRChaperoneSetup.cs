using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRChaperoneSetup
	{
		private IVRChaperoneSetup FnTable;

		internal CVRChaperoneSetup(IntPtr pInterface)
		{
		}

		public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
		{
			return false;
		}

		public void RevertWorkingCopy()
		{
		}

		public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ)
		{
			return false;
		}

		public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
		{
			return false;
		}

		public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			pQuadsBuffer = null;
			return false;
		}

		public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			pQuadsBuffer = null;
			return false;
		}

		public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return false;
		}

		public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
		{
			return false;
		}

		public void SetWorkingPlayAreaSize(float sizeX, float sizeZ)
		{
		}

		public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
		}

		public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
		{
		}

		public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
		{
		}

		public void ReloadFromDisk(EChaperoneConfigFile configFile)
		{
		}

		public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
		{
			return false;
		}

		public void SetWorkingCollisionBoundsTagsInfo(byte[] pTagsBuffer)
		{
		}

		public bool GetLiveCollisionBoundsTagsInfo(out byte[] pTagsBuffer)
		{
			pTagsBuffer = null;
			return false;
		}

		public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t[] pQuadsBuffer)
		{
			return false;
		}

		public bool GetLivePhysicalBoundsInfo(out HmdQuad_t[] pQuadsBuffer)
		{
			pQuadsBuffer = null;
			return false;
		}

		public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength)
		{
			return false;
		}

		public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags)
		{
			return false;
		}
	}
}
