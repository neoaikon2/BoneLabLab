using UnityEngine;
using UnityEngine.XR;

namespace Microsoft.MixedReality.OpenXR
{
	public class EyeLevelSceneOrigin : MonoBehaviour
	{
		private XRInputSubsystem m_inputSubsystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void XrInput_trackingOriginUpdated(XRInputSubsystem obj)
		{
		}

		private void EnsureSceneOriginAtEyeLevel()
		{
		}

		private static TrackingOriginModeFlags GetDesiredTrackingOriginMode(XRInputSubsystem xrInput)
		{
			return default(TrackingOriginModeFlags);
		}

		public EyeLevelSceneOrigin()
			: base()
		{
		}
	}
}
