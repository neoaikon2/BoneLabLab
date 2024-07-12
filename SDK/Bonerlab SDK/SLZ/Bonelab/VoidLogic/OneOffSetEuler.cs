using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.NotForRelease, "This is a one-off for testing.")]
	[AddComponentMenu(null)]
	public sealed class OneOffSetEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		internal MonoBehaviour[] _previous;

		[SerializeField]
		private bool _setOnActuation;

		[SerializeField]
		private Transform _target;

		private Vector3 targetRotation;

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

		private void Update()
		{
		}

		public void Actuate(NodeState nodeState)
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

		public OneOffSetEuler()
			: base()
		{
		}
	}
}
