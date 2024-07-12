using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[SelectionBase]
	public class MarrowEntity : MonoBehaviour, ITaggable, IPoolable
	{
		[Flags]
		public enum HibernationSources
		{
			Default = 1,
			Culling = 2,
			Loading = 4
		}

		private static ComponentCache<MarrowEntity> _cache;

		[Header("Marrow Entity")]
		[SerializeField]
		private TagList _tags;

		[SerializeField]
		private MarrowBehaviour[] _behaviours;

		private List<IMarrowEntityCullable> _cullables;

		private List<IMarrowEntityHideable> _hideables;

		private List<IMarrowEntityDespawnable> _despawnables;

		private bool _hasInactiveState;

		internal InactiveStatus _inactiveStatus;

		private bool _isDisableOnCullPrevented;

		private List<MarrowEntity> _outLinks;

		private List<MarrowEntity> _inLinks;

		private bool _isDirty;

		private HashSet<MarrowEntity> _visited;

		private List<MarrowEntity> _connectedEntities;

		private HibernationSources allHibernationSources;

		[SerializeField]
		[Header("Physics")]
		private Vector3 _originalScale;

		[SerializeField]
		private MarrowBody[] _bodies;

		[SerializeField]
		private MarrowJoint[] _joints;

		[SerializeField]
		private MarrowBody _anchorBody;

		private SimpleTransform[] _defaultPoseCache;

		private SimpleTransform[] _teleportTransformCache;

		private MarrowEntity _hostEntity;

		private List<MarrowEntity> _parasites;

		private HibernationSources _hibernationFlags;

		private List<MarrowJoint> _runtimeJoints;

		[SerializeField]
		private Poolee _poolee;

		public static ComponentCache<MarrowEntity> Cache
		{
			get
			{
				return null;
			}
		}

		public TagList Tags
		{
			get
			{
				return null;
			}
		}

		public bool IsDestroyed { get; private set; }

		public bool IsInactive
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCulled
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsHidden
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsDespawned
		{
			get
			{
				return default(bool);
			}
		}

		public IReadOnlyList<MarrowEntity> ConnectedEntities
		{
			get
			{
				return null;
			}
		}

		public MarrowBody AnchorBody
		{
			get
			{
				return null;
			}
		}

		public MarrowBody[] Bodies
		{
			get
			{
				return null;
			}
		}

		public MarrowJoint[] Joints
		{
			get
			{
				return null;
			}
		}

		public bool IsHibernating
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsGhosting { get; private set; }

		public bool IsCollidersEnabled { get; private set; }

		public bool IsTriggersEnabled { get; private set; }

		public bool IsTrackersEnabled { get; private set; }

		public float ScaleRatio { get; private set; }

		public IReadOnlyList<MarrowJoint> RuntimeJoints
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLevelLoadComplete()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool doResetPose = false)
		{
		}

		public void SetActive(bool isActive)
		{
		}

		public void PreventDisableOnCull(bool isPrevented = true)
		{
		}

		public void RegisterEventHandler(IMarrowEntityCullable cullable)
		{
		}

		public void UnregisterEventHandler(IMarrowEntityCullable cullable)
		{
		}

		public void RegisterEventHandler(IMarrowEntityDespawnable despawnable)
		{
		}

		public void UnregisterEventHandler(IMarrowEntityDespawnable despawnable)
		{
		}

		public void RegisterEventHandler(IMarrowEntityHideable hideable)
		{
		}

		public void UnregisterEventHandler(IMarrowEntityHideable hideable)
		{
		}

		private void InitializeInactiveState()
		{
		}

		private void DisableEvents_Awake()
		{
		}

		public void Hide(bool isHidden = true, bool doApplyImmediately = false)
		{
		}

		private void OnCullResolve(InactiveStatus status, bool isInactive)
		{
		}

		private void OnCullApply(InactiveStatus status, bool isInactive)
		{
		}

		private void OnDespawnApply(InactiveStatus status, bool isInactive)
		{
		}

		private void OnHideApply(InactiveStatus status, bool isInactive)
		{
		}

		private void Activate(InactiveStatus status)
		{
		}

		internal void AddConnection(MarrowEntity entity)
		{
		}

		internal void RemoveConnection(MarrowEntity entity)
		{
		}

		private void DFS(MarrowEntity entity)
		{
		}

		private void Physics_Awake()
		{
		}

		private void Physics_OnCullDisabled()
		{
		}

		private void Physics_OnCullEnabled()
		{
		}

		private void Physics_OnPoolInitialize()
		{
		}

		private void Physics_OnSpawn()
		{
		}

		private void Physics_OnPoolDeinitialize()
		{
		}

		private void Physics_OnLevelLoadComplete()
		{
		}

		public void SetPhysicsDefaults()
		{
		}

		public void Hibernate(bool setHibernating = true, HibernationSources source = HibernationSources.Default)
		{
		}

		private void ClearHibernation()
		{
		}

		private void ClearGhost()
		{
		}

		private void CleanupIgnoredCollisions()
		{
		}

		public void Ghost(bool isGhosting)
		{
		}

		public void Unpack(MarrowBody hostBody, MarrowBody parasiteBody)
		{
		}

		public void Pack(MarrowBody hostBody, MarrowBody parasiteBody)
		{
		}

		public void EnableColliders(bool isEnabled = true)
		{
		}

		private void ForceEnableColliders(bool isEnabled = true)
		{
		}

		public void EnableTriggers(bool isEnabled = true)
		{
		}

		private void ForceEnableTriggers(bool isEnabled = true)
		{
		}

		public void EnableTrackers(bool isEnabled = true)
		{
		}

		private void ForceEnableTrackers(bool isEnabled)
		{
		}

		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		public void ResetMass()
		{
		}

		public void IgnoreCollision(MarrowEntity otherEntity, bool isIgnoring = true)
		{
		}

		public void IgnoreCollision(Collider colliderToIgnore, bool isIgnoring = true)
		{
		}

		internal void AddRuntimeJoint(MarrowJoint joint)
		{
		}

		internal void RemoveRuntimeJoint(MarrowJoint joint)
		{
		}

		private void SpawnEvents_Awake()
		{
		}

		public void RegisterEventHandler(IPoolable poolable)
		{
		}

		public void UnregisterEventHandler(IPoolable poolable)
		{
		}

		public void Despawn()
		{
		}

		public void OnPoolInitialize()
		{
		}

		public void OnPoolSpawn()
		{
		}

		public void OnPoolDeInitialize()
		{
		}

		private void Validate()
		{
		}

		private void ValidatePoolee()
		{
		}

		private void ValidateBodies()
		{
		}

		[ContextMenu("ValidatePoseCache")]
		private void ValidatePoseCache()
		{
		}

		private void ValidateBody(MarrowBody mBody, Rigidbody rBody)
		{
		}

		private void ValidateJoints()
		{
		}

		private void ValidateJoint(MarrowJoint mJoint, ConfigurableJoint cJoint)
		{
		}

		private void GatherMarrowBehaviours()
		{
		}

		public MarrowEntity()
			: base()
		{
		}
	}
}
