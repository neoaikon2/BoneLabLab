using System.Runtime.CompilerServices;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.CowboySupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Transform Sensor One-off")]
	public class OneOffTransformSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
	{
		public enum Measurement
		{
			DistanceMagnitude = 0,
			DistanceXMagnitude = 1,
			DistanceYMagnitude = 2,
			DistanceZMagnitude = 3,
			DistanceX = 4,
			DistanceY = 5,
			DistanceZ = 6,
			RotationEulerX = 7,
			RotationEulerY = 8,
			RotationEulerZ = 9
		}

		[SerializeField]
		private Transform _anchor;

		[SerializeField]
		private Transform _connectedTransform;

		[SerializeField]
		private Measurement _measurement;

		[SerializeField]
		private bool _negate;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
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

		void IVoidLogicSensor.ReadSensors(NodeState nodeState)
		{
		}

		private float _wrap(float angleDegrees)
		{
			return default(float);
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public OneOffTransformSensor()
			: base()
		{
		}
	}
}
