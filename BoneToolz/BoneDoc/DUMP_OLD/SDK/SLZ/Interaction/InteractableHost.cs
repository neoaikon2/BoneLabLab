using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class InteractableHost : MarrowBehaviour, IGrippable
	{
		private static ComponentCache<InteractableHost> _cache;

		public InteractableHostManager manager;

		public bool ignoreBodyOnGrab;

		private MarrowBody _marrowBody;

		private ConfigurableJoint _monofootJoint;

		private ConfigurableJoint _pelvisJoint;

		private ConfigurableJoint _spineJoint;

		private ConfigurableJoint _chestJoint;

		private ConfigurableJoint _neckJoint;

		private ConfigurableJoint _headJoint;

		private readonly List<Hand> _hands;

		private Hand _lastHand;

		private readonly List<Grip> _grips;

		private readonly List<ForcePullGrip> _fpGrips;

		public Action<InteractableHost, Hand> onHandAttachedDelegate;

		public Action<InteractableHost, Hand> onHandDetachedDelegate;

		private Coroutine checkForSleepCoroutine;

		public static ComponentCache<InteractableHost> Cache
		{
			get
			{
				return null;
			}
		}

		public VirtualController VirtualController { get; private set; }

		public TriggerRefProxy LastGrabbedProxy { get; private set; }

		public Collider[] Colliders
		{
			get
			{
				return null;
			}
		}

		public bool IsInteractionDisabled { get; private set; }

		public bool IsFarHoverEnabled { get; private set; }

		public bool IsStatic { get; set; }

		public bool HasRigidbody
		{
			get
			{
				return default(bool);
			}
		}

		public MarrowBody Body
		{
			get
			{
				return null;
			}
		}

		public Rigidbody Rb
		{
			get
			{
				return null;
			}
		}

		public bool IsAttached
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPulling
		{
			get
			{
				return default(bool);
			}
		}

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

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void DecorateHostOnChildGrips(Transform t)
		{
		}

		public void OnDestroy()
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

		public void Freeze()
		{
		}

		public void Unfreeze()
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
			return default(int);
		}

		public void ForceDetach(bool isQuick = false)
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

		private IEnumerator CoCheckForSleep()
		{
			return null;
		}

		public InteractableHost()
			: base()
		{
		}
	}
}
