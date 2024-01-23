using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Powerable : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoUnchargeLoop_003Ed__27
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Powerable _003C_003E4__this;

			private float _003CdividedDischarge_003E5__2;

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
			public _003CCoUnchargeLoop_003Ed__27(int _003C_003E1__state)
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
		[Header("POWERED AND TURNED ON")]
		protected bool m_Powered;

		[SerializeField]
		protected bool m_TurnedOn;

		[Tooltip("Default value for 10 minutes of use if capacity is 1000f in the PowerSource and there are 4 electronics using it. Divide number based on number of objects using it")]
		[Header("DRAW")]
		[Space(5f)]
		public float Discharge;

		[Tooltip("Used when checking compatability")]
		public ElectricItem Electronic;

		private Coroutine CoroutineUnChargeLoop;

		public Manager_Circuit ControlCircuit { get; set; }

		public OnOffSwitch SwitchRef { get; set; }

		public bool Powered
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool TurnedOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void SwitchPowerOnOff(bool isOn)
		{
		}

		public virtual void VoltageToObject(float voltage, int id = 0)
		{
		}

		public virtual void Vector2InputToObject(Vector2 xyLocal, int id = 0)
		{
		}

		protected void OnDestroy()
		{
		}

		private void AddDischarge()
		{
		}

		public void UnCharge()
		{
		}

		private void SubtractDischarge()
		{
		}

		public void StopUnCharge()
		{
		}

		[IteratorStateMachine(typeof(_003CCoUnchargeLoop_003Ed__27))]
		private IEnumerator CoUnchargeLoop()
		{
			return null;
		}
	}
}
