using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIControllerInput : MonoBehaviour
	{
		private OpenController m_Controller;

		private OpenControllerRig openCtrlRig;

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
		private IEnumerator SceneReloadCounter()
		{
			return null;
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
