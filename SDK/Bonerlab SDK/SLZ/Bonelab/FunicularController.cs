using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class FunicularController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCartGoCoroutine_003Ed__9
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FunicularController _003C_003E4__this;

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
			public _003CCartGoCoroutine_003Ed__9(int _003C_003E1__state)
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
		private sealed class _003CCartForwardsCoroutine_003Ed__11
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FunicularController _003C_003E4__this;

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
			public _003CCartForwardsCoroutine_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CCartBackwardsCoroutine_003Ed__13
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FunicularController _003C_003E4__this;

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
			public _003CCartBackwardsCoroutine_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CStopVFXCoroutine_003Ed__15
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FunicularController _003C_003E4__this;

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
			public _003CStopVFXCoroutine_003Ed__15(int _003C_003E1__state)
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

		public Cart cart;

		public ParticleSystem[] SteamVent;

		public UnityEvent sealBreakSFX;

		public UnityEvent gasRushSFX;

		public UnityEvent klaxonSFX;

		public UnityEvent startSFX;

		public UnityEvent stopSFX;

		private IEnumerator CartFxCoroutine;

		public void CartGo()
		{
		}

		[IteratorStateMachine(typeof(_003CCartGoCoroutine_003Ed__9))]
		private IEnumerator CartGoCoroutine()
		{
			return null;
		}

		public void CartForwards()
		{
		}

		[IteratorStateMachine(typeof(_003CCartForwardsCoroutine_003Ed__11))]
		private IEnumerator CartForwardsCoroutine()
		{
			return null;
		}

		public void CartBackwards()
		{
		}

		[IteratorStateMachine(typeof(_003CCartBackwardsCoroutine_003Ed__13))]
		private IEnumerator CartBackwardsCoroutine()
		{
			return null;
		}

		public void StopVFX()
		{
		}

		[IteratorStateMachine(typeof(_003CStopVFXCoroutine_003Ed__15))]
		private IEnumerator StopVFXCoroutine()
		{
			return null;
		}
	}
}
