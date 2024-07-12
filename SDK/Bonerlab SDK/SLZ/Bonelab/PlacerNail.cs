using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlacerNail : SpawnDecorator
	{
		[Tooltip("doesn't currently work, need to restructure part of impact sfx to fix it")]
		public AudioClip breakSFX;

		[Tooltip("If empty, will use transform of crate spawner")]
		public Transform nailTransform;

		public float breakforce;

		public MarrowJoint Joint { get; private set; }

		public override void OnSpawn(GameObject go)
		{
		}

		private void SetJoint(MarrowBody bodyA)
		{
		}

		private void SetImpactSFX(ImpactSFX impactSFX)
		{
		}

		public PlacerNail()
			: base()
		{
		}
	}
}
