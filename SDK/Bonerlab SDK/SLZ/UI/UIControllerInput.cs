using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.UI
{
	public class UIControllerInput : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSceneReloadCounter_003Ed__24
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIControllerInput _003C_003E4__this;

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
			public _003CSceneReloadCounter_003Ed__24(int _003C_003E1__state)
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

		private static ComponentCache<UIControllerInput> _cache;

		private BaseController m_Controller;

		private RigManager m_Manager;

		[HideInInspector]
		private List<Transform> _cursorTargetOverrides;

		public Transform cursorTarget;

		private float m_levelReloadCounter;

		private float m_cur_levelReloadCounter;

		private bool m_appMenuButtonHeld;

		private IEnumerator reloadCoroutine;

		private bool m_canOpenMenu;

		public double initialActivateTime;

		private bool m_IsMenuActive;

		private bool _hasTriggeredThisFrame;

		public static ComponentCache<UIControllerInput> Cache => null;

		[field: SerializeField]
		public Spawnable VfxFadeOutSpawnable { get; protected set; }

		public Transform CursorTarget => null;

		private void Awake()
		{
		}

		public void Start()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CSceneReloadCounter_003Ed__24))]
		private IEnumerator SceneReloadCounter()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void RemoveCursorTargetOverride(Transform transform)
		{
		}

		public void AddCursorTargetOverride(Transform transform)
		{
		}

		public void ResetLevel()
		{
		}
	}
}
