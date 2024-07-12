using UnityEngine;

namespace SLZ.Graphics2.VRS
{
	public class CameraVRSOverride : MonoBehaviour
	{
		[SerializeField]
		public VRSRadii radii;

		public static ShadingRateResource.Settings GetVRSSettings(VRSRadii radii)
		{
			return default(ShadingRateResource.Settings);
		}

		public Vector2 GetRDMSettings(VRSRadii radii)
		{
			return default(Vector2);
		}

		public CameraVRSOverride()
			: base()
		{
		}
	}
}
