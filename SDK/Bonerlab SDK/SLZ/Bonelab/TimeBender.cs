using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TimeBender : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoLimitSlowMo_003Ed__19
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeBender _003C_003E4__this;

			public float step;

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
			public _003CCoLimitSlowMo_003Ed__19(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoRegenSlowMo_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public TimeBender _003C_003E4__this;

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
			public _003CCoRegenSlowMo_003Ed__20(int _003C_003E1__state)
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

		[Header("SLOW-MOTION-FOR-ME")]
		[SerializeField]
		private bool limitedSlowMo;

		[SerializeField]
		private bool isSlowTime;

		[SerializeField]
		private GameObject visObj;

		private Coroutine limitedSlowMoRoutine;

		private Coroutine regenSlowMoRoutine;

		[SerializeField]
		private float maxSlowMoJuice;

		[SerializeField]
		private float slowMoJuice;

		[SerializeField]
		private GameObject[] timeBips;

		[SerializeField]
		private GameObject slowMoSlider;

		[SerializeField]
		private Control_GlobalTime timeControl;

		[SerializeField]
		private ControllerRig controllerRig;

		[SerializeField]
		private AudioClip slowMoCoolClip;

		[SerializeField]
		private AudioClip slowMoJuicedClip;

		private float currStep;

		private float sliderScaleMax;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleSlowLimits(bool isLimited)
		{
		}

		public void SlowTimeToggle(float step)
		{
		}

		[IteratorStateMachine(typeof(_003CCoLimitSlowMo_003Ed__19))]
		private IEnumerator CoLimitSlowMo(float step = 1f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoRegenSlowMo_003Ed__20))]
		private IEnumerator CoRegenSlowMo(float delay = 0f)
		{
			return null;
		}
	}
}
