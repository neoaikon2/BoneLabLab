using System;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class WeaponSlot : MonoBehaviour
	{
		private static ComponentCache<WeaponSlot> _cache;

		public Action onMakeStaticAction;

		public Action onMakeDynamicAction;

		[Header("Options")]
		public SlotType slotType;

		[Header("References")]
		public InteractableHost interactableHost;

		public Grip grip;

		public UnityEvent onSlotInsert;

		public UnityEvent onSlotRemove;

		public static ComponentCache<WeaponSlot> Cache
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void OnMakeStatic()
		{
		}

		public void OnMakeDynamic()
		{
		}

		public WeaponSlot()
			: base()
		{
		}
	}
}
