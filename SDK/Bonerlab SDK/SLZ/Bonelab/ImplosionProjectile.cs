using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ImplosionProjectile : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CImplosionCoroutine_003Ed__9
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CImplosionCoroutine_003Ed__9(int _003C_003E1__state)
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
		private LayerMask LayerFilter;

		public Collider sphere;

		public float implosionForceMultiplier;

		public float implosionForceClamp;

		private List<Rigidbody> allRBs;

		private List<Rigidbody> filteredRBs;

		public bool fire;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CImplosionCoroutine_003Ed__9))]
		private IEnumerator ImplosionCoroutine()
		{
			return null;
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
