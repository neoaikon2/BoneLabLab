using UnityEngine;

namespace SLZ.Bonelab
{
	public class ParticleEmissionController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] ParticleSystems;

		[SerializeField]
		private ParticleSystem.EmissionModule[] EmissionSystems;

		[HideInInspector]
		[SerializeField]
		private float[] EmissionMultipliers;

		private void Reset()
		{
		}

		private void Initialize()
		{
		}

		private void Awake()
		{
		}

		public void ChangeSystems(float rateMultiplier)
		{
		}
	}
}
