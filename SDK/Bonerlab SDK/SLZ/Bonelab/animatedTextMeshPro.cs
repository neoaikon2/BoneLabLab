using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class animatedTextMeshPro : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTypeText_003Ed__5
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public animatedTextMeshPro _003C_003E4__this;

			private char[] _003C_003E7__wrap1;

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
			public _003CTypeText_003Ed__5(int _003C_003E1__state)
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

		public float letterPaused;

		public string message;

		public TextMeshPro textComp;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CTypeText_003Ed__5))]
		private IEnumerator TypeText()
		{
			return null;
		}
	}
}
