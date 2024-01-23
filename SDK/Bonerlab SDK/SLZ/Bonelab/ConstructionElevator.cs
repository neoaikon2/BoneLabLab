using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ConstructionElevator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoVatorRoutine_003Ed__17
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConstructionElevator _003C_003E4__this;

			private float _003ClerpVal_003E5__2;

			private float _003CstartTime_003E5__3;

			private float _003CendTime_003E5__4;

			private float _003CfallLerpVal_003E5__5;

			private float _003CstartFallTime_003E5__6;

			private float _003CendFallTime_003E5__7;

			private Vector3 _003CgoalPos_003E5__8;

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
			public _003CCoVatorRoutine_003Ed__17(int _003C_003E1__state)
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
		private sealed class _003CCoTrellisSway_003Ed__18
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConstructionElevator _003C_003E4__this;

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
			public _003CCoTrellisSway_003Ed__18(int _003C_003E1__state)
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
		private bool moveOnStart;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private float duration;

		[SerializeField]
		private float fallDuration;

		[SerializeField]
		private Vector3 startPos;

		[SerializeField]
		private Vector3 endPos;

		[SerializeField]
		private Vector3 startFallPos;

		[SerializeField]
		private Vector3 endFallPos;

		[SerializeField]
		private ConfigurableJoint doorJoint;

		[SerializeField]
		private GameObject trellisObj;

		[SerializeField]
		private Transform lookTarg;

		private bool isLooking;

		[SerializeField]
		private Rigidbody[] trellisBodies;

		[SerializeField]
		private BoxCollider[] trellisCols;

		private Coroutine vatorRoutine;

		private void Start()
		{
		}

		public void MoveUp()
		{
		}

		[IteratorStateMachine(typeof(_003CCoVatorRoutine_003Ed__17))]
		private IEnumerator CoVatorRoutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoTrellisSway_003Ed__18))]
		private IEnumerator CoTrellisSway()
		{
			return null;
		}
	}
}
