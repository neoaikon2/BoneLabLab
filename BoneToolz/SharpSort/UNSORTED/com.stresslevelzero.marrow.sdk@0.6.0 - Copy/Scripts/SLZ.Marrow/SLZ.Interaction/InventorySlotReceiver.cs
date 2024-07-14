using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class InventorySlotReceiver : InventoryHandReceiver
	{
		[Range(0f, 10f)]
		public float priority;

		private WeaponSlot _slottedWeapon;

		private IGrippable _weaponHost;

		[EnumFlags]
		public SlotType slotType;

		private bool isInUIMode;

		public Vector3 primaryAxis;

		public bool isFlipped;

		public bool useOffset;

		public UnityEvent OnSlotActivate;

		public UnityEvent OnSlotDeactivate;

		private bool _isSlotActive;

		private HashSet<Hand> _hands;

		public static HashSet<IGrippable> ClaimedHosts { get; private set; }

		public IGrippable GetHost()
		{
			return null;
		}

		[ContextMenu("Despawn Contents")]
		private void DespawnContents()
		{
		}

		[ContextMenu("Respawn Contents")]
		private void RespawnContents()
		{
		}

		[ContextMenu("Destroy Contents")]
		private void DestroyContents()
		{
		}

		public void ReturnFromUI()
		{
		}

		public void SendToUI()
		{
		}
		private IEnumerator CoWaitLockMagazine()
		{
			return null;
		}

		private void OnDespawnSlotted(GameObject spawnObject)
		{
		}

		public void DropWeapon()
		{
		}

		private void MakeStatic()
		{
		}

		private void MakeDynamic()
		{
		}

		public void UpdateTransform()
		{
		}

		public override void OnHandGrab(Hand hand)
		{
		}

		public override void OnHandDrop(IGrippable host)
		{
		}

		public override float Validate(Hand hand)
		{
			return 0f;
		}

		private float ValidateGrab(Hand hand)
		{
			return 0f;
		}

		private float ValidateDrop(Hand hand)
		{
			return 0f;
		}
		public UniTask<bool> SpawnInSlotAsync(Barcode barcode)
		{
			return default(UniTask<bool>);
		}

		public override void OnHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverEnd(Hand hand)
		{
		}

		public bool InsertInSlot(InteractableHost host)
		{
			return false;
		}
	}
}
