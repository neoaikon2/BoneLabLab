using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BlipHelper : MonoBehaviour
	{
		public float blipWaitTime;

		public Grip[] grips;

		public Blip blip;

		private bool fired;

		private void Start()
		{
		}

		public void DESTROYOBJ()
		{
		}
		private IEnumerator DespawnCoroutine()
		{
			return null;
		}
	}
}
