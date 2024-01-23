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
		[CompilerGenerated]
		private sealed class _003CLightTransition_003Ed__23
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ZoneLight _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private float _003Coutime_003E5__3;

			private float _003Cintime_003E5__4;

			private float _003CorginalIntensity_003E5__5;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLightTransition_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

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

		[SerializeField]
		public bool cookieEnabled;

		[HideInInspector]
		[SerializeField]
		public int cookieNumber;

		[HideInInspector]
		[SerializeField]
		public float OverallTransitionTime;

		[HideInInspector]
		[SerializeField]
		public float outTransitionTime;

		[SerializeField]
		[HideInInspector]
		public float inTransitionTime;

		[SerializeField]
		[HideInInspector]
		private GameObject LightObject;

		[SerializeField]
		[HideInInspector]
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

		[IteratorStateMachine(typeof(_003CLightTransition_003Ed__23))]
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
	}
}
