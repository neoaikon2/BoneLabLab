using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_intro : MonoBehaviour
	{
		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshProUGUI tmp_Title;

		public TextMeshProUGUI tmp_BuildInfo;

		public GameObject logoSLZ;

		public GameObject logoSabrelake;

		public GameObject canvasHeightCheck;

		public GameObject[] panelsHeightCheck;

		public GameObject canvasMainMenu;

		private bool m_waitForConfirm;

		private WaitForSeconds frameWait;

		public BodyVitals ctrl_bodyVitals;

		private void Awake()
		{
		}
		private IEnumerator Start()
		{
			return null;
		}

		public void NEXTSTEP()
		{
		}

		public void Update()
		{
		}
	}
}
