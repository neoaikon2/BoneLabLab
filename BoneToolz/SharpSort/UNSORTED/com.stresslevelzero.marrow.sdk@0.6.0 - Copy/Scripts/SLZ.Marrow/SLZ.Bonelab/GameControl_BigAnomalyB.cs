using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_BigAnomalyB : BonelabInternalGameControl
	{
		[Header("Animation Stuff")]
		public RigManager rm;

		public TutorialTrigger bodyLogTutorial;

		public GenericAnimatorController animationController;

		public CrateSpawner jimmyKey;

		public MarrowEntity jimmyKeyEntity;

		[SerializeField]
		private GameObject bodyLogObj;

		[SerializeField]
		private PullCordDevice bodyLog;

		[SerializeField]
		private GameObject lightingRoot;

		[SerializeField]
		private GameObject targetObj;

		[SerializeField]
		[Header("FX")]
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

		private static PlayerProgression p => null;

		public override void DoLevelComplete()
		{
		}

		public void SaveBigJimmyKey()
		{
		}

		public override void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void ActivateBodyLog()
		{
		}

		public void ActivateKey()
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

		private void EndTutorial()
		{
		}
	}
}
