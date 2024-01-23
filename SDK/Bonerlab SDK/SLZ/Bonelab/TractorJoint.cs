using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TractorJoint : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoTractorBeam_003Ed__17
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TractorJoint _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003CtractorLerp_003E5__4;

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
			public _003CCoTractorBeam_003Ed__17(int _003C_003E1__state)
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
		private Rigidbody tractorBody;

		[SerializeField]
		private Grip tractorGrip;

		[SerializeField]
		private ForcePullGrip tractorForcePull;

		[SerializeField]
		private ConfigurableJoint joint;

		private Coroutine TractorRoutine;

		[SerializeField]
		private float initialWaitDuration;

		[SerializeField]
		private float duration;

		[SerializeField]
		private float startForce;

		[SerializeField]
		private float endForce;

		[SerializeField]
		private float maxForce;

		[SerializeField]
		private float rotForce;

		public float breakForce;

		private float endRotForce;

		private JointDrive tractorDrive;

		private JointDrive tractorRotDrive;

		[SerializeField]
		private AnimationCurve animCurve;

		[ContextMenu("StartTractorBeam")]
		public void StartTractorBeam()
		{
		}

		[IteratorStateMachine(typeof(_003CCoTractorBeam_003Ed__17))]
		private IEnumerator CoTractorBeam()
		{
			return null;
		}
	}
}
