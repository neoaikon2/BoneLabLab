using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.UI;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaPopFX : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__29
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GachaPopFX _003C_003E4__this;

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
			public _003CFXChange_003Ed__29(int _003C_003E1__state)
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

		private static ComponentCache<GachaPopFX> _cache;

		public TextMeshPro text_unlockedItemType;

		public TextMeshPro text_unlockedItemName;

		public string unlockedItemType;

		public string unlockedItemName;

		public AnimationCurve curve_colorSize;

		public float holdTime;

		private float stopTime;

		private WaitForSeconds wait;

		public GameObject particlers;

		public Vector3 scale_target;

		private Vector3 scale_start_uit;

		private Vector3 scale_start_uin;

		private Vector3 scale_cur_uit;

		private Vector3 scale_cur_uin;

		public Color32 color_transparent;

		private Color32 color_start_uit;

		private Color32 color_start_uin;

		private Color32 color_cur_uit;

		private Color32 color_cur_uin;

		public SimpleSFX sfx_gacha;

		public Transform textTransform;

		public bool followHUD;

		public UI_HUD UIHUD;

		public static ComponentCache<GachaPopFX> Cache => null;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void PLAYFX(string itemType = "", string itemName = "")
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__29))]
		private IEnumerator FXChange()
		{
			return null;
		}
	}
}
