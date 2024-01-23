using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class Simple_ControlTimeExample : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__12
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Simple_ControlTimeExample _003C_003E4__this;

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
		public _003CCountdown_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CCountUpReal_003Ed__13
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Simple_ControlTimeExample _003C_003E4__this;

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
		public _003CCountUpReal_003Ed__13(int _003C_003E1__state)
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
	private sealed class _003CCountUpSlow_003Ed__14
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Simple_ControlTimeExample _003C_003E4__this;

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
		public _003CCountUpSlow_003Ed__14(int _003C_003E1__state)
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

	public Control_GlobalTime ctrl_GlobalTime;

	public float max_countdown;

	private float cur_countdown;

	public TextMeshProUGUI text_CountDown;

	private bool alreadyActive;

	private float cur_upTime_real;

	private float cur_upTime_slow;

	public TextMeshProUGUI text_upTime_real;

	public TextMeshProUGUI text_upTime_slow;

	public TextMeshProUGUI text_TimeScale;

	public void TIMEACTION(int action)
	{
	}

	public void POWERED(bool powered = false)
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__12))]
	private IEnumerator Countdown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCountUpReal_003Ed__13))]
	private IEnumerator CountUpReal()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCountUpSlow_003Ed__14))]
	private IEnumerator CountUpSlow()
	{
		return null;
	}

	public void DISPLAYTEXT()
	{
	}

	private void Update()
	{
	}
}
