using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_BigAnomalyA : BonelabInternalGameControl
	{
		[Header("Animation Stuff")]
		[SerializeField]
		private GameObject bodyLogObj;

		[SerializeField]
		private GameObject lightingRoot;

		[SerializeField]
		private GameObject targetObj;

		[Header("FX")]
		[SerializeField]
		private GameObject lightningBoltObj;

		[SerializeField]
		private MeshRenderer lightningRend;

		[SerializeField]
		private GameObject lightingHitParticles;

		[SerializeField]
		private GameObject lightingHitParticles2;

		[SerializeField]
		private GameObject lightingPathParticles;

		[Header("Audio")]
		[SerializeField]
		private AudioClip shockClip;

		[SerializeField]
		private AudioClip hitClip;

		public override void Awake()
		{
		}

		public void AquireBodyLog()
		{
		}

		[ContextMenu("TestStrike")]
		public void TestStrike()
		{
		}

		public void TargetLightning(Vector3 target)
		{
		}
		private IEnumerator CoLightingPos()
		{
			return null;
		}
		private IEnumerator CoLightningFX(Vector3 target)
		{
			return null;
		}
	}
}
