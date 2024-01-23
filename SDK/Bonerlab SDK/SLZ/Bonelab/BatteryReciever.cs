using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BatteryReciever : MonoBehaviour, IInteractionReceivable
	{
		[CompilerGenerated]
		private sealed class _003CCoDriftIntoTransform_003Ed__12
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
			public _003CCoDriftIntoTransform_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CCoDriftOutOfTransform_003Ed__13
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
			public _003CCoDriftOutOfTransform_003Ed__13(int _003C_003E1__state)
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

		public Transform target;

		private ConfigurableJoint ignoreJoint;

		private InteractableHost batteryHost;

		private void CreateJoint(Rigidbody rb)
		{
		}

		private void DestroyJoint()
		{
		}

		public void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public virtual void OnInteractableHostDrop(InteractableHost host)
		{
		}

		public void OnInteractableHostExit(InteractableHost host)
		{
		}

		public void OnInteractableHostStay(InteractableHost host)
		{
		}

		protected void GetHandPositionFromWorldHandle(Hand hand, Vector3 worldHandlePosition, Quaternion worldHandleRotation, out Vector3 handPosition, out Quaternion handRotation)
		{
			handPosition = default(Vector3);
			handRotation = default(Quaternion);
		}

		protected void GetHandPositionFromWorldHandle(Hand hand, SimpleTransform worldHandleTransform, out SimpleTransform handTransform)
		{
			handTransform = default(SimpleTransform);
		}

		public void Generic(Grip grip, Hand hand, InteractableHost host, float perc)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDriftIntoTransform_003Ed__12))]
		private IEnumerator CoDriftIntoTransform()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoDriftOutOfTransform_003Ed__13))]
		private IEnumerator CoDriftOutOfTransform()
		{
			return null;
		}
	}
}
