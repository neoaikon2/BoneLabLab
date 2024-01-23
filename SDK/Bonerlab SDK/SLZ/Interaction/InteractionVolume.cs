using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractionVolume : MonoBehaviour
	{
		public struct InteractableEvent
		{
			public Collider collider;

			public HandReciever interactable;
		}

		public enum Type
		{
			Box = 0,
			Sphere = 1,
			Capsule = 2
		}

		public enum Direction
		{
			xAxis = 0,
			yAxis = 1,
			zAxis = 2
		}

		[CompilerGenerated]
		private sealed class _003CExecuteInteraction_003Ed__16
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InteractionVolume _003C_003E4__this;

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
			public _003CExecuteInteraction_003Ed__16(int _003C_003E1__state)
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
		public bool isActive;

		private Collider[] interactableColliders;

		private Rigidbody rb;

		private Rigidbody _hoveringRigidbody;

		private InteractableHost hoveringInteractableHost;

		private Coroutine checkCollisionsCoroutine;

		private bool _tempActive;

		private Rigidbody hoveringRigidbody
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerStay(Collider c)
		{
		}

		[IteratorStateMachine(typeof(_003CExecuteInteraction_003Ed__16))]
		private IEnumerator ExecuteInteraction()
		{
			return null;
		}

		protected virtual void OnHoverUpdate(InteractableHost host)
		{
		}

		protected virtual void OnHoverStart(InteractableHost host)
		{
		}

		protected virtual void OnHoverEnd(InteractableHost host)
		{
		}
	}
}
