using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab.VoidLogic
{
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[Support(SupportFlags.CowboySupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Particle Emission Controller")]
	public class ParticleEmissionController : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour _previousNode;

		[FormerlySerializedAs("ParticleSystems")]
		[SerializeField]
		private ParticleSystem[] _particleSystems;

		private bool _disable;

		private ParticleSystem.EmissionModule[] _emissionSystems;

		private float[] _cachedRateMultipliers;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		PortMetadata IVoidLogicNode.PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		void IVoidLogicActuator.Actuate(NodeState nodeState)
		{
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public ParticleEmissionController()
			: base()
		{
		}
	}
}
