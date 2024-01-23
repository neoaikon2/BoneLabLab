using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LightTrigger : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLightTransition_003Ed__14
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightTrigger _003C_003E4__this;

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
			public _003CLightTransition_003Ed__14(int _003C_003E1__state)
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

		[Header(null)]
		[SerializeField]
		private LayerMask LayerFilter;

		[Header("Orginal Light Source")]
		[SerializeField]
		private Light SourceLight;

		[SerializeField]
		private GameObject SourceLightTransform;

		[SerializeField]
		[Header("Target Transformation")]
		public Transform TargetTransform;

		[Header("Target Light properties")]
		[SerializeField]
		[Range(0f, 180f)]
		private float SpotLightAngle;

		[SerializeField]
		private float LightRange;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		[HideInInspector]
		public float OverallTransitionTime;

		[HideInInspector]
		[SerializeField]
		public float outTransitionTime;

		[HideInInspector]
		[SerializeField]
		public float inTransitionTime;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void MoveLight()
		{
		}

		private void ChangeLightSettings()
		{
		}

		[IteratorStateMachine(typeof(_003CLightTransition_003Ed__14))]
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

		public void MatchSettings()
		{
		}

		public void GrabChildTransform()
		{
		}

		public void AddChildTransform()
		{
		}
	}
}
