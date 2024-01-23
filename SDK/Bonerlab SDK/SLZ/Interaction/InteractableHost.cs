using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.AI;
using SLZ.Marrow.Utilities;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Interaction
{
	public class InteractableHost : ObjectCleanupEvents, IGrippable
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckForSleep_003Ed__80
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InteractableHost _003C_003E4__this;

			private WaitForFixedUpdate _003Cwffu_003E5__2;

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
			public _003CCoCheckForSleep_003Ed__80(int _003C_003E1__state)
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

		private static ComponentCache<InteractableHost> _cache;

		public InteractableHostManager manager;

		public bool ignoreBodyOnGrab;

		private ConfigurableJoint _bodyJoint;

		private ConfigurableJoint _spineJoint;

		private ConfigurableJoint _chestJoint;

		private ConfigurableJoint _headJoint;

		private Hand _lastHand;

		private List<Grip> _grips;

		private List<ForcePullGrip> _fpGrips;

		private RigidbodyData _rbData;

		private Rigidbody _rb;

		public Action<InteractableHost, Hand> onHandAttachedDelegate;

		public Action<InteractableHost, Hand> onHandDetachedDelegate;

		private List<Hand> _hands;

		private Coroutine checkForSleepCoroutine;

		public new static ComponentCache<InteractableHost> Cache => null;

		[field: SerializeField]
		[field: FormerlySerializedAs("virtualController")]
		public VirtualController VirtualController { get; private set; }

		public TriggerRefProxy LastGrabbedProxy { get; private set; }

		public Collider[] Colliders { get; private set; }

		public bool IsInteractionDisabled { get; private set; }

		public bool IsFarHoverEnabled { get; private set; }

		[field: FormerlySerializedAs("isStatic")]
		[field: SerializeField]
		public bool IsStatic { get; set; }

		[field: FormerlySerializedAs("hasRigidbody")]
		[field: SerializeField]
		public bool HasRigidbody { get; private set; }

		public Rigidbody Rb => null;

		public bool IsAttached => false;

		public bool IsPulling => false;

		private void Reset()
		{
		}

		public SimpleTransform GetHostTransform()
		{
			return default(SimpleTransform);
		}

		public Transform GetTransform()
		{
			return null;
		}

		public GameObject GetHostGameObject()
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void DecorateHostOnChildGrips(Transform t)
		{
		}

		private void OnEnable()
		{
		}

		public override void OnDestroy()
		{
		}

		public void RemoveProxy()
		{
		}

		public void SetProxy(GameObject proxyObject)
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		public void DisableInteraction()
		{
		}

		public void DisableFarHover()
		{
		}

		public void EnableFarHover()
		{
		}

		public void EnableInteraction()
		{
		}

		public void DestroyJoints()
		{
		}

		public void DestroyRigidbody()
		{
		}

		public void CreateRigidbody()
		{
		}

		public void AttachHand(Hand hand)
		{
		}

		public void DetachHand(Hand hand)
		{
		}

		public Hand GetHand(int idx = 0)
		{
			return null;
		}

		public void ClearAttachedHandsForDespawn()
		{
		}

		public Hand GetLastHand()
		{
			return null;
		}

		public int HandCount()
		{
			return 0;
		}

		public void ForceDetach()
		{
		}

		public Grip GetGrip()
		{
			return null;
		}

		public ForcePullGrip GetForcePullGrip()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckForSleep_003Ed__80))]
		private IEnumerator CoCheckForSleep()
		{
			return null;
		}

		public override void OnCleanup()
		{
		}
	}
}
