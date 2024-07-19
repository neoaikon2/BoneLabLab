using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ItemSlotsPanelView : PanelView
	{
		public UIRig uiRig;

		public SimpleSFX SimpleSfx;

		private Inventory inventory;

		private List<UnityAction> EnableActiveHoverEleActions;

		private List<UnityAction> DisableActiveHoverEleActions;

		private List<UnityAction> DisableInactiveHoverEleActions;

		private List<UnityAction> EnableInactiveHoverEleActions;

		private UnityAction PlayActiveSoundAction;

		private UnityAction PlayDropSoundAction;

		public Transform[] slotTargets;

		public PageElementView[] slots;

		public GameObject[] activeHoverEleObjs;

		public GameObject[] inactiveHoverEleObjs;

		public bool displayHud;

		public UI_HUD objectHud;

		[HideInInspector]
		public bool isInventoryOpen;

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public override bool Trigger()
		{
			return false;
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void RegisterBodySlotEvents()
		{
		}

		private void UnregisterBodySlotEvents()
		{
		}

		public void HOTSWAP(bool tempMove = true)
		{
		}
		private IEnumerator CoCloseAnimation(Action callback)
		{
			return null;
		}
		private IEnumerator CoSummonAnimation()
		{
			return null;
		}
	}
}
