using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ItemSlotsPanelView : PanelView
	{
		public UIRig uiRig;

		public Transform[] slotTargets;

		private Inventory inventory;

		public PageElementView[] slots;

		public bool displayHud;

		public UI_HUD objectHud;

		[HideInInspector]
		public bool isInventoryOpen;

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
