using UnityEngine;

namespace SLZ.Bonelab
{
	public class ParticleEmissionController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem[] ParticleSystems;

		[SerializeField]
		private ParticleSystem.EmissionModule[] EmissionSystems;

		[SerializeField]
		[HideInInspector]
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

		public ParticleEmissionController()
			: base()
		{
		}
	}
}
