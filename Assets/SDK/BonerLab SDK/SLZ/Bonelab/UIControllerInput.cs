using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIControllerInput : MonoBehaviour
	{
		private Transform _cursorTargetOverride;

		public Transform cursorTarget;

		public bool isLeft;

		private float m_levelReloadCounter;

		private float m_cur_levelReloadCounter;

		private bool m_appMenuButtonHeld;

		private IEnumerator reloadCoroutine;

		private bool m_canOpenMenu;

		public double initialActivateTime;

		private bool m_IsMenuActive;

		private bool _hasTriggeredThisFrame;

		public Transform CursorTarget => null;

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

		public void RemoveCursorTargetOverride()
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
