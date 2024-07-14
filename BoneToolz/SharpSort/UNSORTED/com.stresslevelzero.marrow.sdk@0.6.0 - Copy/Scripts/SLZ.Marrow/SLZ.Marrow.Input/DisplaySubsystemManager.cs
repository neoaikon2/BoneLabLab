using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class DisplaySubsystemManager : SubsystemManager<XRDisplaySubsystem, XRDisplaySubsystemDescriptor>
	{
		public enum FoveationLevel
		{
			DISABLE = 0,
			LOW = 1,
			MEDIUM = 2,
			HIGH = 3,
			HIGH_TOP = 4
		}

		public enum ColorSpace
		{
			Unknown = 0,
			Unmanaged = 1,
			Rec_2020 = 2,
			Rec_709 = 3,
			Rift_CV1 = 4,
			Rift_S = 5,
			Quest = 6,
			P3 = 7,
			Adobe_RGB = 8
		}

		private int _lastFrequency;

		public float GetRefreshRate()
		{
			return 0f;
		}

		public float GetRecommendedPhysFrequency()
		{
			return 0f;
		}

		public bool HasFrequencyChanged()
		{
			return false;
		}

		public void SetRefreshRate(float refreshRate)
		{
		}

		public void SetFoveationLevel(FoveationLevel level)
		{
		}

		public void EnableLocalDimming(bool value)
		{
		}

		public void EnableEyeTrackedFoveatedRendering(bool value)
		{
		}

		public void EnableDynamicFFR(bool value)
		{
		}

		public bool TryGetAvailableRefreshRates(out float[] refreshRates)
		{
			refreshRates = null;
			return false;
		}

		public void SetColorSpaceDesc(ColorSpace colorSpace)
		{
		}

		public bool TryGetIPD(out float ipd)
		{
			ipd = default(float);
			return false;
		}
	}
}
