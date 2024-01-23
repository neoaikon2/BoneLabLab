using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Utilities;
using SLZ.Zones;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SkelGripEvents : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoAdjustJoints_003Ed__21
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkelGripEvents _003C_003E4__this;

			private ConfigurableJoint[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private ConfigurableJoint _003Cjoint_003E5__4;

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
			public _003CCoAdjustJoints_003Ed__21(int _003C_003E1__state)
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
		private Grip[] skeletonGrips;

		[SerializeField]
		private ConfigurableJoint skeletonFixedJoint;

		[SerializeField]
		private ConfigurableJoint[] allSkellJoints;

		[SerializeField]
		private GameObject skelRArmObj;

		[SerializeField]
		private GameObject wallParentObj;

		[SerializeField]
		private ConfigurableJoint[] wallJoints;

		public UnityEvent onWallBreakEvent;

		public float jointStrength;

		private Coroutine jointRoutine;

		[SerializeField]
		private bool isLowBreak;

		[SerializeField]
		private Transform audioTransform;

		[SerializeField]
		private AudioClip audioClip;

		[SerializeField]
		private AudioMixerGroup mixerGroup;

		[SerializeField]
		private Zone3dSound windSound;

		private AudioPlayer _ap;

		private float sourceRadius;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnGrabSkeleton(Hand hand)
		{
		}

		public void KeystoneBroke()
		{
		}

		private void BreakRocks()
		{
		}

		[IteratorStateMachine(typeof(_003CCoAdjustJoints_003Ed__21))]
		private IEnumerator CoAdjustJoints()
		{
			return null;
		}

		[ContextMenu("GrabAllJoints")]
		public void GrabAllJoints()
		{
		}

		[ContextMenu("GrabGrips")]
		public void GrabGrips()
		{
		}
	}
}
