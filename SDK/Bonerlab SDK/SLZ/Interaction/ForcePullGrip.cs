using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class ForcePullGrip : MonoBehaviour
	{
		public enum GripState
		{
			IDELING = 0,
			LONGHOVERING = 1,
			PULLING = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoPull_003Ed__32
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ForcePullGrip _003C_003E4__this;

			public Hand hand;

			private float _003CmaxPullDistance_003E5__2;

			private IGrippable _003Chost_003E5__3;

			private float _003Ctime_003E5__4;

			private bool _003CisSnatching_003E5__5;

			private float _003Cdistance_003E5__6;

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
			public _003CCoPull_003Ed__32(int _003C_003E1__state)
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

		private static ComponentCache<ForcePullGrip> _cache;

		private Grip _grip;

		private Hand _pullToHand;

		private bool _isDoneSnatching;

		private bool _isStartAttaching;

		private bool _isEnabled;

		public float absorbForceToBody;

		private float maxForce;

		public float maxSpeed = float.PositiveInfinity;

		private ConfigurableJoint tempJoint;

		private Coroutine pullCoroutine;

		public static ComponentCache<ForcePullGrip> Cache => null;

		public GripState state { get; private set; }

		private void Start()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		private void OnFarHandHoverUpdate(Hand hand)
		{
		}

		private void OnFarHandHoverEnd(Hand hand)
		{
		}

		private void OnFarHandHoverBegin(Hand hand)
		{
		}

		private void Pull(Hand hand)
		{
		}

		public void OnForcePullComplete(Hand hand)
		{
		}

		public void OnStartAttach(Hand hand)
		{
		}

		public void CancelPull(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoPull_003Ed__32))]
		private IEnumerator CoPull(Hand hand)
		{
			return null;
		}
	}
}
