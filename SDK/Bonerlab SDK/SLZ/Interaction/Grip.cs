using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Grip : HandReciever
	{
		public delegate void HandDelegate(Hand hand);

		[CompilerGenerated]
		private sealed class _003CCoSnatch_003Ed__134
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isQuick;

			public Hand hand;

			public Grip _003C_003E4__this;

			private WaitForFixedUpdate _003CwaitFixed_003E5__2;

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
			public _003CCoSnatch_003Ed__134(int _003C_003E1__state)
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

		private static ComponentCache<Grip> _cache;

		[Header("Grip")]
		public bool isThrowable = true;

		[Tooltip("use the original target grip when attaching the joint, not the virtualized one")]
		public bool ignoreGripTargetOnAttach = false;

		[HideInInspector]
		public Collider[] gripColliders;

		public Collider[] additionalGripColliders;

		private Vector3[] velocityHistory;

		private Vector3[] angVelocityHistory;

		private int velocityHistoryIndex;

		private Dictionary<Hand, SimpleTransform> gripTargetsInBaseTarget;

		private Dictionary<Hand, HandToGripState> _handStates;

		protected List<Hand> attachedHands;

		public AnimationCurve handleAmplifyCurve = new AnimationCurve(
			new Keyframe[] {
				new Keyframe(-180, -30),
				new Keyframe(-50, -30),
				new Keyframe(0, 0),
				new Keyframe(50, 30),
				new Keyframe(180, 30),
			});

		public HandPose handPose;

		public Vector3 primaryMovementAxis = new Vector3(0, 0, 1);

		public Vector3 secondaryMovementAxis = new Vector3(0, 1, 0);

		[SerializeField]
		[EnumFlags]
		public InteractionOptions gripOptions = InteractionOptions.SwitchHands;

		[Range(0f, 10f)]
		[Tooltip("Zero priority guarantees grip victory. 1 is Neutral >1 is low priority")]
		public float priority = 1;

		public float minBreakForce = float.PositiveInfinity;

		public float maxBreakForce = float.PositiveInfinity;

		public float defaultGripDistance = float.PositiveInfinity;

		[HideInInspector]
		public float gripDistanceSqr;

		private float _gripDistance;

		private bool hasStartedToGrip;

		private bool _isInteractionDisabled;

		public float radius;

		public Transform targetTransform;

		public new static ComponentCache<Grip> Cache => null;

		public float gripDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected bool IsInteractionDisabled => false;

		public event HandDelegate attachedUpdateDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate hoverBeginHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate hoverEndHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate hoverUpdateHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate farHoverBeginHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate farHoverEndHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate farHoverUpdateHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate attachedHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate detachedHandDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HandDelegate forcePullCompleteDelegate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDisable()
		{
		}

		public VirtualController GetVirtualController(Hand hand)
		{
			return null;
		}

		public virtual void CheckHandPriority(ref HandGripPair primary, ref HandGripPair secondary)
		{
		}

		public bool CanUpdateConnectedAnchor(Hand hand)
		{
			return false;
		}

		public void SolveHandleAmplify(Hand hand)
		{
		}

		public SimpleTransform SolveHandTarget(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetVirtualTargetInHost(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInHost(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInBase(Hand hand)
		{
			return default(SimpleTransform);
		}

		public SimpleTransform GetTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetNeutralTargetInWorld(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void SetTargetInBase(Hand hand, Vector3 localPosition = default(Vector3), Quaternion localRotation = default(Quaternion))
		{
		}

		public SimpleTransform SetTargetInWorld(Hand hand, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion))
		{
			return default(SimpleTransform);
		}

		protected void RemoveTarget(Hand hand)
		{
		}

		public SimpleTransform GetHandInTarget(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual float GetSwingLimit(Hand hand)
		{
			return 0f;
		}

		public virtual float GetTwistLimit(Hand hand)
		{
			return 0f;
		}

		public bool HasGripFlag(Hand hand, GripFlags flag)
		{
			return false;
		}

		public void AddGripFlag(Hand hand, GripFlags flag)
		{
		}

		public void RemoveGripFlag(Hand hand, GripFlags flag)
		{
		}

		public virtual Vector3 GetPrimaryAxis(Hand hand = null)
		{
			return default(Vector3);
		}

		public virtual Vector3 GetSecondaryAxis(Hand hand = null)
		{
			return default(Vector3);
		}

		public virtual Vector3 GetTertiaryAxis(Hand hand = null)
		{
			return default(Vector3);
		}

		public Quaternion HandleAxisSpace()
		{
			return default(Quaternion);
		}

		public Quaternion GetPrimaryAxisInversedRotation()
		{
			return default(Quaternion);
		}

		public Quaternion GetSecondaryAxisInversedRotation()
		{
			return default(Quaternion);
		}

		public virtual SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public virtual SimpleTransform GetForcePullHandTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void SetHandPose(Hand hand, HandPose handPose)
		{
		}

		public void RemoveHandPose(Hand hand)
		{
		}

		public HandPose GetHandPose(Hand hand = null)
		{
			return null;
		}

		protected virtual void SetupConfiguration(HandJointConfiguration config)
		{
		}

		protected virtual void UpdateJointConfiguration(Hand hand)
		{
		}

		public override void DisableInteraction()
		{
		}

		public override void EnableInteraction()
		{
		}

		public void ForceDetach(bool isQuick)
		{
		}

		public void ForceDetach()
		{
		}

		public void ForceDetach(Hand hand)
		{
		}

		public bool GetController(out BaseController controller)
		{
			controller = null;
			return false;
		}

		public bool HasAttachedHands()
		{
			return false;
		}

		public Hand GetHand()
		{
			return null;
		}

		public HandToGripState GetHandState(Hand hand)
		{
			return null;
		}

		public virtual SimpleTransform GetGripNeutral(Hand hand)
		{
			return default(SimpleTransform);
		}

		protected void DisplayJointDebugger(ConfigurableJoint joint, Vector3 limits, SimpleTransform s, Quaternion worldRotation, Quaternion localRotation)
		{
		}

		private void SaveHistory(Vector3 velocity, Vector3 angVelocity)
		{
		}

		private void ClearHistory()
		{
		}

		private Vector3 GetAverageHistory(int start, int samples, out Vector3 angVelocity)
		{
			angVelocity = default(Vector3);
			return default(Vector3);
		}

		private Vector3 GetAverageHistory(float startDelayTime, float sampleTime, out Vector3 angVelocity)
		{
			angVelocity = default(Vector3);
			return default(Vector3);
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		private (Vector3, Vector3) CalculateDetatchVelocitys(float startDelayTime, float sampleTime, float amplificationMult, Vector3 wholeBodyVelocity)
		{
			return default((Vector3, Vector3));
		}

		public override void OnJointAttached(Hand hand)
		{
		}

		public override void OnAttachedToHand(Hand hand)
		{
		}

		public override void OnDetachedFromHand(Hand hand)
		{
		}

		public virtual void OnRTSkeleFixedUpdate(Hand hand)
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public void OnGrabConfirm(Hand hand, bool isOverride)
		{
		}

		public virtual bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return false;
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public virtual void OnHandHoverBegin(Hand hand, bool isOverride)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		public override void OnFarHandHoverUpdate(Hand hand)
		{
		}

		public override void OnFarHandHoverBegin(Hand hand)
		{
		}

		public override void OnFarHandHoverEnd(Hand hand)
		{
		}

		public override float ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return 0f;
		}

		[ContextMenu("Get Sub Colliders")]
		public void GetSubColliders()
		{
		}

		public virtual void CancelSnatch(Hand hand)
		{
		}

		public virtual void Snatch(Hand hand, bool isQuick = false)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSnatch_003Ed__134))]
		private IEnumerator CoSnatch(Hand hand, bool isQuick)
		{
			return null;
		}
	}
}
