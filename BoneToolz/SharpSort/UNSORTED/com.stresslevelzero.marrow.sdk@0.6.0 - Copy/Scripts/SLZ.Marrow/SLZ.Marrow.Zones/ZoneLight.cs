using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneLight : ZoneLinkItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;

		[Range(0f, 180f)]
		[SerializeField]
		[Space(5f)]
		[Header("Light properties")]
		private float SpotLightAngle;

		[SerializeField]
		private float LightRange;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		private bool EnableShadows;

		[HideInInspector]
		[SerializeField]
		private GameObject LightObject;

		[SerializeField]
		[HideInInspector]
		private Light SourceLight;
		
		private void DisableLight()
		{
		}

		private void EnableLight()
		{
		}

		private void ChangeLightSettings()
		{
		}
	}
}
