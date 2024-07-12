using System.Collections.Generic;
using SLZ.Marrow.Utilities;
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

		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public PortMetadata PortMetadata => default(PortMetadata);

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSensor_002EReadSensors(ref NodeState nodeState)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSource_002ECalculate(ref NodeState nodeState)
		{
		}

		public void Calculate(NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}

		public void ReadSensors(NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}
