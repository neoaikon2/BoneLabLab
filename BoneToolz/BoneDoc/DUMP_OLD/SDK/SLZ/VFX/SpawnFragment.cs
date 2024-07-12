using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.VFX
{
	public class SpawnFragment : MarrowBehaviour
	{
		[SerializeField]
		private ImpactSFX _sfx;

		[SerializeField]
		public Renderer[] _renderer;

		[SerializeField]
		public ObjectDestructible _ObjectDestructible;

		private List<Material> cashedMats;

		private void Reset()
		{
		}

		public void UpdateFragmentPhysics(Vector3? velocity = default(Vector3?), Vector3? angularVelocity = default(Vector3?), float? mass = default(float?), Vector3? worldCenter = default(Vector3?), float? explosiveForce = default(float?))
		{
		}

		public void SetMaterial([CanBeNull] Material newMaterial)
		{
		}

		public void OverrideBlasterTint(Color color)
		{
		}

		[ContextMenu("Get Object Destructable")]
		public void getObjDest()
		{
		}

		public void EnableSound(float pitchMultiplier = 1f)
		{
		}

		public SpawnFragment()
			: base()
		{
		}
	}
}
