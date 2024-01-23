using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PowerSocket : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoChargeLoop_003Ed__20
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PowerSocket _003C_003E4__this;

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
			public _003CCoChargeLoop_003Ed__20(int _003C_003E1__state)
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
		[Tooltip("The charge rate passed into the battery in Watts/min")]
		private float m_ChargeCurrent;

		private Coroutine CoroutineChargeLoop;

		public bool Charging;

		[Header("SPECIFIC POWERSOURCE")]
		[SerializeField]
		private PowerSource SamePower;

		[Space(5f)]
		[Header("INDICATOR LIGHTS")]
		public GameObject[] indicateOn;

		public GameObject[] indicateOff;

		public Manager_Circuit ControlCircuit { get; set; }

		public PowerSource PS { get; private set; }

		private void Start()
		{
		}

		public void EnterPowerOut(PowerSource ps, bool match)
		{
		}

		public void RunOutPower(PowerSource ps)
		{
		}

		public void ExitPowerOut(PowerSource ps)
		{
		}

		private void OnDestroy()
		{
		}

		private void M_Charge()
		{
		}

		[IteratorStateMachine(typeof(_003CCoChargeLoop_003Ed__20))]
		private IEnumerator CoChargeLoop()
		{
			return null;
		}

		private void M_StopCharge()
		{
		}

		public void EnterCharge(PowerSource ps, bool match)
		{
		}

		public void ExitCharge(PowerSource ps)
		{
		}

		private void M_SetIndicators(bool OnOff = false)
		{
		}
	}
}
