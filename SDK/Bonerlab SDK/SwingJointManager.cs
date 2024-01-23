using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwingJointManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFullFrame_003Ed__6
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SwingJointManager _003C_003E4__this;

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
		public _003CFullFrame_003Ed__6(int _003C_003E1__state)
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
	private sealed class _003CCoEnableSwingers_003Ed__8
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SwingJointManager _003C_003E4__this;

		private SwingJointInverter[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

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
		public _003CCoEnableSwingers_003Ed__8(int _003C_003E1__state)
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

	public SwingJointInverter[] swingObjs;

	public float delay;

	public bool reset;

	private bool start;

	private void Awake()
	{
	}

	[ContextMenu("Start Stuff")]
	private void StartStuff()
	{
	}

	[IteratorStateMachine(typeof(_003CFullFrame_003Ed__6))]
	private IEnumerator FullFrame()
	{
		return null;
	}

	public void DeathReset()
	{
	}

	[IteratorStateMachine(typeof(_003CCoEnableSwingers_003Ed__8))]
	public IEnumerator CoEnableSwingers()
	{
		return null;
	}
}
