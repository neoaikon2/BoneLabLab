using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DissolveEffect : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDissolver_003Ed__5
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DissolveEffect _003C_003E4__this;

			private MaterialPropertyBlock _003CpropertyBlock_003E5__2;

			private int _003Cshaderid_003E5__3;

			private float _003CTimer_003E5__4;

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
			public _003CDissolver_003Ed__5(int _003C_003E1__state)
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
		private MeshRenderer meshRenderer;

		[SerializeField]
		private Shader shader;

		[SerializeField]
		private float DissolveTime;

		private void Reset()
		{
		}

		public void Dissolve()
		{
		}

		[IteratorStateMachine(typeof(_003CDissolver_003Ed__5))]
		private IEnumerator Dissolver()
		{
			return null;
		}
	}
}
