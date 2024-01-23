using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class control_sign_LVLUP : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CArrowBlink_003Ed__31
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public control_sign_LVLUP _003C_003E4__this;

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
			public _003CArrowBlink_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CGlintBlink_003Ed__32
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public control_sign_LVLUP _003C_003E4__this;

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
			public _003CGlintBlink_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CBlinkRed_003Ed__33
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public control_sign_LVLUP _003C_003E4__this;

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
			public _003CBlinkRed_003Ed__33(int _003C_003E1__state)
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

		public GameObject L1;

		public GameObject glint_L1_l;

		public GameObject glint_L1_u;

		public GameObject V;

		public GameObject glint_V_l;

		public GameObject glint_V_u;

		public GameObject L2;

		public GameObject glint_L2_l;

		public GameObject glint_L2_u;

		public GameObject U;

		public GameObject P;

		public GameObject dot_outer;

		public GameObject dot_inner;

		public GameObject arrow_outer;

		public GameObject arrow_inner;

		public GameObject arrow_middle_A;

		public GameObject arrow_middle_B;

		public GameObject credits_A;

		public GameObject credits_B;

		public GameObject credits_C;

		public int creditsOwned;

		[ColorUsage(true, true)]
		public Color yellow;

		[ColorUsage(true, true)]
		public Color white;

		[ColorUsage(true, true)]
		public Color blue;

		[ColorUsage(true, true)]
		public Color green;

		[ColorUsage(true, true)]
		public Color pink;

		[ColorUsage(true, true)]
		public Color red;

		[ColorUsage(true, true)]
		public Color color_dead;

		private void Start()
		{
		}

		private void SetDefaultNeon()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CArrowBlink_003Ed__31))]
		private IEnumerator ArrowBlink()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGlintBlink_003Ed__32))]
		private IEnumerator GlintBlink()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBlinkRed_003Ed__33))]
		private IEnumerator BlinkRed()
		{
			return null;
		}

		private void CheckLights()
		{
		}

		private void CreditsSign()
		{
		}
	}
}
