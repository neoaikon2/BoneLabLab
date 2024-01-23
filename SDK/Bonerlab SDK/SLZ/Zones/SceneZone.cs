using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Zones
{
	[RequireComponent(typeof(BoxCollider))]
	public class SceneZone : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoEnableOverTime_003Ed__54
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneZone _003C_003E4__this;

			public int length;

			private int _003Ci_003E5__2;

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
			public _003CCoEnableOverTime_003Ed__54(int _003C_003E1__state)
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

		private static ComponentCache<SceneZone> _cache;

		[SerializeField]
		[HideInInspector]
		public BoxCollider boxCollider;

		[CompilerGenerated]
		private static SceneZone _003CCurrentZone_003Ek__BackingField;

		[CompilerGenerated]
		private static GameObject _003CPlayerObject_003Ek__BackingField;

		private bool _wasZoneEnabled;

		private bool _isZoneEnabled;

		private bool _wasSubZone;

		private bool _isSubZone;

		private static bool _hasZonesChanged;

		public static List<SceneZone> _allZones;

		private static List<SceneZone> _triggeredZones;

		public static List<ZoneItem> _itemsToEnable;

		public static List<ZoneItem> _itemsToDisable;

		private static List<SceneZone> _zonesToEnable;

		private static List<SceneZone> _zonesToDisable;

		private static List<ZoneItem> _primaryItems;

		private static HashSet<ZoneItem> _enabledItems;

		public SceneZone[] linkedZones;

		public List<ZoneItem> zoneItems;

		public UnityEvent onZoneEnabled;

		public UnityEvent onZoneDisabled;

		public UnityEvent onPrimaryZoneEntered;

		public UnityEvent onPrimaryZoneExited;

		public UnityEvent onSecondaryZoneEntered;

		public UnityEvent onSecondaryZoneExited;

		public UnityEvent onPrimaryZoneEnteredOneTime;

		public UnityEvent onSecondaryZoneEnteredOneTime;

		public List<NPC_Data> npcDataList;

		[HideInInspector]
		public string titleChar;

		public static ComponentCache<SceneZone> Cache => null;

		public static SceneZone CurrentZone
		{
			[CompilerGenerated]
			get
			{
				return _003CCurrentZone_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				_003CCurrentZone_003Ek__BackingField = (SceneZone)value;
			}
		}

		public static GameObject PlayerObject
		{
			[CompilerGenerated]
			get
			{
				return _003CPlayerObject_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				_003CPlayerObject_003Ek__BackingField = (GameObject)value;
			}
		}

		public bool IsEnabled => false;

		public bool IsSubZone => false;

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void UpdateZonesState()
		{
		}

		private void DisableZone()
		{
		}

		private void EnableZone()
		{
		}

		public void RegisterZoneItem(ZoneItem item)
		{
		}

		public void DeregisterZoneItem(ZoneItem item)
		{
		}

		public void UpdateZoneItemsState()
		{
		}

		public void DisableItem(ZoneItem item, bool inSubZone = false)
		{
		}

		public void EnableItem(ZoneItem item, bool inSubZone = false)
		{
		}

		public void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CCoEnableOverTime_003Ed__54))]
		private IEnumerator CoEnableOverTime(int length)
		{
			return null;
		}
	}
}
