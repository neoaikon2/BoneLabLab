using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class VignetteController : MonoBehaviour
	{
		private enum FadeType
		{
			On = 0,
			Off = 1
		}

		[CompilerGenerated]
		private sealed class _003CFader_003Ed__8
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VignetteController _003C_003E4__this;

			public FadeType Fade;

			public float FadeTime;

			private float _003Cstart_003E5__2;

			private float _003Cend_003E5__3;

			private float _003CTimer_003E5__4;

			private float _003Cstep_003E5__5;

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
			public _003CFader_003Ed__8(int _003C_003E1__state)
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

		[HideInInspector]
		[SerializeField]
		private Renderer rend;

		private void Start()
		{
		}

		public void FadeToFull()
		{
		}

		public void FadeOn()
		{
		}

		public void FadeOn(float Time)
		{
		}

		public void FadeOff()
		{
		}

		public void FadeOff(float Time)
		{
		}

		[IteratorStateMachine(typeof(_003CFader_003Ed__8))]
		private IEnumerator Fader(FadeType Fade, float FadeTime)
		{
			return null;
		}
	}
}
