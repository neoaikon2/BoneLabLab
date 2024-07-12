using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Collision Sensor One-off")]
	[Support(SupportFlags.CowboySupported, null)]
	public class OneOffCollisionSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
	{
		public enum Measurement
		{
			ForceMagnitude = 0,
			ForceX = 1,
			ForceY = 2,
			ForceZ = 3,
			TorqueX = 4,
			TorqueY = 5,
			TorqueZ = 6
		}

		[SerializeField]
		private Measurement _measurement;

		[SerializeField]
		private bool _negate;

		private Rigidbody _rigidbody;

		private readonly Queue<float> _impacts;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		void IVoidLogicSensor.ReadSensors(NodeState nodeState)
		{
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public OneOffCollisionSensor()
			: base()
		{
		}
	}
}
