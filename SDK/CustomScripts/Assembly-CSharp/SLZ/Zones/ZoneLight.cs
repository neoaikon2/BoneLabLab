using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Zones
{
	public class ZoneLight : ZoneItem
	{
		[SerializeField]
		private bool PrimeZoneOnly;

		[Range(0f, 180f)]
		[Space(5f)]
		[Header("Light properties")]
		[SerializeField]
		private float SpotLightAngle;

		[SerializeField]
		private float LightRange;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		private bool EnableShadows;

		[SerializeField]
		public bool cookieEnabled;

		[HideInInspector]
		[SerializeField]
		public int cookieNumber;

		[HideInInspector]
		[SerializeField]
		public float OverallTransitionTime;

		[SerializeField]
		[HideInInspector]
		public float outTransitionTime;

		[HideInInspector]
		[SerializeField]
		public float inTransitionTime;

		[HideInInspector]
		[SerializeField]
		private GameObject LightObject;

		[HideInInspector]
		[SerializeField]
		private Light SourceLight;

		private void MakeLightSource()
		{
		}

		private void MakeTempLightSource()
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneEntered(GameObject playerObject)
		{
		}

		public override void OnPrimaryZoneExited(GameObject playerObject)
		{
		}

		private void DisableLight()
		{
		}

		private void EnableLight()
		{
		}

		private void RemoveLight()
		{
		}

		private void ChangeLightSettings()
		{
		}

		private IEnumerator LightTransition()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public ZoneLight()
			: base()
		{
		}
	}
}
